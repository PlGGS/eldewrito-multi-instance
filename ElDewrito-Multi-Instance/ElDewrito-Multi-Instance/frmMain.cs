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
            FixSettingsGroupBoxes();

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

        private void tctMain_SizeChanged(object sender, EventArgs e)
        {
            FixSettingsGroupBoxes();
        }

        private void FixSettingsGroupBoxes()
        {
            foreach (Control groupBox in tabSettings.Controls)
            {
                groupBox.Width = tabSettings.Width / 3 - 2;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            chkWindowedMode.Checked = Convert.ToBoolean(Convert.ToInt32(settingsManager.WindowedMode));
            //TODO fill cbxResolution and set it
            //TODO fill cbxGraphicsQuality and set it
            chkAntiAliasing.Checked = Convert.ToBoolean(Convert.ToInt32(settingsManager.AntiAliasing));
            chkVSync.Checked = Convert.ToBoolean(Convert.ToInt32(settingsManager.VSync));
        }
    }
}
