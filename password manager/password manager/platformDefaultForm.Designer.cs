namespace password_manager
{
    partial class platformDefaultForm
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
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.copyPassword = new System.Windows.Forms.PictureBox();
            this.showHidePass = new System.Windows.Forms.PictureBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.platformName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHidePass)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.Location = new System.Drawing.Point(133, 38);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(75, 75);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(74, 282);
            this.passwordField.Name = "passwordField";
            this.passwordField.ReadOnly = true;
            this.passwordField.Size = new System.Drawing.Size(394, 31);
            this.passwordField.TabIndex = 1;
            this.passwordField.TabStop = false;
            // 
            // copyPassword
            // 
            this.copyPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyPassword.Location = new System.Drawing.Point(527, 282);
            this.copyPassword.Name = "copyPassword";
            this.copyPassword.Size = new System.Drawing.Size(36, 33);
            this.copyPassword.TabIndex = 2;
            this.copyPassword.TabStop = false;
            this.copyPassword.Click += new System.EventHandler(this.copyPassword_Click);
            // 
            // showHidePass
            // 
            this.showHidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showHidePass.Location = new System.Drawing.Point(602, 283);
            this.showHidePass.Name = "showHidePass";
            this.showHidePass.Size = new System.Drawing.Size(37, 32);
            this.showHidePass.TabIndex = 3;
            this.showHidePass.TabStop = false;
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Location = new System.Drawing.Point(172, 352);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(391, 86);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate a new password";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // platformName
            // 
            this.platformName.AutoSize = true;
            this.platformName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformName.Location = new System.Drawing.Point(128, 145);
            this.platformName.Name = "platformName";
            this.platformName.Size = new System.Drawing.Size(127, 26);
            this.platformName.TabIndex = 5;
            this.platformName.Text = "Placeholder";
            // 
            // platformDefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 540);
            this.Controls.Add(this.platformName);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.showHidePass);
            this.Controls.Add(this.copyPassword);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.logoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "platformDefaultForm";
            this.Text = "platformDefaultForm";
            this.Load += new System.EventHandler(this.platformDefaultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHidePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.PictureBox copyPassword;
        private System.Windows.Forms.PictureBox showHidePass;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Label platformName;
    }
}