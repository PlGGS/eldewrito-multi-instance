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
    public partial class frmAddProfile : Form
    {
        readonly Point xy;
        ProfileManager profileManager;
        CheckedListBox clbProfiles;

        public frmAddProfile(Point xy, CheckedListBox clbProfiles, ProfileManager profileManager)
        {
            InitializeComponent();
            this.xy = xy;
            this.clbProfiles = clbProfiles;
            this.profileManager = profileManager;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProfileName.Text.Length < 1 || txtProfileName.Text.Length > 16)
            {
                MessageBox.Show("Please enter a name with a minimum of 1 and a maximum of 15 characters!", "Eldewrito Multi Instance");
                return;
            }

            profileManager.CreateProfilePrefs(txtProfileName.Text);
            profileManager.ReloadProfiles();

            Close();
        }

        private void frmAddProfile_Load(object sender, EventArgs e)
        {
            Location = xy;
            Icon = Properties.Resources.logo;
        }
    }
}
