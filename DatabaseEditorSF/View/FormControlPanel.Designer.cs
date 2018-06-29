namespace DatabaseEditorSF.Views {
	partial class FormControlPanel {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.checkBoxRestartWorld = new System.Windows.Forms.CheckBox();
            this.checkBoxHideWorld = new System.Windows.Forms.CheckBox();
            this.buttonWorldServer = new System.Windows.Forms.Button();
            this.checkBoxRestartAuth = new System.Windows.Forms.CheckBox();
            this.checkBoxHideAuth = new System.Windows.Forms.CheckBox();
            this.buttonAuthServer = new System.Windows.Forms.Button();
            this.textBoxPathServer = new System.Windows.Forms.TextBox();
            this.buttonPathDialog = new System.Windows.Forms.Button();
            this.timerCheckProcess = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonWorldConfig = new System.Windows.Forms.Button();
            this.buttonAuthConfig = new System.Windows.Forms.Button();
            this.pictureBoxWorld = new System.Windows.Forms.PictureBox();
            this.labelWorld = new System.Windows.Forms.Label();
            this.labelAuth = new System.Windows.Forms.Label();
            this.pictureBoxAuth = new System.Windows.Forms.PictureBox();
            this.textBoxLogging = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuth)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxRestartWorld
            // 
            this.checkBoxRestartWorld.AutoSize = true;
            this.checkBoxRestartWorld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.checkBoxRestartWorld.Location = new System.Drawing.Point(445, 77);
            this.checkBoxRestartWorld.Name = "checkBoxRestartWorld";
            this.checkBoxRestartWorld.Size = new System.Drawing.Size(60, 17);
            this.checkBoxRestartWorld.TabIndex = 3;
            this.checkBoxRestartWorld.Text = "Restart";
            this.checkBoxRestartWorld.UseVisualStyleBackColor = true;
            // 
            // checkBoxHideWorld
            // 
            this.checkBoxHideWorld.AutoSize = true;
            this.checkBoxHideWorld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.checkBoxHideWorld.Location = new System.Drawing.Point(381, 77);
            this.checkBoxHideWorld.Name = "checkBoxHideWorld";
            this.checkBoxHideWorld.Size = new System.Drawing.Size(48, 17);
            this.checkBoxHideWorld.TabIndex = 2;
            this.checkBoxHideWorld.Text = "Hide";
            this.checkBoxHideWorld.UseVisualStyleBackColor = true;
            // 
            // buttonWorldServer
            // 
            this.buttonWorldServer.BackgroundImage = global::DatabaseEditorSF.Properties.Resources.iconPlayButton;
            this.buttonWorldServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonWorldServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWorldServer.Location = new System.Drawing.Point(296, 69);
            this.buttonWorldServer.Name = "buttonWorldServer";
            this.buttonWorldServer.Size = new System.Drawing.Size(30, 30);
            this.buttonWorldServer.TabIndex = 0;
            this.buttonWorldServer.UseVisualStyleBackColor = true;
            this.buttonWorldServer.Click += new System.EventHandler(this.buttonServer_Click);
            // 
            // checkBoxRestartAuth
            // 
            this.checkBoxRestartAuth.AutoSize = true;
            this.checkBoxRestartAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.checkBoxRestartAuth.Location = new System.Drawing.Point(445, 41);
            this.checkBoxRestartAuth.Name = "checkBoxRestartAuth";
            this.checkBoxRestartAuth.Size = new System.Drawing.Size(60, 17);
            this.checkBoxRestartAuth.TabIndex = 3;
            this.checkBoxRestartAuth.Text = "Restart";
            this.checkBoxRestartAuth.UseVisualStyleBackColor = true;
            // 
            // checkBoxHideAuth
            // 
            this.checkBoxHideAuth.AutoSize = true;
            this.checkBoxHideAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.checkBoxHideAuth.Location = new System.Drawing.Point(381, 41);
            this.checkBoxHideAuth.Name = "checkBoxHideAuth";
            this.checkBoxHideAuth.Size = new System.Drawing.Size(48, 17);
            this.checkBoxHideAuth.TabIndex = 2;
            this.checkBoxHideAuth.Text = "Hide";
            this.checkBoxHideAuth.UseVisualStyleBackColor = true;
            // 
            // buttonAuthServer
            // 
            this.buttonAuthServer.BackgroundImage = global::DatabaseEditorSF.Properties.Resources.iconPlayButton;
            this.buttonAuthServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAuthServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAuthServer.Location = new System.Drawing.Point(296, 33);
            this.buttonAuthServer.Name = "buttonAuthServer";
            this.buttonAuthServer.Size = new System.Drawing.Size(30, 30);
            this.buttonAuthServer.TabIndex = 0;
            this.buttonAuthServer.UseVisualStyleBackColor = true;
            this.buttonAuthServer.Click += new System.EventHandler(this.buttonServer_Click);
            // 
            // textBoxPathServer
            // 
            this.textBoxPathServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.textBoxPathServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPathServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.textBoxPathServer.Location = new System.Drawing.Point(12, 308);
            this.textBoxPathServer.Multiline = true;
            this.textBoxPathServer.Name = "textBoxPathServer";
            this.textBoxPathServer.Size = new System.Drawing.Size(487, 27);
            this.textBoxPathServer.TabIndex = 2;
            // 
            // buttonPathDialog
            // 
            this.buttonPathDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.buttonPathDialog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPathDialog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.buttonPathDialog.Location = new System.Drawing.Point(505, 308);
            this.buttonPathDialog.Name = "buttonPathDialog";
            this.buttonPathDialog.Size = new System.Drawing.Size(28, 27);
            this.buttonPathDialog.TabIndex = 36;
            this.buttonPathDialog.UseVisualStyleBackColor = false;
            this.buttonPathDialog.Click += new System.EventHandler(this.buttonPathDialog_Click);
            // 
            // timerCheckProcess
            // 
            this.timerCheckProcess.Interval = 1000;
            this.timerCheckProcess.Tick += new System.EventHandler(this.timerCheckProcess_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonWorldConfig);
            this.groupBox2.Controls.Add(this.buttonAuthConfig);
            this.groupBox2.Controls.Add(this.checkBoxRestartWorld);
            this.groupBox2.Controls.Add(this.checkBoxRestartAuth);
            this.groupBox2.Controls.Add(this.checkBoxHideWorld);
            this.groupBox2.Controls.Add(this.pictureBoxWorld);
            this.groupBox2.Controls.Add(this.checkBoxHideAuth);
            this.groupBox2.Controls.Add(this.labelWorld);
            this.groupBox2.Controls.Add(this.labelAuth);
            this.groupBox2.Controls.Add(this.pictureBoxAuth);
            this.groupBox2.Controls.Add(this.buttonWorldServer);
            this.groupBox2.Controls.Add(this.buttonAuthServer);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 114);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servers";
            // 
            // buttonWorldConfig
            // 
            this.buttonWorldConfig.BackgroundImage = global::DatabaseEditorSF.Properties.Resources.iconConfiguration;
            this.buttonWorldConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonWorldConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWorldConfig.Location = new System.Drawing.Point(332, 69);
            this.buttonWorldConfig.Name = "buttonWorldConfig";
            this.buttonWorldConfig.Size = new System.Drawing.Size(30, 30);
            this.buttonWorldConfig.TabIndex = 5;
            this.buttonWorldConfig.UseVisualStyleBackColor = true;
            this.buttonWorldConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonAuthConfig
            // 
            this.buttonAuthConfig.BackgroundImage = global::DatabaseEditorSF.Properties.Resources.iconConfiguration;
            this.buttonAuthConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAuthConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAuthConfig.Location = new System.Drawing.Point(332, 33);
            this.buttonAuthConfig.Name = "buttonAuthConfig";
            this.buttonAuthConfig.Size = new System.Drawing.Size(30, 30);
            this.buttonAuthConfig.TabIndex = 4;
            this.buttonAuthConfig.UseVisualStyleBackColor = true;
            this.buttonAuthConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // pictureBoxWorld
            // 
            this.pictureBoxWorld.BackgroundImage = global::DatabaseEditorSF.Properties.Resources.iconDelete;
            this.pictureBoxWorld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWorld.Location = new System.Drawing.Point(23, 69);
            this.pictureBoxWorld.Name = "pictureBoxWorld";
            this.pictureBoxWorld.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxWorld.TabIndex = 3;
            this.pictureBoxWorld.TabStop = false;
            // 
            // labelWorld
            // 
            this.labelWorld.AutoSize = true;
            this.labelWorld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.labelWorld.Location = new System.Drawing.Point(59, 77);
            this.labelWorld.Name = "labelWorld";
            this.labelWorld.Size = new System.Drawing.Size(72, 13);
            this.labelWorld.TabIndex = 2;
            this.labelWorld.Text = "World Server:";
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.labelAuth.Location = new System.Drawing.Point(59, 41);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(66, 13);
            this.labelAuth.TabIndex = 1;
            this.labelAuth.Text = "Auth Server:";
            // 
            // pictureBoxAuth
            // 
            this.pictureBoxAuth.BackgroundImage = global::DatabaseEditorSF.Properties.Resources.iconDelete;
            this.pictureBoxAuth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAuth.Location = new System.Drawing.Point(23, 28);
            this.pictureBoxAuth.Name = "pictureBoxAuth";
            this.pictureBoxAuth.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAuth.TabIndex = 0;
            this.pictureBoxAuth.TabStop = false;
            // 
            // textBoxLogging
            // 
            this.textBoxLogging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.textBoxLogging.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogging.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.textBoxLogging.Location = new System.Drawing.Point(12, 142);
            this.textBoxLogging.Multiline = true;
            this.textBoxLogging.Name = "textBoxLogging";
            this.textBoxLogging.ReadOnly = true;
            this.textBoxLogging.Size = new System.Drawing.Size(521, 150);
            this.textBoxLogging.TabIndex = 38;
            this.textBoxLogging.Text = "Logging is WIP.";
            // 
            // FormControlPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(545, 347);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxLogging);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonPathDialog);
            this.Controls.Add(this.textBoxPathServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormControlPanel";
            this.ShowIcon = false;
            this.Text = "Control Panel (ALPHA)";
            this.Load += new System.EventHandler(this.FormControlPanel_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonWorldServer;
		private System.Windows.Forms.Button buttonAuthServer;
		private System.Windows.Forms.TextBox textBoxPathServer;
		private System.Windows.Forms.CheckBox checkBoxHideWorld;
		private System.Windows.Forms.CheckBox checkBoxHideAuth;
		private System.Windows.Forms.Button buttonPathDialog;
		private System.Windows.Forms.CheckBox checkBoxRestartWorld;
		private System.Windows.Forms.CheckBox checkBoxRestartAuth;
		private System.Windows.Forms.Timer timerCheckProcess;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label labelAuth;
		private System.Windows.Forms.PictureBox pictureBoxAuth;
		private System.Windows.Forms.PictureBox pictureBoxWorld;
		private System.Windows.Forms.Label labelWorld;
		private System.Windows.Forms.TextBox textBoxLogging;
		private System.Windows.Forms.Button buttonWorldConfig;
		private System.Windows.Forms.Button buttonAuthConfig;
	}
}