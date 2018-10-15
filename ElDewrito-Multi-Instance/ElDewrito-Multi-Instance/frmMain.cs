using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElDewrito_Multi_Instance
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            Icon = Properties.Resources.logo;

            ProfilesManager profilesManager = new ProfilesManager();
            SettingsManager settingsManager = new SettingsManager(profilesManager);
            ProcessManager processManager = new ProcessManager();
        }
    }
}
