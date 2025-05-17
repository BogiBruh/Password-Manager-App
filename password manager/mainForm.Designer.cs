namespace password_manager
{
    partial class mainForm
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
            this.panelPasswordForm = new System.Windows.Forms.Panel();
            this.panelProfiles = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupPasswordsToDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readPasswordBackupFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPasswordForm
            // 
            this.panelPasswordForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelPasswordForm.Location = new System.Drawing.Point(244, 23);
            this.panelPasswordForm.Name = "panelPasswordForm";
            this.panelPasswordForm.Size = new System.Drawing.Size(700, 510);
            this.panelPasswordForm.TabIndex = 0;
            // 
            // panelProfiles
            // 
            this.panelProfiles.AutoScroll = true;
            this.panelProfiles.Location = new System.Drawing.Point(0, 23);
            this.panelProfiles.Name = "panelProfiles";
            this.panelProfiles.Size = new System.Drawing.Size(244, 510);
            this.panelProfiles.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupPasswordsToDesktopToolStripMenuItem,
            this.readPasswordBackupFromFileToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // backupPasswordsToDesktopToolStripMenuItem
            // 
            this.backupPasswordsToDesktopToolStripMenuItem.Name = "backupPasswordsToDesktopToolStripMenuItem";
            this.backupPasswordsToDesktopToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.backupPasswordsToDesktopToolStripMenuItem.Text = "Backup passwords to desktop";
            this.backupPasswordsToDesktopToolStripMenuItem.Click += new System.EventHandler(this.backupPasswords);
            // 
            // readPasswordBackupFromFileToolStripMenuItem
            // 
            this.readPasswordBackupFromFileToolStripMenuItem.Name = "readPasswordBackupFromFileToolStripMenuItem";
            this.readPasswordBackupFromFileToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.readPasswordBackupFromFileToolStripMenuItem.Text = "Read password backup from file";
            this.readPasswordBackupFromFileToolStripMenuItem.Click += new System.EventHandler(this.readBackup);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(944, 531);
            this.Controls.Add(this.panelProfiles);
            this.Controls.Add(this.panelPasswordForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPasswordForm;
        private System.Windows.Forms.Panel panelProfiles;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupPasswordsToDesktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readPasswordBackupFromFileToolStripMenuItem;
    }
}

