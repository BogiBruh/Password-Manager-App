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
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHidePass)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.InitialImage = null;
            this.logoBox.Location = new System.Drawing.Point(177, 47);
            this.logoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(100, 92);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(101, 303);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordField.Name = "passwordField";
            this.passwordField.ReadOnly = true;
            this.passwordField.Size = new System.Drawing.Size(524, 37);
            this.passwordField.TabIndex = 1;
            this.passwordField.TabStop = false;
            // 
            // copyPassword
            // 
            this.copyPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyPassword.Location = new System.Drawing.Point(705, 303);
            this.copyPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copyPassword.Name = "copyPassword";
            this.copyPassword.Size = new System.Drawing.Size(48, 41);
            this.copyPassword.TabIndex = 2;
            this.copyPassword.TabStop = false;
            this.copyPassword.Click += new System.EventHandler(this.copyPassword_Click);
            // 
            // showHidePass
            // 
            this.showHidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showHidePass.Location = new System.Drawing.Point(805, 304);
            this.showHidePass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showHidePass.Name = "showHidePass";
            this.showHidePass.Size = new System.Drawing.Size(49, 39);
            this.showHidePass.TabIndex = 3;
            this.showHidePass.TabStop = false;
            this.showHidePass.Click += new System.EventHandler(this.showHidePass_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.generateBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Location = new System.Drawing.Point(232, 364);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(521, 106);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate a new password";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // platformName
            // 
            this.platformName.AutoSize = true;
            this.platformName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformName.Location = new System.Drawing.Point(171, 178);
            this.platformName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.platformName.Name = "platformName";
            this.platformName.Size = new System.Drawing.Size(157, 31);
            this.platformName.TabIndex = 5;
            this.platformName.Text = "Placeholder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 489);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "                    Are you sure you want to change your password?\r\nThis action i" +
    "s permanent and you cannot get the current password back\r\n";
            this.label1.Visible = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.Red;
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(276, 544);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(67, 62);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "YES";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Visible = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // denyBtn
            // 
            this.denyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denyBtn.Location = new System.Drawing.Point(581, 544);
            this.denyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.denyBtn.Name = "denyBtn";
            this.denyBtn.Size = new System.Drawing.Size(67, 62);
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
            // platformDefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(949, 665);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}