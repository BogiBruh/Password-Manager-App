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
using OpenQA.Selenium.DevTools.V133.Profiler;

namespace password_manager
{
    public partial class platformDefaultForm : Form
    {
        public int passVisible = 0; // 1 - visible, 0 - invisible
        public string passwordString = "Placeholder Password Text.";
        /*visible and invisible generated at the start cause Image.FromFile call generates a new image in memory every time you click to hide
         *or show the password. thats the only button that consistently changes its look when pressed so its the only one so far ive
         *had to do like this
         */
        readonly Image visible = Image.FromFile(Path.Combine(Application.StartupPath, "img", "icons", "visibility.png")); 
        readonly Image invisible = Image.FromFile(Path.Combine(Application.StartupPath, "img", "icons", "invisible.png"));
        //readonly to stop visual studio from complaining - how can an image not be readonly!?
        platform platform = new platform(null, null);

        public void customizeToPlatform(platform platform)
        {
            //instead of having a default image and "placeholder" as platformName.Text, show whats actually supposed to be there
            platformName.Text = platform.platformName;

            if (File.Exists(Path.Combine(Application.StartupPath, "img", "logos", platform.platformName + ".png")))
            {
                logoBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img", "logos", platform.platformName + ".png"));
            }
            else
            {
                logoBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img", "icons", "photo.png"));
            }
        }

        public platformDefaultForm()
        {
            InitializeComponent();
        }

        private void platformDefaultForm_Load(object sender, EventArgs e)
        {
            //INITIALIZING POSITIONS OF ITEMS
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            
            logoBox.Left = (this.ClientSize.Width / 2) - (logoBox.Size.Width / 2);
            showHidePass.SizeMode = PictureBoxSizeMode.StretchImage;
            showHidePass.Image = visible;

            copyPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            copyPassword.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img", "icons", "copy-link.png"));

            platformName.Left = (this.ClientSize.Width / 2) - (platformName.Size.Width / 2);
            if(platformName.Text == "Placeholder")
            {
                logoBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img", "icons", "photo.png"));
            }
            //INITIALIZING END, VARIABLE DEFINITIONSx
            if(platform == null)
            {
                MessageBox.Show("Error: platform is null");
            }
            else
            {
                passwordString = platform.passwordString;
            }

            showHidePass_Click(sender, e);
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if(platform.passwordString == null || platform.passwordString == "")
            {
                confirmBtn_Click(sender, e);
            }
            else
            {
                generateBtn.Enabled = false;
                label1.Visible = true;
                confirmBtn.Visible = true;
                confirmBtn.Enabled = false;
                denyBtn.Visible = true;
                denyBtn.Enabled = false;

                timerGnerate.Start();
            }
        }

        private void copyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordString); //i never thought it was that easy
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

        private void timerGnerate_Tick(object sender, EventArgs e)
        {
            confirmBtn.Enabled = true;
            denyBtn.Enabled = true;

            timerGnerate.Stop();
        }

        private void denyBtn_Click(object sender, EventArgs e)
        {
            generateBtn.Enabled = true;
            label1.Visible = false;
            confirmBtn.Visible = false;
            confirmBtn.Enabled = false;
            denyBtn.Visible = false;
            denyBtn.Enabled = false;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            generateBtn.Enabled = true;
            label1.Visible = false;
            confirmBtn.Visible = false;
            confirmBtn.Enabled = false;
            denyBtn.Visible = false;
            denyBtn.Enabled = false;

            passwordField.Text = "";

            passwordString = PasswordGeneration.generateAPassword();
            platform.passwordString = passwordString;

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

        public void memCleanup()
        {
            logoBox.Image.Dispose();
            logoBox.Image = null;
            logoBox.Dispose();
        }

        public void passProfileObj(platform platform)
        {
            this.platform = platform;
        }
    }
}
