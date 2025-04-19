using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace password_manager
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //INITIALIZING VALUES - and the form with the password
            platformDefaultForm form2 = new platformDefaultForm();
            List<Button> buttonList = new List<Button>();
            form2.TopLevel = false;
            panelPasswordForm.Controls.Clear();
            panelProfiles.Controls.Clear();
            panelPasswordForm.Controls.Add(form2); //drawing the form in the main form
            form2.Show();

            buttonList.Add(buttonGenerator.generateAButton("Add a new profile", this));

            buttonList.Add(buttonGenerator.generateAButton("amazon", this));
            buttonList.Add(buttonGenerator.generateAButton("discord", this));
            buttonList.Add(buttonGenerator.generateAButton("spotify", this));

            for (int i = buttonList.Count - 1; i >= 0; i--)
            {
                buttonList[i].Location = new Point(0, 0 + (buttonList.Count - i - 1) * 100);
                panelProfiles.Controls.Add(buttonList[i]);
            }

        }

        public void draw(string platformName)
        {
            platformDefaultForm formTest = new platformDefaultForm();
            panelPasswordForm.Controls.Clear();

            formTest.customizeToPlatform(platformName);

            formTest.TopLevel = false;
            panelPasswordForm.Controls.Add(formTest);
            formTest.Show();
        }
    }
}
