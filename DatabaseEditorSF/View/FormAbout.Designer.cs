namespace DatabaseEditorSF.Views {
	partial class FormAbout {
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
            this.buttonAboutOK = new System.Windows.Forms.Button();
            this.labelAboutVersion = new System.Windows.Forms.Label();
            this.labelAboutDatabaseEditorSF = new System.Windows.Forms.Label();
            this.labelAboutCopy = new System.Windows.Forms.Label();
            this.labelAboutCreator = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAboutOK
            // 
            this.buttonAboutOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAboutOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.buttonAboutOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAboutOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.buttonAboutOK.Location = new System.Drawing.Point(399, 325);
            this.buttonAboutOK.Name = "buttonAboutOK";
            this.buttonAboutOK.Size = new System.Drawing.Size(75, 25);
            this.buttonAboutOK.TabIndex = 0;
            this.buttonAboutOK.Text = "OK";
            this.buttonAboutOK.UseVisualStyleBackColor = false;
            this.buttonAboutOK.Click += new System.EventHandler(this.buttonAboutOK_Click);
            // 
            // labelAboutVersion
            // 
            this.labelAboutVersion.AutoSize = true;
            this.labelAboutVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelAboutVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.labelAboutVersion.Location = new System.Drawing.Point(189, 185);
            this.labelAboutVersion.Name = "labelAboutVersion";
            this.labelAboutVersion.Size = new System.Drawing.Size(92, 13);
            this.labelAboutVersion.TabIndex = 1;
            this.labelAboutVersion.Text = "Version: 0.5-alpha";
            // 
            // labelAboutDatabaseEditorSF
            // 
            this.labelAboutDatabaseEditorSF.AutoSize = true;
            this.labelAboutDatabaseEditorSF.BackColor = System.Drawing.Color.Transparent;
            this.labelAboutDatabaseEditorSF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.labelAboutDatabaseEditorSF.Location = new System.Drawing.Point(54, 158);
            this.labelAboutDatabaseEditorSF.Name = "labelAboutDatabaseEditorSF";
            this.labelAboutDatabaseEditorSF.Size = new System.Drawing.Size(358, 13);
            this.labelAboutDatabaseEditorSF.TabIndex = 2;
            this.labelAboutDatabaseEditorSF.Text = "DatabaseEditorSF is a database editor, specifically for Skyfire 5.4.8 18414.";
            // 
            // labelAboutCopy
            // 
            this.labelAboutCopy.AutoSize = true;
            this.labelAboutCopy.BackColor = System.Drawing.Color.Transparent;
            this.labelAboutCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.labelAboutCopy.Location = new System.Drawing.Point(54, 215);
            this.labelAboutCopy.Name = "labelAboutCopy";
            this.labelAboutCopy.Size = new System.Drawing.Size(358, 52);
            this.labelAboutCopy.TabIndex = 1;
            this.labelAboutCopy.Text = "© 2018 All rights reserved.\r\n\r\nThe contributor is not responsible for any errors " +
    "or corruption in your server.\r\nThis program is used at own risk and the creator " +
    "takes no responsibility.";
            // 
            // labelAboutCreator
            // 
            this.labelAboutCreator.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelAboutCreator.AutoSize = true;
            this.labelAboutCreator.BackColor = System.Drawing.Color.Transparent;
            this.labelAboutCreator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(64)))));
            this.labelAboutCreator.Location = new System.Drawing.Point(13, 331);
            this.labelAboutCreator.Margin = new System.Windows.Forms.Padding(4);
            this.labelAboutCreator.Name = "labelAboutCreator";
            this.labelAboutCreator.Size = new System.Drawing.Size(185, 13);
            this.labelAboutCreator.TabIndex = 4;
            this.labelAboutCreator.Text = "Contributor(s): AriDEV and NuskyDEV";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DatabaseEditorSF.Properties.Resources.titleDatabaseEditorSF;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(57, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(486, 362);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAboutCreator);
            this.Controls.Add(this.labelAboutDatabaseEditorSF);
            this.Controls.Add(this.labelAboutCopy);
            this.Controls.Add(this.labelAboutVersion);
            this.Controls.Add(this.buttonAboutOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAboutOK;
		private System.Windows.Forms.Label labelAboutVersion;
		private System.Windows.Forms.Label labelAboutDatabaseEditorSF;
		private System.Windows.Forms.Label labelAboutCopy;
		private System.Windows.Forms.Label labelAboutCreator;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}