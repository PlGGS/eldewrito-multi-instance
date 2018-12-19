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
        ProfilesManager profilesManager;
        SettingsManager settingsManager;
        ProcessManager processManager;

        public frmMain()
        {
            InitializeComponent();

            Icon = Properties.Resources.logo;
            executableDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;

            settingsManager = new SettingsManager(executableDirectoryPath);
            profilesManager = new ProfilesManager(executableDirectoryPath, settingsManager, clbProfiles);
            processManager = new ProcessManager(executableDirectoryPath, profilesManager, settingsManager);
        }

        private void btnReloadProfiles_Click(object sender, EventArgs e)
        {
            profilesManager.ReloadProfiles();
        }

        private void btnAddProfile_Click(object sender, EventArgs e)
        {
            profilesManager.AddProfile();
        }

        private void btnRemoveProfile_Click(object sender, EventArgs e)
        {
            profilesManager.RemoveProfile();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            chkFullscreen.Checked = Convert.ToBoolean(Convert.ToInt32(settingsManager.Fullscreen));
            //TODO fill cbxResolution and set it
            //TODO fill cbxGraphicsQuality and set it
            chkAntiAliasing.Checked = Convert.ToBoolean(Convert.ToInt32(settingsManager.AntiAliasing));
            chkVSync.Checked = Convert.ToBoolean(Convert.ToInt32(settingsManager.VSync));

            cbxNumberOfInstances.SelectedValue = 0;
        }

        private void clbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            clbProfiles.Bounds = new Rectangle(clbProfiles.Location, new Size(clbProfiles.Width, btnReloadProfiles.Top - 22));
            lsvLaunchOrder.Bounds = new Rectangle(clbProfiles.Location, new Size(clbProfiles.Width, btnMoveInstanceUp.Top - 22));
            btnLaunch.Bounds = new Rectangle(btnLaunch.Location, new Size(btnLaunch.Width, gbxProfileSpecificSettings.Location.Y - btnLaunch.Top - 6));
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (running == false)
            {
                running = true;
                btnLaunch.Text = "Close instances";

                processManager.Launch(settingsManager.NumberOfInstances);
            }
            else
            {
                running = false;
                btnLaunch.Text = "Launch";


            }
        }
    }
}
