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
            chkFullscreen.Checked = Convert.ToBoolean(Convert.ToInt32(settingManager.Fullscreen));
            chkConsoleMode.Checked = Convert.ToBoolean(Convert.ToInt32(settingManager.ConsoleMode));
            chkVSync.Checked = Convert.ToBoolean(Convert.ToInt32(settingManager.VSync));
            chkAntiAliasing.Checked = Convert.ToBoolean(Convert.ToInt32(settingManager.AntiAliasing));
            chkKeyboardControlsP1.Checked = Convert.ToBoolean(Convert.ToInt32(settingManager.KeyboardControlsP1));

            clbProfiles.SelectedIndex = 0;
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

                processManager.Launch(lsbLaunchOrder.Items.Count);
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
            settingManager.Fullscreen = Convert.ToInt16(chkFullscreen.Checked).ToString();
            Properties.Settings.Default.Save();
        }

        private void chkConsoleMode_CheckedChanged(object sender, EventArgs e)
        {
            settingManager.ConsoleMode = Convert.ToInt16(chkConsoleMode.Checked).ToString();
            Properties.Settings.Default.Save();
        }

        private void chkVSync_CheckedChanged(object sender, EventArgs e)
        {
            settingManager.VSync = Convert.ToInt16(chkVSync.Checked).ToString();
            Properties.Settings.Default.Save();
        }

        private void chkAntiAliasing_CheckedChanged(object sender, EventArgs e)
        {
            settingManager.AntiAliasing = Convert.ToInt16(chkAntiAliasing.Checked).ToString();
            Properties.Settings.Default.Save();
        }

        private void chkKeyboardControlsP1_CheckedChanged(object sender, EventArgs e)
        {
            settingManager.KeyboardControlsP1 = Convert.ToInt16(chkKeyboardControlsP1.Checked).ToString();
            Properties.Settings.Default.Save();
        }

        private void clbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resolution = profileManager.ReadProfileSetting(clbProfiles.Text, "Settings.ScreenResolution");

            if (resolution != "default")
            {
                SetHAndVResolutions(resolution);
            }
            else
            {
                profileManager.WriteProfileSetting(clbProfiles.Text, "Settings.ScreenResolution", "1920x1080");
                SetHAndVResolutions(profileManager.ReadProfileSetting(clbProfiles.Text, "Settings.ScreenResolution"));
            }

            void SetHAndVResolutions(string res)
            {
                try
                {
                    txtHResolution.Text = res.Substring(0, res.Length - res.IndexOf('x') - 1); //TODO figure out why 1280x720 is not working
                    txtVResolution.Text = res.Substring(res.IndexOf('x') + 1, res.Length - (res.IndexOf('x') + 1));
                }
                catch (Exception)
                {
                    profileManager.WriteProfileSetting(clbProfiles.Text, "Settings.ScreenResolution", $"{Screen.PrimaryScreen.Bounds.Width}x{ Screen.PrimaryScreen.Bounds.Height}");
                }
            }

            SetcbxGraphicsQuality();
        }

        private void SetcbxGraphicsQuality()
        {
            string[] qualities = profileManager.ReadProfileSettings(clbProfiles.Text, new string[] { "Settings.DetailsQuality",
                                                                                        "Settings.EffectsQuality",
                                                                                        "Settings.LightingQuality",
                                                                                        "Settings.PostprocessingQuality",
                                                                                        "Settings.ShadowQuality",
                                                                                        "Settings.TextureFilteringQuality",
                                                                                        "Settings.TextureResolution" });

            if (Enumerable.SequenceEqual(qualities, new string[] { "low", "low", "low", "low", "low", "low", "low" }))
            {
                cbxGraphicsQuality.SelectedIndex = 0;
            }
            else if (Enumerable.SequenceEqual(qualities, new string[] { "medium", "medium", "medium", "medium", "medium", "medium", "medium" }))
            {
                cbxGraphicsQuality.SelectedIndex = 1;
            }
            else if (Enumerable.SequenceEqual(qualities, new string[] { "high", "high", "high", "high", "high", "high", "high" }))
            {
                cbxGraphicsQuality.SelectedIndex = 2;
            }
            else
            {
                if (qualities[0] == "low")
                {
                    for (int i = 1; i < qualities.Length; i++)
                    {
                        profileManager.WriteProfileSetting(clbProfiles.Text, qualities[i], "low");
                    }

                    cbxGraphicsQuality.SelectedIndex = 0;
                }
                else if (qualities[0] == "medium")
                {
                    for (int i = 1; i < qualities.Length; i++)
                    {
                        profileManager.WriteProfileSetting(clbProfiles.Text, qualities[i], "medium");
                    }

                    cbxGraphicsQuality.SelectedIndex = 1;
                }
                else if (qualities[0] == "high")
                {
                    for (int i = 1; i < qualities.Length; i++)
                    {
                        profileManager.WriteProfileSetting(clbProfiles.Text, qualities[i], "high");
                    }

                    cbxGraphicsQuality.SelectedIndex = 2;
                }
            }
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

        private void btnMoveInstanceUp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbLaunchOrder.Items.Count; i++)
            {
                if (lsbLaunchOrder.Items[i] == lsbLaunchOrder.SelectedItem && lsbLaunchOrder.SelectedIndex != 0)
                {
                    int newIndex = lsbLaunchOrder.SelectedIndex - 1;

                    lsbLaunchOrder.Items.Insert(lsbLaunchOrder.SelectedIndex - 1, lsbLaunchOrder.Items[lsbLaunchOrder.SelectedIndex]);
                    lsbLaunchOrder.Items.RemoveAt(lsbLaunchOrder.SelectedIndex);

                    lsbLaunchOrder.SelectedIndex = newIndex;
                }
            }

            profileManager.WriteSelectedProfiles(lsbLaunchOrder.Items.OfType<string>().ToArray());
        }

        private void btnMoveInstanceDown_Click(object sender, EventArgs e)
        {
            for (int i = lsbLaunchOrder.Items.Count - 1; i >= 0; i--)
            {
                if (lsbLaunchOrder.Items[i] == lsbLaunchOrder.SelectedItem && lsbLaunchOrder.SelectedIndex != lsbLaunchOrder.Items.Count - 1)
                {
                    int newIndex = lsbLaunchOrder.SelectedIndex + 1;

                    lsbLaunchOrder.Items.Insert(lsbLaunchOrder.SelectedIndex + 2, lsbLaunchOrder.Items[lsbLaunchOrder.SelectedIndex]);
                    lsbLaunchOrder.Items.RemoveAt(lsbLaunchOrder.SelectedIndex);

                    lsbLaunchOrder.SelectedIndex = newIndex;
                }
            }
            
            profileManager.WriteSelectedProfiles(lsbLaunchOrder.Items.OfType<string>().ToArray());
        }

        private void lblConsoleMode_Click(object sender, EventArgs e)
        {
            chkConsoleMode.Checked = !chkConsoleMode.Checked;

            //TODO show console mode setup window
        }

        private void lblVSync_Click(object sender, EventArgs e)
        {
            chkVSync.Checked = !chkVSync.Checked;
        }

        private void lblAntiAliasing_Click(object sender, EventArgs e)
        {
            chkAntiAliasing.Checked = !chkAntiAliasing.Checked;
        }

        private void lblKeyboardControlsP1_Click(object sender, EventArgs e)
        {
            chkKeyboardControlsP1.Checked = !chkKeyboardControlsP1.Checked;
        }

        private void lblFullscreen_Click(object sender, EventArgs e)
        {
            chkFullscreen.Checked = !chkFullscreen.Checked;
        }

        private void lblConnectAllToServer_Click(object sender, EventArgs e)
        {
            chkConnectAllToServer.Checked = !chkConnectAllToServer.Checked;
        }

        private void chkConnectAllToServer_CheckedChanged(object sender, EventArgs e)
        {
            //TODO check if checked, if not, new form with browser, if so, uncheck
        }

        private void txtHResolution_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtHResolution.Text == "")
                {
                    profileManager.WriteProfileSetting(clbProfiles.Text, "Settings.ScreenResolution", $"640x{txtVResolution.Text}");
                }
                else
                {
                    profileManager.WriteProfileSetting(clbProfiles.Text, "Settings.ScreenResolution", $"{txtHResolution.Text}x{txtVResolution.Text}");
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtVResolution_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtVResolution.Text == "")
                {
                    profileManager.WriteProfileSetting(clbProfiles.Text, "Settings.ScreenResolution", $"{txtHResolution.Text}x480");
                }
                else
                {
                    profileManager.WriteProfileSetting(clbProfiles.Text, "Settings.ScreenResolution", $"{txtHResolution.Text}x{txtVResolution.Text}");
                }
            }
            catch (Exception)
            {

            }
        }

        private void cbxGraphicsQuality_TextChanged(object sender, EventArgs e)
        {
            WriteQuality();
        }

        private void WriteQuality()
        {
            string[] qualities = profileManager.ReadProfileSettings(clbProfiles.Text, new string[] { "Settings.DetailsQuality",
                                                                                        "Settings.EffectsQuality",
                                                                                        "Settings.LightingQuality",
                                                                                        "Settings.PostprocessingQuality",
                                                                                        "Settings.ShadowQuality",
                                                                                        "Settings.TextureFilteringQuality",
                                                                                        "Settings.TextureResolution" });

            if (!Enumerable.SequenceEqual(qualities, new string[] { cbxGraphicsQuality.Text, cbxGraphicsQuality.Text, cbxGraphicsQuality.Text, cbxGraphicsQuality.Text, cbxGraphicsQuality.Text, cbxGraphicsQuality.Text, cbxGraphicsQuality.Text }))
            {
                profileManager.WriteProfileSetting(clbProfiles.Text, "Settings.DetailsQuality", cbxGraphicsQuality.Text);
                profileManager.WriteProfileSetting(clbProfiles.Text, "Settings.EffectsQuality", cbxGraphicsQuality.Text);
                profileManager.WriteProfileSetting(clbProfiles.Text, "Settings.LightingQuality", cbxGraphicsQuality.Text);
                profileManager.WriteProfileSetting(clbProfiles.Text, "Settings.PostprocessingQuality", cbxGraphicsQuality.Text);
                profileManager.WriteProfileSetting(clbProfiles.Text, "Settings.ShadowQuality", cbxGraphicsQuality.Text);
                profileManager.WriteProfileSetting(clbProfiles.Text, "Settings.TextureFilteringQuality", cbxGraphicsQuality.Text);
                profileManager.WriteProfileSetting(clbProfiles.Text, "Settings.TextureResolution", cbxGraphicsQuality.Text);
            }

        }
    }
}
