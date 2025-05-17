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
            this.components = new System.ComponentModel.Container();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.copyPassword = new System.Windows.Forms.PictureBox();
            this.showHidePass = new System.Windows.Forms.PictureBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.platformName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.denyBtn = new System.Windows.Forms.Button();
            this.timerGnerate = new System.Windows.Forms.Timer(this.components);
            this.additionalLabel = new System.Windows.Forms.Label();
            this.additionalDataTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHidePass)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.InitialImage = null;
            this.logoBox.Location = new System.Drawing.Point(133, 38);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(75, 75);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(76, 246);
            this.passwordField.Name = "passwordField";
            this.passwordField.ReadOnly = true;
            this.passwordField.Size = new System.Drawing.Size(394, 31);
            this.passwordField.TabIndex = 1;
            this.passwordField.TabStop = false;
            // 
            // copyPassword
            // 
            this.copyPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyPassword.Location = new System.Drawing.Point(529, 246);
            this.copyPassword.Name = "copyPassword";
            this.copyPassword.Size = new System.Drawing.Size(36, 33);
            this.copyPassword.TabIndex = 2;
            this.copyPassword.TabStop = false;
            this.copyPassword.Click += new System.EventHandler(this.copyPassword_Click);
            // 
            // showHidePass
            // 
            this.showHidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showHidePass.Location = new System.Drawing.Point(604, 247);
            this.showHidePass.Name = "showHidePass";
            this.showHidePass.Size = new System.Drawing.Size(37, 32);
            this.showHidePass.TabIndex = 3;
            this.showHidePass.TabStop = false;
            this.showHidePass.Click += new System.EventHandler(this.showHidePass_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.generateBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Location = new System.Drawing.Point(174, 296);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(391, 86);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate a new password";
            this.generateBtn.UseVisualStyleBackColor = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "                    Are you sure you want to change your password?\r\nThis action i" +
    "s permanent and you cannot get the current password back\r\n";
            this.label1.Visible = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.Red;
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(207, 442);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(50, 50);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "YES";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Visible = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // denyBtn
            // 
            this.denyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denyBtn.Location = new System.Drawing.Point(436, 442);
            this.denyBtn.Name = "denyBtn";
            this.denyBtn.Size = new System.Drawing.Size(50, 50);
            this.denyBtn.TabIndex = 8;
            this.denyBtn.Text = "No";
            this.denyBtn.UseVisualStyleBackColor = true;
            this.denyBtn.Visible = false;
            this.denyBtn.Click += new System.EventHandler(this.denyBtn_Click);
            // 
            // timerGnerate
            // 
            this.timerGnerate.Interval = 5000;
            this.timerGnerate.Tick += new System.EventHandler(this.timerGnerate_Tick);
            // 
            // additionalLabel
            // 
            this.additionalLabel.AutoSize = true;
            this.additionalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalLabel.Location = new System.Drawing.Point(72, 399);
            this.additionalLabel.Name = "additionalLabel";
            this.additionalLabel.Size = new System.Drawing.Size(386, 40);
            this.additionalLabel.TabIndex = 9;
            this.additionalLabel.Text = "Additional data for the account(email, username, etc.)\r\n\r\n";
            // 
            // additionalDataTxtBox
            // 
            this.additionalDataTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalDataTxtBox.Location = new System.Drawing.Point(76, 423);
            this.additionalDataTxtBox.Multiline = true;
            this.additionalDataTxtBox.Name = "additionalDataTxtBox";
            this.additionalDataTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.additionalDataTxtBox.Size = new System.Drawing.Size(382, 80);
            this.additionalDataTxtBox.TabIndex = 10;
            // 
            // platformDefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 561);
            this.Controls.Add(this.additionalDataTxtBox);
            this.Controls.Add(this.additionalLabel);
            this.Controls.Add(this.denyBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button denyBtn;
        private System.Windows.Forms.Timer timerGnerate;
        private System.Windows.Forms.Label additionalLabel;
        private System.Windows.Forms.TextBox additionalDataTxtBox;
    }
}