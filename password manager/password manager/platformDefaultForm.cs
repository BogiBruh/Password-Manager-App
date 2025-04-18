using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace password_manager
{
    public partial class platformDefaultForm : Form
    {
        public platformDefaultForm()
        {
            InitializeComponent();
        }

        private void platformDefaultForm_Load(object sender, EventArgs e)
        {
            //INITIALIZING POSITIONS OF ITEMS
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img", "icons", "photo.png"));
            logoBox.Left = (this.ClientSize.Width / 2) - (logoBox.Size.Width / 2);

            showHidePass.SizeMode = PictureBoxSizeMode.StretchImage;
            showHidePass.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img", "icons", "visibility.png"));

            copyPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            copyPassword.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img", "icons", "copy-link.png"));

            platformName.Left = (this.ClientSize.Width / 2) - (platformName.Size.Width / 2);
            //INITIALIZING END, VARIABLE DEFINITIONS

            passwordField.Text = "Placeholder Password Text.";
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            string passwordString = "";

            passwordString = PasswordGeneration.generateAPassword();
            passwordField.Text = passwordString;
        }

        private void copyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordField.Text);
        }
    }
}
