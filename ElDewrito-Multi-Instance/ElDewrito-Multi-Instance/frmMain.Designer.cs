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
            this.chkConsoleMode = new System.Windows.Forms.CheckBox();
            this.lblConsoleMode = new System.Windows.Forms.Label();
            this.chkVSync = new System.Windows.Forms.CheckBox();
            this.chkFullscreen = new System.Windows.Forms.CheckBox();
            this.lblVSync = new System.Windows.Forms.Label();
            this.lblNumberOfInstances = new System.Windows.Forms.Label();
            this.lblFullscreen = new System.Windows.Forms.Label();
            this.gbxProfileSpecificSettings = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblHResolution = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxGraphicsQuality = new System.Windows.Forms.ComboBox();
            this.lblGraphicsQuality = new System.Windows.Forms.Label();
            this.lblVResolution = new System.Windows.Forms.Label();
            this.gbxLaunchOrder = new System.Windows.Forms.GroupBox();
            this.lsvLaunchOrder = new System.Windows.Forms.ListView();
            this.btnMoveInstanceUp = new System.Windows.Forms.Button();
            this.btnMoveInstanceDown = new System.Windows.Forms.Button();
            this.gbxProfiles = new System.Windows.Forms.GroupBox();
            this.clbProfiles = new System.Windows.Forms.CheckedListBox();
            this.btnReloadProfiles = new System.Windows.Forms.Button();
            this.btnAddProfile = new System.Windows.Forms.Button();
            this.btnRemoveProfile = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.chkAntiAliasing = new System.Windows.Forms.CheckBox();
            this.lblAntiAliasing = new System.Windows.Forms.Label();
            this.cbxNumberOfInstances = new System.Windows.Forms.ComboBox();
            this.chkKeyboardControlsP1 = new System.Windows.Forms.CheckBox();
            this.lblKeyboardControlsP1 = new System.Windows.Forms.Label();
            this.gbxUniversalSettings.SuspendLayout();
            this.gbxProfileSpecificSettings.SuspendLayout();
            this.gbxLaunchOrder.SuspendLayout();
            this.gbxProfiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUniversalSettings
            // 
            this.gbxUniversalSettings.Controls.Add(this.chkKeyboardControlsP1);
            this.gbxUniversalSettings.Controls.Add(this.lblKeyboardControlsP1);
            this.gbxUniversalSettings.Controls.Add(this.cbxNumberOfInstances);
            this.gbxUniversalSettings.Controls.Add(this.chkAntiAliasing);
            this.gbxUniversalSettings.Controls.Add(this.lblAntiAliasing);
            this.gbxUniversalSettings.Controls.Add(this.chkConsoleMode);
            this.gbxUniversalSettings.Controls.Add(this.lblConsoleMode);
            this.gbxUniversalSettings.Controls.Add(this.chkVSync);
            this.gbxUniversalSettings.Controls.Add(this.chkFullscreen);
            this.gbxUniversalSettings.Controls.Add(this.lblVSync);
            this.gbxUniversalSettings.Controls.Add(this.lblNumberOfInstances);
            this.gbxUniversalSettings.Controls.Add(this.lblFullscreen);
            this.gbxUniversalSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxUniversalSettings.Location = new System.Drawing.Point(141, 0);
            this.gbxUniversalSettings.Name = "gbxUniversalSettings";
            this.gbxUniversalSettings.Size = new System.Drawing.Size(142, 159);
            this.gbxUniversalSettings.TabIndex = 19;
            this.gbxUniversalSettings.TabStop = false;
            this.gbxUniversalSettings.Text = "Universal Settings";
            // 
            // chkConsoleMode
            // 
            this.chkConsoleMode.AutoSize = true;
            this.chkConsoleMode.Location = new System.Drawing.Point(116, 67);
            this.chkConsoleMode.Name = "chkConsoleMode";
            this.chkConsoleMode.Size = new System.Drawing.Size(15, 14);
            this.chkConsoleMode.TabIndex = 11;
            this.chkConsoleMode.UseVisualStyleBackColor = true;
            // 
            // lblConsoleMode
            // 
            this.lblConsoleMode.AutoSize = true;
            this.lblConsoleMode.Location = new System.Drawing.Point(6, 67);
            this.lblConsoleMode.Name = "lblConsoleMode";
            this.lblConsoleMode.Size = new System.Drawing.Size(74, 13);
            this.lblConsoleMode.TabIndex = 10;
            this.lblConsoleMode.Text = "Console mode";
            // 
            // chkVSync
            // 
            this.chkVSync.AutoSize = true;
            this.chkVSync.Location = new System.Drawing.Point(116, 90);
            this.chkVSync.Name = "chkVSync";
            this.chkVSync.Size = new System.Drawing.Size(15, 14);
            this.chkVSync.TabIndex = 9;
            this.chkVSync.UseVisualStyleBackColor = true;
            // 
            // chkFullscreen
            // 
            this.chkFullscreen.AutoSize = true;
            this.chkFullscreen.Location = new System.Drawing.Point(116, 45);
            this.chkFullscreen.Name = "chkFullscreen";
            this.chkFullscreen.Size = new System.Drawing.Size(15, 14);
            this.chkFullscreen.TabIndex = 5;
            this.chkFullscreen.UseVisualStyleBackColor = true;
            // 
            // lblVSync
            // 
            this.lblVSync.AutoSize = true;
            this.lblVSync.Location = new System.Drawing.Point(6, 90);
            this.lblVSync.Name = "lblVSync";
            this.lblVSync.Size = new System.Drawing.Size(38, 13);
            this.lblVSync.TabIndex = 4;
            this.lblVSync.Text = "VSync";
            // 
            // lblNumberOfInstances
            // 
            this.lblNumberOfInstances.AutoSize = true;
            this.lblNumberOfInstances.Location = new System.Drawing.Point(6, 24);
            this.lblNumberOfInstances.Name = "lblNumberOfInstances";
            this.lblNumberOfInstances.Size = new System.Drawing.Size(75, 13);
            this.lblNumberOfInstances.TabIndex = 3;
            this.lblNumberOfInstances.Text = "# of Instances";
            // 
            // lblFullscreen
            // 
            this.lblFullscreen.AutoSize = true;
            this.lblFullscreen.Location = new System.Drawing.Point(6, 45);
            this.lblFullscreen.Name = "lblFullscreen";
            this.lblFullscreen.Size = new System.Drawing.Size(55, 13);
            this.lblFullscreen.TabIndex = 0;
            this.lblFullscreen.Text = "Fullscreen";
            // 
            // gbxProfileSpecificSettings
            // 
            this.gbxProfileSpecificSettings.Controls.Add(this.textBox2);
            this.gbxProfileSpecificSettings.Controls.Add(this.lblHResolution);
            this.gbxProfileSpecificSettings.Controls.Add(this.textBox1);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 20);
            this.textBox2.TabIndex = 17;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 15;
            // 
            // cbxGraphicsQuality
            // 
            this.cbxGraphicsQuality.FormattingEnabled = true;
            this.cbxGraphicsQuality.Items.AddRange(new object[] {
            "low",
            "medium",
            "high"});
            this.cbxGraphicsQuality.Location = new System.Drawing.Point(80, 67);
            this.cbxGraphicsQuality.Name = "cbxGraphicsQuality";
            this.cbxGraphicsQuality.Size = new System.Drawing.Size(51, 21);
            this.cbxGraphicsQuality.TabIndex = 14;
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
            this.gbxLaunchOrder.Controls.Add(this.lsvLaunchOrder);
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
            // lsvLaunchOrder
            // 
            this.lsvLaunchOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvLaunchOrder.Location = new System.Drawing.Point(3, 23);
            this.lsvLaunchOrder.Name = "lsvLaunchOrder";
            this.lsvLaunchOrder.Size = new System.Drawing.Size(135, 222);
            this.lsvLaunchOrder.TabIndex = 20;
            this.lsvLaunchOrder.UseCompatibleStateImageBehavior = false;
            // 
            // btnMoveInstanceUp
            // 
            this.btnMoveInstanceUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMoveInstanceUp.Location = new System.Drawing.Point(3, 245);
            this.btnMoveInstanceUp.Name = "btnMoveInstanceUp";
            this.btnMoveInstanceUp.Size = new System.Drawing.Size(135, 23);
            this.btnMoveInstanceUp.TabIndex = 19;
            this.btnMoveInstanceUp.Text = "Move up";
            this.btnMoveInstanceUp.UseVisualStyleBackColor = true;
            // 
            // btnMoveInstanceDown
            // 
            this.btnMoveInstanceDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMoveInstanceDown.Location = new System.Drawing.Point(3, 268);
            this.btnMoveInstanceDown.Name = "btnMoveInstanceDown";
            this.btnMoveInstanceDown.Size = new System.Drawing.Size(135, 23);
            this.btnMoveInstanceDown.TabIndex = 17;
            this.btnMoveInstanceDown.Text = "Move down";
            this.btnMoveInstanceDown.UseVisualStyleBackColor = true;
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
            this.clbProfiles.TabIndex = 15;
            // 
            // btnReloadProfiles
            // 
            this.btnReloadProfiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReloadProfiles.Location = new System.Drawing.Point(3, 222);
            this.btnReloadProfiles.Name = "btnReloadProfiles";
            this.btnReloadProfiles.Size = new System.Drawing.Size(135, 23);
            this.btnReloadProfiles.TabIndex = 14;
            this.btnReloadProfiles.Text = "Reload profiles";
            this.btnReloadProfiles.UseVisualStyleBackColor = true;
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddProfile.Location = new System.Drawing.Point(3, 245);
            this.btnAddProfile.Name = "btnAddProfile";
            this.btnAddProfile.Size = new System.Drawing.Size(135, 23);
            this.btnAddProfile.TabIndex = 13;
            this.btnAddProfile.Text = "Add profile";
            this.btnAddProfile.UseVisualStyleBackColor = true;
            // 
            // btnRemoveProfile
            // 
            this.btnRemoveProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRemoveProfile.Location = new System.Drawing.Point(3, 268);
            this.btnRemoveProfile.Name = "btnRemoveProfile";
            this.btnRemoveProfile.Size = new System.Drawing.Size(135, 23);
            this.btnRemoveProfile.TabIndex = 12;
            this.btnRemoveProfile.Text = "Remove selected profile";
            this.btnRemoveProfile.UseVisualStyleBackColor = true;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(144, 164);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(135, 23);
            this.btnLaunch.TabIndex = 20;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // chkAntiAliasing
            // 
            this.chkAntiAliasing.AutoSize = true;
            this.chkAntiAliasing.Location = new System.Drawing.Point(116, 112);
            this.chkAntiAliasing.Name = "chkAntiAliasing";
            this.chkAntiAliasing.Size = new System.Drawing.Size(15, 14);
            this.chkAntiAliasing.TabIndex = 13;
            this.chkAntiAliasing.UseVisualStyleBackColor = true;
            // 
            // lblAntiAliasing
            // 
            this.lblAntiAliasing.AutoSize = true;
            this.lblAntiAliasing.Location = new System.Drawing.Point(6, 112);
            this.lblAntiAliasing.Name = "lblAntiAliasing";
            this.lblAntiAliasing.Size = new System.Drawing.Size(63, 13);
            this.lblAntiAliasing.TabIndex = 12;
            this.lblAntiAliasing.Text = "Anti aliasing";
            // 
            // cbxNumberOfInstances
            // 
            this.cbxNumberOfInstances.FormattingEnabled = true;
            this.cbxNumberOfInstances.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbxNumberOfInstances.Location = new System.Drawing.Point(88, 20);
            this.cbxNumberOfInstances.Name = "cbxNumberOfInstances";
            this.cbxNumberOfInstances.Size = new System.Drawing.Size(43, 21);
            this.cbxNumberOfInstances.TabIndex = 14;
            // 
            // chkKeyboardControlsP1
            // 
            this.chkKeyboardControlsP1.AutoSize = true;
            this.chkKeyboardControlsP1.Location = new System.Drawing.Point(116, 134);
            this.chkKeyboardControlsP1.Name = "chkKeyboardControlsP1";
            this.chkKeyboardControlsP1.Size = new System.Drawing.Size(15, 14);
            this.chkKeyboardControlsP1.TabIndex = 16;
            this.chkKeyboardControlsP1.UseVisualStyleBackColor = true;
            // 
            // lblKeyboardControlsP1
            // 
            this.lblKeyboardControlsP1.AutoSize = true;
            this.lblKeyboardControlsP1.Location = new System.Drawing.Point(6, 134);
            this.lblKeyboardControlsP1.Name = "lblKeyboardControlsP1";
            this.lblKeyboardControlsP1.Size = new System.Drawing.Size(108, 13);
            this.lblKeyboardControlsP1.TabIndex = 15;
            this.lblKeyboardControlsP1.Text = "Keyboard controls P1";
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
        private System.Windows.Forms.Label lblNumberOfInstances;
        private System.Windows.Forms.Label lblFullscreen;
        private System.Windows.Forms.GroupBox gbxProfileSpecificSettings;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblHResolution;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxGraphicsQuality;
        private System.Windows.Forms.Label lblGraphicsQuality;
        private System.Windows.Forms.Label lblVResolution;
        private System.Windows.Forms.GroupBox gbxLaunchOrder;
        private System.Windows.Forms.GroupBox gbxProfiles;
        private System.Windows.Forms.CheckedListBox clbProfiles;
        private System.Windows.Forms.Button btnReloadProfiles;
        private System.Windows.Forms.Button btnAddProfile;
        private System.Windows.Forms.Button btnRemoveProfile;
        private System.Windows.Forms.ListView lsvLaunchOrder;
        private System.Windows.Forms.Button btnMoveInstanceUp;
        private System.Windows.Forms.Button btnMoveInstanceDown;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.CheckBox chkConsoleMode;
        private System.Windows.Forms.Label lblConsoleMode;
        private System.Windows.Forms.CheckBox chkAntiAliasing;
        private System.Windows.Forms.Label lblAntiAliasing;
        private System.Windows.Forms.ComboBox cbxNumberOfInstances;
        private System.Windows.Forms.CheckBox chkKeyboardControlsP1;
        private System.Windows.Forms.Label lblKeyboardControlsP1;
    }
}

