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

        private void tabProfiles_Resize(object sender, EventArgs e)
        {
            clbProfiles.Bounds = new Rectangle(clbProfiles.Location, new Size(clbProfiles.Bounds.Width, tabProfiles.Bounds.Height));
        }
    }
}
