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
            this.backupPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPasswordForm
            // 
            this.panelPasswordForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelPasswordForm.Location = new System.Drawing.Point(325, 28);
            this.panelPasswordForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelPasswordForm.Name = "panelPasswordForm";
            this.panelPasswordForm.Size = new System.Drawing.Size(934, 690);
            this.panelPasswordForm.TabIndex = 0;
            // 
            // panelProfiles
            // 
            this.panelProfiles.AutoScroll = true;
            this.panelProfiles.Location = new System.Drawing.Point(0, 28);
            this.panelProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.panelProfiles.Name = "panelProfiles";
            this.panelProfiles.Size = new System.Drawing.Size(325, 690);
            this.panelProfiles.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupPasswordsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1259, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backupPasswordsToolStripMenuItem
            // 
            this.backupPasswordsToolStripMenuItem.Name = "backupPasswordsToolStripMenuItem";
            this.backupPasswordsToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.backupPasswordsToolStripMenuItem.Text = "Backup passwords";
            this.backupPasswordsToolStripMenuItem.Click += new System.EventHandler(this.backupPasswordsToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1259, 643);
            this.Controls.Add(this.panelProfiles);
            this.Controls.Add(this.panelPasswordForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem backupPasswordsToolStripMenuItem;
    }
}

