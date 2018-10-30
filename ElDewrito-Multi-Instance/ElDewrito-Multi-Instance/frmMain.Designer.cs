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
            this.chkVSync = new System.Windows.Forms.CheckBox();
            this.chkAntiAliasing = new System.Windows.Forms.CheckBox();
            this.chkWindowedMode = new System.Windows.Forms.CheckBox();
            this.lblVSync = new System.Windows.Forms.Label();
            this.lblAntiAliasing = new System.Windows.Forms.Label();
            this.lblGraphicsQuality = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            this.lblWindowedMode = new System.Windows.Forms.Label();
            this.tabLaunch = new System.Windows.Forms.TabPage();
            this.cbxResolution = new System.Windows.Forms.ComboBox();
            this.cbxGraphicsQuality = new System.Windows.Forms.ComboBox();
            this.tctMain.SuspendLayout();
            this.tabProfiles.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.gbxUniversal.SuspendLayout();
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
            this.gbxProfileSpecific.Location = new System.Drawing.Point(277, 3);
            this.gbxProfileSpecific.Name = "gbxProfileSpecific";
            this.gbxProfileSpecific.Size = new System.Drawing.Size(137, 263);
            this.gbxProfileSpecific.TabIndex = 3;
            this.gbxProfileSpecific.TabStop = false;
            this.gbxProfileSpecific.Text = "Profile Specific";
            // 
            // gbxLaunchOrder
            // 
            this.gbxLaunchOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxLaunchOrder.Location = new System.Drawing.Point(140, 3);
            this.gbxLaunchOrder.Name = "gbxLaunchOrder";
            this.gbxLaunchOrder.Size = new System.Drawing.Size(137, 263);
            this.gbxLaunchOrder.TabIndex = 2;
            this.gbxLaunchOrder.TabStop = false;
            this.gbxLaunchOrder.Text = "Launch Order";
            // 
            // gbxUniversal
            // 
            this.gbxUniversal.Controls.Add(this.cbxGraphicsQuality);
            this.gbxUniversal.Controls.Add(this.cbxResolution);
            this.gbxUniversal.Controls.Add(this.chkVSync);
            this.gbxUniversal.Controls.Add(this.chkAntiAliasing);
            this.gbxUniversal.Controls.Add(this.chkWindowedMode);
            this.gbxUniversal.Controls.Add(this.lblVSync);
            this.gbxUniversal.Controls.Add(this.lblAntiAliasing);
            this.gbxUniversal.Controls.Add(this.lblGraphicsQuality);
            this.gbxUniversal.Controls.Add(this.lblResolution);
            this.gbxUniversal.Controls.Add(this.lblWindowedMode);
            this.gbxUniversal.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxUniversal.Location = new System.Drawing.Point(3, 3);
            this.gbxUniversal.Name = "gbxUniversal";
            this.gbxUniversal.Size = new System.Drawing.Size(137, 263);
            this.gbxUniversal.TabIndex = 0;
            this.gbxUniversal.TabStop = false;
            this.gbxUniversal.Text = "Universal";
            // 
            // chkVSync
            // 
            this.chkVSync.AutoSize = true;
            this.chkVSync.Location = new System.Drawing.Point(116, 108);
            this.chkVSync.Name = "chkVSync";
            this.chkVSync.Size = new System.Drawing.Size(15, 14);
            this.chkVSync.TabIndex = 9;
            this.chkVSync.UseVisualStyleBackColor = true;
            // 
            // chkAntiAliasing
            // 
            this.chkAntiAliasing.AutoSize = true;
            this.chkAntiAliasing.Location = new System.Drawing.Point(116, 86);
            this.chkAntiAliasing.Name = "chkAntiAliasing";
            this.chkAntiAliasing.Size = new System.Drawing.Size(15, 14);
            this.chkAntiAliasing.TabIndex = 8;
            this.chkAntiAliasing.UseVisualStyleBackColor = true;
            // 
            // chkWindowedMode
            // 
            this.chkWindowedMode.AutoSize = true;
            this.chkWindowedMode.Location = new System.Drawing.Point(116, 20);
            this.chkWindowedMode.Name = "chkWindowedMode";
            this.chkWindowedMode.Size = new System.Drawing.Size(15, 14);
            this.chkWindowedMode.TabIndex = 5;
            this.chkWindowedMode.UseVisualStyleBackColor = true;
            // 
            // lblVSync
            // 
            this.lblVSync.AutoSize = true;
            this.lblVSync.Location = new System.Drawing.Point(6, 108);
            this.lblVSync.Name = "lblVSync";
            this.lblVSync.Size = new System.Drawing.Size(38, 13);
            this.lblVSync.TabIndex = 4;
            this.lblVSync.Text = "VSync";
            // 
            // lblAntiAliasing
            // 
            this.lblAntiAliasing.AutoSize = true;
            this.lblAntiAliasing.Location = new System.Drawing.Point(6, 86);
            this.lblAntiAliasing.Name = "lblAntiAliasing";
            this.lblAntiAliasing.Size = new System.Drawing.Size(64, 13);
            this.lblAntiAliasing.TabIndex = 3;
            this.lblAntiAliasing.Text = "Anti Aliasing";
            // 
            // lblGraphicsQuality
            // 
            this.lblGraphicsQuality.AutoSize = true;
            this.lblGraphicsQuality.Location = new System.Drawing.Point(6, 64);
            this.lblGraphicsQuality.Name = "lblGraphicsQuality";
            this.lblGraphicsQuality.Size = new System.Drawing.Size(39, 13);
            this.lblGraphicsQuality.TabIndex = 2;
            this.lblGraphicsQuality.Text = "Quality";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(6, 42);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(57, 13);
            this.lblResolution.TabIndex = 1;
            this.lblResolution.Text = "Resolution";
            // 
            // lblWindowedMode
            // 
            this.lblWindowedMode.AutoSize = true;
            this.lblWindowedMode.Location = new System.Drawing.Point(6, 20);
            this.lblWindowedMode.Name = "lblWindowedMode";
            this.lblWindowedMode.Size = new System.Drawing.Size(88, 13);
            this.lblWindowedMode.TabIndex = 0;
            this.lblWindowedMode.Text = "Windowed Mode";
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
            // cbxResolution
            // 
            this.cbxResolution.FormattingEnabled = true;
            this.cbxResolution.Location = new System.Drawing.Point(70, 37);
            this.cbxResolution.Name = "cbxResolution";
            this.cbxResolution.Size = new System.Drawing.Size(61, 21);
            this.cbxResolution.TabIndex = 10;
            // 
            // cbxGraphicsQuality
            // 
            this.cbxGraphicsQuality.FormattingEnabled = true;
            this.cbxGraphicsQuality.Location = new System.Drawing.Point(70, 62);
            this.cbxGraphicsQuality.Name = "cbxGraphicsQuality";
            this.cbxGraphicsQuality.Size = new System.Drawing.Size(61, 21);
            this.cbxGraphicsQuality.TabIndex = 11;
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
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tctMain.ResumeLayout(false);
            this.tabProfiles.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.gbxUniversal.ResumeLayout(false);
            this.gbxUniversal.PerformLayout();
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
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Label lblWindowedMode;
        private System.Windows.Forms.Label lblGraphicsQuality;
        private System.Windows.Forms.Label lblAntiAliasing;
        private System.Windows.Forms.Label lblVSync;
        private System.Windows.Forms.CheckBox chkVSync;
        private System.Windows.Forms.CheckBox chkAntiAliasing;
        private System.Windows.Forms.CheckBox chkWindowedMode;
        private System.Windows.Forms.ComboBox cbxResolution;
        private System.Windows.Forms.ComboBox cbxGraphicsQuality;
    }
}

