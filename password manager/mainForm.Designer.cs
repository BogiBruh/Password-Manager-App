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
            this.SuspendLayout();
            // 
            // panelPasswordForm
            // 
            this.panelPasswordForm.Location = new System.Drawing.Point(234, 0);
            this.panelPasswordForm.Name = "panelPasswordForm";
            this.panelPasswordForm.Size = new System.Drawing.Size(712, 583);
            this.panelPasswordForm.TabIndex = 0;
            // 
            // panelProfiles
            // 
            this.panelProfiles.Location = new System.Drawing.Point(0, 0);
            this.panelProfiles.Name = "panelProfiles";
            this.panelProfiles.Size = new System.Drawing.Size(233, 502);
            this.panelProfiles.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.panelProfiles);
            this.Controls.Add(this.panelPasswordForm);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPasswordForm;
        private System.Windows.Forms.Panel panelProfiles;
    }
}

