namespace ElDewrito_Multi_Instance
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tctMain = new System.Windows.Forms.TabControl();
            this.tabProfiles = new System.Windows.Forms.TabPage();
            this.btnReloadProfiles = new System.Windows.Forms.Button();
            this.btnAddProfile = new System.Windows.Forms.Button();
            this.btnRemoveProfile = new System.Windows.Forms.Button();
            this.lblProfiles = new System.Windows.Forms.Label();
            this.clbProfiles = new System.Windows.Forms.CheckedListBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.gbxProfileSpecific = new System.Windows.Forms.GroupBox();
            this.gbxLaunchOrder = new System.Windows.Forms.GroupBox();
            this.gbxUniversal = new System.Windows.Forms.GroupBox();
            this.tabLaunch = new System.Windows.Forms.TabPage();
            this.tctMain.SuspendLayout();
            this.tabProfiles.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctMain
            // 
            this.tctMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tctMain.Controls.Add(this.tabProfiles);
            this.tctMain.Controls.Add(this.tabSettings);
            this.tctMain.Controls.Add(this.tabLaunch);
            this.tctMain.Location = new System.Drawing.Point(0, 0);
            this.tctMain.Name = "tctMain";
            this.tctMain.SelectedIndex = 0;
            this.tctMain.Size = new System.Drawing.Size(425, 295);
            this.tctMain.TabIndex = 0;
            this.tctMain.SizeChanged += new System.EventHandler(this.tctMain_SizeChanged);
            // 
            // tabProfiles
            // 
            this.tabProfiles.Controls.Add(this.btnReloadProfiles);
            this.tabProfiles.Controls.Add(this.btnAddProfile);
            this.tabProfiles.Controls.Add(this.btnRemoveProfile);
            this.tabProfiles.Controls.Add(this.lblProfiles);
            this.tabProfiles.Controls.Add(this.clbProfiles);
            this.tabProfiles.Location = new System.Drawing.Point(4, 22);
            this.tabProfiles.Name = "tabProfiles";
            this.tabProfiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfiles.Size = new System.Drawing.Size(417, 269);
            this.tabProfiles.TabIndex = 0;
            this.tabProfiles.Text = "Profiles";
            this.tabProfiles.UseVisualStyleBackColor = true;
            this.tabProfiles.Resize += new System.EventHandler(this.tabProfiles_Resize);
            // 
            // btnReloadProfiles
            // 
            this.btnReloadProfiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReloadProfiles.Location = new System.Drawing.Point(128, 197);
            this.btnReloadProfiles.Name = "btnReloadProfiles";
            this.btnReloadProfiles.Size = new System.Drawing.Size(286, 23);
            this.btnReloadProfiles.TabIndex = 7;
            this.btnReloadProfiles.Text = "Reload profiles";
            this.btnReloadProfiles.UseVisualStyleBackColor = true;
            this.btnReloadProfiles.Click += new System.EventHandler(this.btnReloadProfiles_Click);
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddProfile.Location = new System.Drawing.Point(128, 220);
            this.btnAddProfile.Name = "btnAddProfile";
            this.btnAddProfile.Size = new System.Drawing.Size(286, 23);
            this.btnAddProfile.TabIndex = 6;
            this.btnAddProfile.Text = "Add profile";
            this.btnAddProfile.UseVisualStyleBackColor = true;
            // 
            // btnRemoveProfile
            // 
            this.btnRemoveProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRemoveProfile.Location = new System.Drawing.Point(128, 243);
            this.btnRemoveProfile.Name = "btnRemoveProfile";
            this.btnRemoveProfile.Size = new System.Drawing.Size(286, 23);
            this.btnRemoveProfile.TabIndex = 4;
            this.btnRemoveProfile.Text = "Remove selected profile";
            this.btnRemoveProfile.UseVisualStyleBackColor = true;
            this.btnRemoveProfile.Click += new System.EventHandler(this.btnRemoveProfile_Click);
            // 
            // lblProfiles
            // 
            this.lblProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProfiles.Location = new System.Drawing.Point(136, 5);
            this.lblProfiles.Name = "lblProfiles";
            this.lblProfiles.Size = new System.Drawing.Size(272, 85);
            this.lblProfiles.TabIndex = 1;
            this.lblProfiles.Text = "Profiles are stored in your Halo Online installation directory as dewrito_prefs_\'" +
    "profile name\'.cfg.\r\n\r\nTo use a profile, make sure it\'s checked!\r\n\r\nYou can have " +
    "up to eight profiles in use at once.";
            // 
            // clbProfiles
            // 
            this.clbProfiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.clbProfiles.FormattingEnabled = true;
            this.clbProfiles.Location = new System.Drawing.Point(3, 3);
            this.clbProfiles.Name = "clbProfiles";
            this.clbProfiles.Size = new System.Drawing.Size(125, 263);
            this.clbProfiles.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.gbxProfileSpecific);
            this.tabSettings.Controls.Add(this.gbxLaunchOrder);
            this.tabSettings.Controls.Add(this.gbxUniversal);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(417, 269);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // gbxProfileSpecific
            // 
            this.gbxProfileSpecific.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxProfileSpecific.Location = new System.Drawing.Point(219, 3);
            this.gbxProfileSpecific.Name = "gbxProfileSpecific";
            this.gbxProfileSpecific.Size = new System.Drawing.Size(108, 263);
            this.gbxProfileSpecific.TabIndex = 3;
            this.gbxProfileSpecific.TabStop = false;
            this.gbxProfileSpecific.Text = "Profile Specific";
            // 
            // gbxLaunchOrder
            // 
            this.gbxLaunchOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxLaunchOrder.Location = new System.Drawing.Point(111, 3);
            this.gbxLaunchOrder.Name = "gbxLaunchOrder";
            this.gbxLaunchOrder.Size = new System.Drawing.Size(108, 263);
            this.gbxLaunchOrder.TabIndex = 2;
            this.gbxLaunchOrder.TabStop = false;
            this.gbxLaunchOrder.Text = "Launch Order";
            // 
            // gbxUniversal
            // 
            this.gbxUniversal.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxUniversal.Location = new System.Drawing.Point(3, 3);
            this.gbxUniversal.Name = "gbxUniversal";
            this.gbxUniversal.Size = new System.Drawing.Size(108, 263);
            this.gbxUniversal.TabIndex = 0;
            this.gbxUniversal.TabStop = false;
            this.gbxUniversal.Text = "Universal";
            // 
            // tabLaunch
            // 
            this.tabLaunch.Location = new System.Drawing.Point(4, 22);
            this.tabLaunch.Name = "tabLaunch";
            this.tabLaunch.Size = new System.Drawing.Size(417, 269);
            this.tabLaunch.TabIndex = 2;
            this.tabLaunch.Text = "Launch";
            this.tabLaunch.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 294);
            this.Controls.Add(this.tctMain);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(440, 333);
            this.Name = "frmMain";
            this.Text = "ElDewrito Multi Instance";
            this.tctMain.ResumeLayout(false);
            this.tabProfiles.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctMain;
        private System.Windows.Forms.TabPage tabProfiles;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabLaunch;
        private System.Windows.Forms.CheckedListBox clbProfiles;
        private System.Windows.Forms.Label lblProfiles;
        private System.Windows.Forms.Button btnReloadProfiles;
        private System.Windows.Forms.Button btnAddProfile;
        private System.Windows.Forms.Button btnRemoveProfile;
        private System.Windows.Forms.GroupBox gbxUniversal;
        private System.Windows.Forms.GroupBox gbxProfileSpecific;
        private System.Windows.Forms.GroupBox gbxLaunchOrder;
    }
}

