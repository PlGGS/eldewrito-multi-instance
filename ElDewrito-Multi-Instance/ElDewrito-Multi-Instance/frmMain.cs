using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElDewrito_Multi_Instance
{
    public partial class frmMain : Form
    {
        bool running = false;
        string executableDirectoryPath;
        ProfileManager profileManager;
        SettingManager settingManager;
        ProcessManager processManager;

        public frmMain()
        {
            InitializeComponent();

            Icon = Properties.Resources.logo;
            executableDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;

            settingManager = new SettingManager(executableDirectoryPath);
            profileManager = new ProfileManager(executableDirectoryPath, settingManager, clbProfiles);
            processManager = new ProcessManager(executableDirectoryPath, profileManager, settingManager);
        }

        private void btnReloadProfiles_Click(object sender, EventArgs e)
        {
            profileManager.ReloadProfiles();
        }

        private void btnAddProfile_Click(object sender, EventArgs e)
        {
            Form frmAddProfile = new frmAddProfile(new Point(Bounds.X + (Bounds.Width / 2) - (293 / 2), Bounds.Y + (Bounds.Height / 2) - (112 / 2)), clbProfiles, profileManager);
            frmAddProfile.Show();
        }

        private void btnRemoveProfile_Click(object sender, EventArgs e)
        {
            profileManager.DeleteProfilePrefs(clbProfiles.Text); //TODO figure out why this is passing ""
            clbProfiles.Items.Remove(clbProfiles.SelectedItem);
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            cbxNumberOfInstances.SelectedIndex = Properties.Settings.Default.NumberOfInstances;
            chkFullscreen.Checked = Convert.ToBoolean(Convert.ToInt32(settingManager.Fullscreen));
            chkConsoleMode.Checked = Convert.ToBoolean(Convert.ToInt32(settingManager.ConsoleMode));
            chkVSync.Checked = Convert.ToBoolean(Convert.ToInt32(settingManager.VSync));
            chkAntiAliasing.Checked = Convert.ToBoolean(Convert.ToInt32(settingManager.AntiAliasing));
            chkKeyboardControlsP1.Checked = Convert.ToBoolean(Convert.ToInt32(settingManager.KeyboardControlsP1));
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            clbProfiles.Bounds = new Rectangle(clbProfiles.Location, new Size(clbProfiles.Width, btnReloadProfiles.Top - 22));
            lsbLaunchOrder.Bounds = new Rectangle(clbProfiles.Location, new Size(clbProfiles.Width, btnMoveInstanceUp.Top - 22));
            btnLaunch.Bounds = new Rectangle(btnLaunch.Location, new Size(btnLaunch.Width, gbxProfileSpecificSettings.Location.Y - btnLaunch.Top - 6));
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (running == false)
            {
                running = true;
                btnLaunch.Text = "Close instances";

                processManager.Launch(settingManager.NumberOfInstances);
            }
            else
            {
                running = false;
                btnLaunch.Text = "Launch";

                processManager.CloseInstances();
            }
        }

        private void chkFullscreen_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Fullscreen = Convert.ToInt16(chkFullscreen.Checked).ToString();
            Properties.Settings.Default.Save();
        }

        private void chkConsoleMode_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConsoleMode = Convert.ToInt16(chkConsoleMode.Checked).ToString();
            Properties.Settings.Default.Save();
        }

        private void chkVSync_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VSync = Convert.ToInt16(chkVSync.Checked).ToString();
            Properties.Settings.Default.Save();
        }

        private void chkAntiAliasing_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AntiAliasing = Convert.ToInt16(chkAntiAliasing.Checked).ToString();
            Properties.Settings.Default.Save();
        }

        private void chkKeyboardControlsP1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.KeyboardControlsP1 = Convert.ToInt16(chkKeyboardControlsP1.Checked).ToString();
            Properties.Settings.Default.Save();
        }

        private void clbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resolution = profileManager.ReadProfileSetting(clbProfiles.Text, "Settings.ScreenResolution");

            if (resolution != "default")
            {
                txtHResolution.Text = resolution.Substring(0, resolution.Length - resolution.IndexOf('x') - 1);
                txtVResolution.Text = resolution.Substring(resolution.IndexOf('x') + 1, resolution.Length - (resolution.IndexOf('x') + 1));
            }

            //TODO fill cbxGraphicsQuality
            
        }

        private void cbxNumberOfInstances_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.NumberOfInstances = Convert.ToSByte(cbxNumberOfInstances.SelectedIndex);
            Properties.Settings.Default.Save();
        }

        public void AddProfileToProfiles(string name)
        {
            clbProfiles.Items.Add(name);
            lsbLaunchOrder.Items.Add(name);
        }

        private void clbProfiles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            lsbLaunchOrder.Items.Clear();
            File.Delete(processManager.Configuration);

            List<string> profileNames = clbProfiles.CheckedItems.OfType<string>().ToList<string>();

            if (e.NewValue == CheckState.Checked)
                profileNames.Add(clbProfiles.Items[e.Index].ToString());
            else
                profileNames.Remove(clbProfiles.Items[e.Index].ToString());

            using (StreamWriter w = new StreamWriter(processManager.Configuration))
            {
                for (int i = 0; i < profileNames.Count; i++)
                {
                    lsbLaunchOrder.Items.Add(profileNames[i]);
                    w.WriteLine(profileNames[i]);

                    if (Convert.ToBoolean(Convert.ToInt32(settingManager.KeyboardControlsP1)) == true && i == 0)
                    {
                        profileManager.WriteProfileSetting(profileNames[i], "Settings.Gamepad", "0");
                    }
                    else
                    {
                        profileManager.WriteProfileSetting(profileNames[i], "Settings.Gamepad", "1");
                    }

                    profileManager.WriteProfileSetting(profileNames[i], "Input.ControllerPort", i.ToString());
                }
            }
        }
    }
}
