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
        public int passVisible = 1; // 1 - invisible, 0 - visible
        public string passwordString = "";
        //visible and invisible generated at the start cause Image.FromFile call generates a new image in memory every time you click to hide
        //or show the password. thats the only button that consistently changes its look when pressed so its the only one so far ive
        //had to do like this
        Image visible = Image.FromFile(Path.Combine(Application.StartupPath, "img", "icons", "visibility.png")); 
        Image invisible = Image.FromFile(Path.Combine(Application.StartupPath, "img", "icons", "invisible.png"));

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
            showHidePass.Image = visible;

            copyPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            copyPassword.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img", "icons", "copy-link.png"));

            platformName.Left = (this.ClientSize.Width / 2) - (platformName.Size.Width / 2);
            //INITIALIZING END, VARIABLE DEFINITIONSx
            passwordField.Text = "Placeholder Password Text.";
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            passwordField.Text = "";

            passwordString = PasswordGeneration.generateAPassword();
            switch (passVisible)
            {
                case 0:
                    passwordField.Text = passwordString;
                    break;
                case 1:
                    for (int i = 0; i < passwordString.Length; i++)
                    {
                        passwordField.Text += "*";
                    }
                    break;
                default: break;
            }
        }

        private void copyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordField.Text);
        }

        private void showHidePass_Click(object sender, EventArgs e)
        {
            switch (passVisible) //stupidest yet easiest way to do it
            {
                case 1:
                    passVisible = 0;
                    passwordField.Text = "";
                    showHidePass.Image = invisible;
                    passwordField.Text = passwordString;
                    break;
                case 0:
                    passVisible = 1;
                    passwordField.Text = "";
                    showHidePass.Image = visible;

                    for (int i = 0; i < passwordString.Length; i++)
                    {
                        passwordField.Text += "*";
                    }
                    break;
                default: break;
            }
        }
    }
}
