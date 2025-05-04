namespace password_manager
{
    partial class landingPage
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
            this.appNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.arrowImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.arrowImg)).BeginInit();
            this.SuspendLayout();
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(196, 162);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(563, 69);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "welcome to the app";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "You don\'t seem to have any passwords yet.\r\nClick the \"Add a profile\" button on th" +
    "e left and you can get started easily.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // arrowImg
            // 
            this.arrowImg.Location = new System.Drawing.Point(104, 50);
            this.arrowImg.Name = "arrowImg";
            this.arrowImg.Size = new System.Drawing.Size(100, 50);
            this.arrowImg.TabIndex = 2;
            this.arrowImg.TabStop = false;
            // 
            // landingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 665);
            this.Controls.Add(this.arrowImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "landingPage";
            this.Text = "landingPage";
            this.Load += new System.EventHandler(this.landingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arrowImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox arrowImg;
    }
}