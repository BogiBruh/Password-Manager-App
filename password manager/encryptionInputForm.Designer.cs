namespace password_manager
{
    partial class encryptionInputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.phraseTxtBox = new System.Windows.Forms.TextBox();
            this.cnfButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "placehjolder";
            // 
            // phraseTxtBox
            // 
            this.phraseTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phraseTxtBox.Location = new System.Drawing.Point(17, 100);
            this.phraseTxtBox.Name = "phraseTxtBox";
            this.phraseTxtBox.Size = new System.Drawing.Size(605, 29);
            this.phraseTxtBox.TabIndex = 1;
            // 
            // cnfButton
            // 
            this.cnfButton.Location = new System.Drawing.Point(638, 100);
            this.cnfButton.Name = "cnfButton";
            this.cnfButton.Size = new System.Drawing.Size(39, 29);
            this.cnfButton.TabIndex = 2;
            this.cnfButton.Text = "✔";
            this.cnfButton.UseVisualStyleBackColor = true;
            // 
            // encryptionInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 226);
            this.Controls.Add(this.cnfButton);
            this.Controls.Add(this.phraseTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "encryptionInputForm";
            this.Text = "Enter backup phrase";
            this.Load += new System.EventHandler(this.encryptionInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phraseTxtBox;
        private System.Windows.Forms.Button cnfButton;
    }
}