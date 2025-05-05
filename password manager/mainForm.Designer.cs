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
            this.backupPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPasswordForm
            // 
            this.panelPasswordForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelPasswordForm.Location = new System.Drawing.Point(244, 27);
            this.panelPasswordForm.Name = "panelPasswordForm";
            this.panelPasswordForm.Size = new System.Drawing.Size(714, 556);
            this.panelPasswordForm.TabIndex = 0;
            // 
            // panelProfiles
            // 
            this.panelProfiles.AutoScroll = true;
            this.panelProfiles.Location = new System.Drawing.Point(0, 27);
            this.panelProfiles.Name = "panelProfiles";
            this.panelProfiles.Size = new System.Drawing.Size(244, 477);
            this.panelProfiles.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupPasswordsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
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
            // backupPasswordsToolStripMenuItem
            // 
            this.backupPasswordsToolStripMenuItem.Name = "backupPasswordsToolStripMenuItem";
            this.backupPasswordsToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.backupPasswordsToolStripMenuItem.Text = "Backup passwords";
            this.backupPasswordsToolStripMenuItem.Click += new System.EventHandler(this.backupPasswordsToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(944, 501);
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
        private System.Windows.Forms.ToolStripMenuItem backupPasswordsToolStripMenuItem;
    }
}

