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
            this.gbxUniversalSettings = new System.Windows.Forms.GroupBox();
            this.chkKeyboardControlsP1 = new System.Windows.Forms.CheckBox();
            this.lblKeyboardControlsP1 = new System.Windows.Forms.Label();
            this.chkAntiAliasing = new System.Windows.Forms.CheckBox();
            this.lblAntiAliasing = new System.Windows.Forms.Label();
            this.chkConsoleMode = new System.Windows.Forms.CheckBox();
            this.lblConsoleMode = new System.Windows.Forms.Label();
            this.chkVSync = new System.Windows.Forms.CheckBox();
            this.chkFullscreen = new System.Windows.Forms.CheckBox();
            this.lblVSync = new System.Windows.Forms.Label();
            this.lblFullscreen = new System.Windows.Forms.Label();
            this.gbxProfileSpecificSettings = new System.Windows.Forms.GroupBox();
            this.txtHResolution = new System.Windows.Forms.TextBox();
            this.lblHResolution = new System.Windows.Forms.Label();
            this.txtVResolution = new System.Windows.Forms.TextBox();
            this.cbxGraphicsQuality = new System.Windows.Forms.ComboBox();
            this.lblGraphicsQuality = new System.Windows.Forms.Label();
            this.lblVResolution = new System.Windows.Forms.Label();
            this.gbxLaunchOrder = new System.Windows.Forms.GroupBox();
            this.lsbLaunchOrder = new System.Windows.Forms.ListBox();
            this.btnMoveInstanceUp = new System.Windows.Forms.Button();
            this.btnMoveInstanceDown = new System.Windows.Forms.Button();
            this.gbxProfiles = new System.Windows.Forms.GroupBox();
            this.clbProfiles = new System.Windows.Forms.CheckedListBox();
            this.btnReloadProfiles = new System.Windows.Forms.Button();
            this.btnAddProfile = new System.Windows.Forms.Button();
            this.btnRemoveProfile = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.chkConnectAllToServer = new System.Windows.Forms.CheckBox();
            this.lblConnectAllToServer = new System.Windows.Forms.Label();
            this.gbxUniversalSettings.SuspendLayout();
            this.gbxProfileSpecificSettings.SuspendLayout();
            this.gbxLaunchOrder.SuspendLayout();
            this.gbxProfiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUniversalSettings
            // 
            this.gbxUniversalSettings.Controls.Add(this.chkConnectAllToServer);
            this.gbxUniversalSettings.Controls.Add(this.lblConnectAllToServer);
            this.gbxUniversalSettings.Controls.Add(this.chkKeyboardControlsP1);
            this.gbxUniversalSettings.Controls.Add(this.lblKeyboardControlsP1);
            this.gbxUniversalSettings.Controls.Add(this.chkAntiAliasing);
            this.gbxUniversalSettings.Controls.Add(this.lblAntiAliasing);
            this.gbxUniversalSettings.Controls.Add(this.chkConsoleMode);
            this.gbxUniversalSettings.Controls.Add(this.lblConsoleMode);
            this.gbxUniversalSettings.Controls.Add(this.chkVSync);
            this.gbxUniversalSettings.Controls.Add(this.chkFullscreen);
            this.gbxUniversalSettings.Controls.Add(this.lblVSync);
            this.gbxUniversalSettings.Controls.Add(this.lblFullscreen);
            this.gbxUniversalSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxUniversalSettings.Location = new System.Drawing.Point(141, 0);
            this.gbxUniversalSettings.Name = "gbxUniversalSettings";
            this.gbxUniversalSettings.Size = new System.Drawing.Size(142, 159);
            this.gbxUniversalSettings.TabIndex = 19;
            this.gbxUniversalSettings.TabStop = false;
            this.gbxUniversalSettings.Text = "Universal Settings";
            // 
            // chkKeyboardControlsP1
            // 
            this.chkKeyboardControlsP1.AutoSize = true;
            this.chkKeyboardControlsP1.Location = new System.Drawing.Point(116, 112);
            this.chkKeyboardControlsP1.Name = "chkKeyboardControlsP1";
            this.chkKeyboardControlsP1.Size = new System.Drawing.Size(15, 14);
            this.chkKeyboardControlsP1.TabIndex = 9;
            this.chkKeyboardControlsP1.UseVisualStyleBackColor = true;
            this.chkKeyboardControlsP1.CheckedChanged += new System.EventHandler(this.chkKeyboardControlsP1_CheckedChanged);
            // 
            // lblKeyboardControlsP1
            // 
            this.lblKeyboardControlsP1.AutoSize = true;
            this.lblKeyboardControlsP1.Location = new System.Drawing.Point(6, 112);
            this.lblKeyboardControlsP1.Name = "lblKeyboardControlsP1";
            this.lblKeyboardControlsP1.Size = new System.Drawing.Size(95, 13);
            this.lblKeyboardControlsP1.TabIndex = 0;
            this.lblKeyboardControlsP1.Text = "Kb / m controls P1";
            this.lblKeyboardControlsP1.Click += new System.EventHandler(this.lblKeyboardControlsP1_Click);
            // 
            // chkAntiAliasing
            // 
            this.chkAntiAliasing.AutoSize = true;
            this.chkAntiAliasing.Location = new System.Drawing.Point(116, 90);
            this.chkAntiAliasing.Name = "chkAntiAliasing";
            this.chkAntiAliasing.Size = new System.Drawing.Size(15, 14);
            this.chkAntiAliasing.TabIndex = 8;
            this.chkAntiAliasing.UseVisualStyleBackColor = true;
            this.chkAntiAliasing.CheckedChanged += new System.EventHandler(this.chkAntiAliasing_CheckedChanged);
            // 
            // lblAntiAliasing
            // 
            this.lblAntiAliasing.AutoSize = true;
            this.lblAntiAliasing.Location = new System.Drawing.Point(6, 90);
            this.lblAntiAliasing.Name = "lblAntiAliasing";
            this.lblAntiAliasing.Size = new System.Drawing.Size(63, 13);
            this.lblAntiAliasing.TabIndex = 0;
            this.lblAntiAliasing.Text = "Anti aliasing";
            this.lblAntiAliasing.Click += new System.EventHandler(this.lblAntiAliasing_Click);
            // 
            // chkConsoleMode
            // 
            this.chkConsoleMode.AutoSize = true;
            this.chkConsoleMode.Location = new System.Drawing.Point(116, 45);
            this.chkConsoleMode.Name = "chkConsoleMode";
            this.chkConsoleMode.Size = new System.Drawing.Size(15, 14);
            this.chkConsoleMode.TabIndex = 6;
            this.chkConsoleMode.UseVisualStyleBackColor = true;
            this.chkConsoleMode.CheckedChanged += new System.EventHandler(this.chkConsoleMode_CheckedChanged);
            // 
            // lblConsoleMode
            // 
            this.lblConsoleMode.AutoSize = true;
            this.lblConsoleMode.Location = new System.Drawing.Point(6, 45);
            this.lblConsoleMode.Name = "lblConsoleMode";
            this.lblConsoleMode.Size = new System.Drawing.Size(74, 13);
            this.lblConsoleMode.TabIndex = 0;
            this.lblConsoleMode.Text = "Console mode";
            this.lblConsoleMode.Click += new System.EventHandler(this.lblConsoleMode_Click);
            // 
            // chkVSync
            // 
            this.chkVSync.AutoSize = true;
            this.chkVSync.Location = new System.Drawing.Point(116, 68);
            this.chkVSync.Name = "chkVSync";
            this.chkVSync.Size = new System.Drawing.Size(15, 14);
            this.chkVSync.TabIndex = 7;
            this.chkVSync.UseVisualStyleBackColor = true;
            this.chkVSync.CheckedChanged += new System.EventHandler(this.chkVSync_CheckedChanged);
            // 
            // chkFullscreen
            // 
            this.chkFullscreen.AutoSize = true;
            this.chkFullscreen.Location = new System.Drawing.Point(116, 23);
            this.chkFullscreen.Name = "chkFullscreen";
            this.chkFullscreen.Size = new System.Drawing.Size(15, 14);
            this.chkFullscreen.TabIndex = 5;
            this.chkFullscreen.UseVisualStyleBackColor = true;
            this.chkFullscreen.CheckedChanged += new System.EventHandler(this.chkFullscreen_CheckedChanged);
            // 
            // lblVSync
            // 
            this.lblVSync.AutoSize = true;
            this.lblVSync.Location = new System.Drawing.Point(6, 68);
            this.lblVSync.Name = "lblVSync";
            this.lblVSync.Size = new System.Drawing.Size(38, 13);
            this.lblVSync.TabIndex = 0;
            this.lblVSync.Text = "VSync";
            this.lblVSync.Click += new System.EventHandler(this.lblVSync_Click);
            // 
            // lblFullscreen
            // 
            this.lblFullscreen.AutoSize = true;
            this.lblFullscreen.Location = new System.Drawing.Point(6, 23);
            this.lblFullscreen.Name = "lblFullscreen";
            this.lblFullscreen.Size = new System.Drawing.Size(55, 13);
            this.lblFullscreen.TabIndex = 0;
            this.lblFullscreen.Text = "Fullscreen";
            this.lblFullscreen.Click += new System.EventHandler(this.lblFullscreen_Click);
            // 
            // gbxProfileSpecificSettings
            // 
            this.gbxProfileSpecificSettings.Controls.Add(this.txtHResolution);
            this.gbxProfileSpecificSettings.Controls.Add(this.lblHResolution);
            this.gbxProfileSpecificSettings.Controls.Add(this.txtVResolution);
            this.gbxProfileSpecificSettings.Controls.Add(this.cbxGraphicsQuality);
            this.gbxProfileSpecificSettings.Controls.Add(this.lblGraphicsQuality);
            this.gbxProfileSpecificSettings.Controls.Add(this.lblVResolution);
            this.gbxProfileSpecificSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxProfileSpecificSettings.Location = new System.Drawing.Point(141, 193);
            this.gbxProfileSpecificSettings.Name = "gbxProfileSpecificSettings";
            this.gbxProfileSpecificSettings.Size = new System.Drawing.Size(142, 101);
            this.gbxProfileSpecificSettings.TabIndex = 18;
            this.gbxProfileSpecificSettings.TabStop = false;
            this.gbxProfileSpecificSettings.Text = "Profile Specific Settings";
            // 
            // txtHResolution
            // 
            this.txtHResolution.Location = new System.Drawing.Point(80, 17);
            this.txtHResolution.Name = "txtHResolution";
            this.txtHResolution.Size = new System.Drawing.Size(51, 20);
            this.txtHResolution.TabIndex = 10;
            // 
            // lblHResolution
            // 
            this.lblHResolution.AutoSize = true;
            this.lblHResolution.Location = new System.Drawing.Point(6, 24);
            this.lblHResolution.Name = "lblHResolution";
            this.lblHResolution.Size = new System.Drawing.Size(68, 13);
            this.lblHResolution.TabIndex = 16;
            this.lblHResolution.Text = "H Resolution";
            // 
            // txtVResolution
            // 
            this.txtVResolution.Location = new System.Drawing.Point(80, 42);
            this.txtVResolution.Name = "txtVResolution";
            this.txtVResolution.Size = new System.Drawing.Size(51, 20);
            this.txtVResolution.TabIndex = 11;
            // 
            // cbxGraphicsQuality
            // 
            this.cbxGraphicsQuality.FormattingEnabled = true;
            this.cbxGraphicsQuality.ItemHeight = 13;
            this.cbxGraphicsQuality.Items.AddRange(new object[] {
            "low",
            "medium",
            "high"});
            this.cbxGraphicsQuality.Location = new System.Drawing.Point(80, 67);
            this.cbxGraphicsQuality.Name = "cbxGraphicsQuality";
            this.cbxGraphicsQuality.Size = new System.Drawing.Size(51, 21);
            this.cbxGraphicsQuality.TabIndex = 12;
            // 
            // lblGraphicsQuality
            // 
            this.lblGraphicsQuality.AutoSize = true;
            this.lblGraphicsQuality.Location = new System.Drawing.Point(6, 71);
            this.lblGraphicsQuality.Name = "lblGraphicsQuality";
            this.lblGraphicsQuality.Size = new System.Drawing.Size(39, 13);
            this.lblGraphicsQuality.TabIndex = 13;
            this.lblGraphicsQuality.Text = "Quality";
            // 
            // lblVResolution
            // 
            this.lblVResolution.AutoSize = true;
            this.lblVResolution.Location = new System.Drawing.Point(6, 49);
            this.lblVResolution.Name = "lblVResolution";
            this.lblVResolution.Size = new System.Drawing.Size(67, 13);
            this.lblVResolution.TabIndex = 11;
            this.lblVResolution.Text = "V Resolution";
            // 
            // gbxLaunchOrder
            // 
            this.gbxLaunchOrder.Controls.Add(this.lsbLaunchOrder);
            this.gbxLaunchOrder.Controls.Add(this.btnMoveInstanceUp);
            this.gbxLaunchOrder.Controls.Add(this.btnMoveInstanceDown);
            this.gbxLaunchOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbxLaunchOrder.Location = new System.Drawing.Point(283, 0);
            this.gbxLaunchOrder.Name = "gbxLaunchOrder";
            this.gbxLaunchOrder.Size = new System.Drawing.Size(141, 294);
            this.gbxLaunchOrder.TabIndex = 17;
            this.gbxLaunchOrder.TabStop = false;
            this.gbxLaunchOrder.Text = "Launch Order";
            // 
            // lsbLaunchOrder
            // 
            this.lsbLaunchOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsbLaunchOrder.FormattingEnabled = true;
            this.lsbLaunchOrder.Location = new System.Drawing.Point(3, 20);
            this.lsbLaunchOrder.Name = "lsbLaunchOrder";
            this.lsbLaunchOrder.Size = new System.Drawing.Size(135, 225);
            this.lsbLaunchOrder.TabIndex = 13;
            // 
            // btnMoveInstanceUp
            // 
            this.btnMoveInstanceUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMoveInstanceUp.Location = new System.Drawing.Point(3, 245);
            this.btnMoveInstanceUp.Name = "btnMoveInstanceUp";
            this.btnMoveInstanceUp.Size = new System.Drawing.Size(135, 23);
            this.btnMoveInstanceUp.TabIndex = 14;
            this.btnMoveInstanceUp.Text = "Move up";
            this.btnMoveInstanceUp.UseVisualStyleBackColor = true;
            this.btnMoveInstanceUp.Click += new System.EventHandler(this.btnMoveInstanceUp_Click);
            // 
            // btnMoveInstanceDown
            // 
            this.btnMoveInstanceDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMoveInstanceDown.Location = new System.Drawing.Point(3, 268);
            this.btnMoveInstanceDown.Name = "btnMoveInstanceDown";
            this.btnMoveInstanceDown.Size = new System.Drawing.Size(135, 23);
            this.btnMoveInstanceDown.TabIndex = 15;
            this.btnMoveInstanceDown.Text = "Move down";
            this.btnMoveInstanceDown.UseVisualStyleBackColor = true;
            this.btnMoveInstanceDown.Click += new System.EventHandler(this.btnMoveInstanceDown_Click);
            // 
            // gbxProfiles
            // 
            this.gbxProfiles.Controls.Add(this.clbProfiles);
            this.gbxProfiles.Controls.Add(this.btnReloadProfiles);
            this.gbxProfiles.Controls.Add(this.btnAddProfile);
            this.gbxProfiles.Controls.Add(this.btnRemoveProfile);
            this.gbxProfiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxProfiles.Location = new System.Drawing.Point(0, 0);
            this.gbxProfiles.Name = "gbxProfiles";
            this.gbxProfiles.Size = new System.Drawing.Size(141, 294);
            this.gbxProfiles.TabIndex = 16;
            this.gbxProfiles.TabStop = false;
            this.gbxProfiles.Text = "Profiles";
            // 
            // clbProfiles
            // 
            this.clbProfiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clbProfiles.FormattingEnabled = true;
            this.clbProfiles.Location = new System.Drawing.Point(3, 23);
            this.clbProfiles.Name = "clbProfiles";
            this.clbProfiles.Size = new System.Drawing.Size(135, 199);
            this.clbProfiles.TabIndex = 0;
            this.clbProfiles.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbProfiles_ItemCheck);
            this.clbProfiles.SelectedIndexChanged += new System.EventHandler(this.clbProfiles_SelectedIndexChanged);
            // 
            // btnReloadProfiles
            // 
            this.btnReloadProfiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReloadProfiles.Location = new System.Drawing.Point(3, 222);
            this.btnReloadProfiles.Name = "btnReloadProfiles";
            this.btnReloadProfiles.Size = new System.Drawing.Size(135, 23);
            this.btnReloadProfiles.TabIndex = 1;
            this.btnReloadProfiles.Text = "Reload profiles";
            this.btnReloadProfiles.UseVisualStyleBackColor = true;
            this.btnReloadProfiles.Click += new System.EventHandler(this.btnReloadProfiles_Click);
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddProfile.Location = new System.Drawing.Point(3, 245);
            this.btnAddProfile.Name = "btnAddProfile";
            this.btnAddProfile.Size = new System.Drawing.Size(135, 23);
            this.btnAddProfile.TabIndex = 2;
            this.btnAddProfile.Text = "Add profile";
            this.btnAddProfile.UseVisualStyleBackColor = true;
            this.btnAddProfile.Click += new System.EventHandler(this.btnAddProfile_Click);
            // 
            // btnRemoveProfile
            // 
            this.btnRemoveProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRemoveProfile.Location = new System.Drawing.Point(3, 268);
            this.btnRemoveProfile.Name = "btnRemoveProfile";
            this.btnRemoveProfile.Size = new System.Drawing.Size(135, 23);
            this.btnRemoveProfile.TabIndex = 3;
            this.btnRemoveProfile.Text = "Remove selected profile";
            this.btnRemoveProfile.UseVisualStyleBackColor = true;
            this.btnRemoveProfile.Click += new System.EventHandler(this.btnRemoveProfile_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(144, 164);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(135, 23);
            this.btnLaunch.TabIndex = 16;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // chkConnectAllToServer
            // 
            this.chkConnectAllToServer.AutoSize = true;
            this.chkConnectAllToServer.Enabled = false;
            this.chkConnectAllToServer.Location = new System.Drawing.Point(116, 134);
            this.chkConnectAllToServer.Name = "chkConnectAllToServer";
            this.chkConnectAllToServer.Size = new System.Drawing.Size(15, 14);
            this.chkConnectAllToServer.TabIndex = 11;
            this.chkConnectAllToServer.UseVisualStyleBackColor = true;
            this.chkConnectAllToServer.CheckedChanged += new System.EventHandler(this.chkConnectAllToServer_CheckedChanged);
            // 
            // lblConnectAllToServer
            // 
            this.lblConnectAllToServer.AutoSize = true;
            this.lblConnectAllToServer.Enabled = false;
            this.lblConnectAllToServer.Location = new System.Drawing.Point(6, 134);
            this.lblConnectAllToServer.Name = "lblConnectAllToServer";
            this.lblConnectAllToServer.Size = new System.Drawing.Size(104, 13);
            this.lblConnectAllToServer.TabIndex = 10;
            this.lblConnectAllToServer.Text = "Connect all to server";
            this.lblConnectAllToServer.Click += new System.EventHandler(this.lblConnectAllToServer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 294);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.gbxUniversalSettings);
            this.Controls.Add(this.gbxProfileSpecificSettings);
            this.Controls.Add(this.gbxLaunchOrder);
            this.Controls.Add(this.gbxProfiles);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 4320);
            this.MinimumSize = new System.Drawing.Size(440, 333);
            this.Name = "frmMain";
            this.Text = "ElDewrito Multi Instance";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.gbxUniversalSettings.ResumeLayout(false);
            this.gbxUniversalSettings.PerformLayout();
            this.gbxProfileSpecificSettings.ResumeLayout(false);
            this.gbxProfileSpecificSettings.PerformLayout();
            this.gbxLaunchOrder.ResumeLayout(false);
            this.gbxProfiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUniversalSettings;
        private System.Windows.Forms.CheckBox chkVSync;
        private System.Windows.Forms.CheckBox chkFullscreen;
        private System.Windows.Forms.Label lblVSync;
        private System.Windows.Forms.Label lblFullscreen;
        private System.Windows.Forms.GroupBox gbxProfileSpecificSettings;
        private System.Windows.Forms.TextBox txtHResolution;
        private System.Windows.Forms.Label lblHResolution;
        private System.Windows.Forms.TextBox txtVResolution;
        private System.Windows.Forms.ComboBox cbxGraphicsQuality;
        private System.Windows.Forms.Label lblGraphicsQuality;
        private System.Windows.Forms.Label lblVResolution;
        private System.Windows.Forms.GroupBox gbxLaunchOrder;
        private System.Windows.Forms.GroupBox gbxProfiles;
        private System.Windows.Forms.CheckedListBox clbProfiles;
        private System.Windows.Forms.Button btnReloadProfiles;
        private System.Windows.Forms.Button btnAddProfile;
        private System.Windows.Forms.Button btnRemoveProfile;
        private System.Windows.Forms.Button btnMoveInstanceUp;
        private System.Windows.Forms.Button btnMoveInstanceDown;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.CheckBox chkConsoleMode;
        private System.Windows.Forms.Label lblConsoleMode;
        private System.Windows.Forms.CheckBox chkAntiAliasing;
        private System.Windows.Forms.Label lblAntiAliasing;
        private System.Windows.Forms.CheckBox chkKeyboardControlsP1;
        private System.Windows.Forms.Label lblKeyboardControlsP1;
        private System.Windows.Forms.ListBox lsbLaunchOrder;
        private System.Windows.Forms.CheckBox chkConnectAllToServer;
        private System.Windows.Forms.Label lblConnectAllToServer;
    }
}

