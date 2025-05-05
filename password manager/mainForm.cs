using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace password_manager
{
    public partial class mainForm : Form
    {
        public List<Button> buttonList = new List<Button>();
     
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //INITIALIZING VALUES - and the form with the password
            //draw("placeholder", "platform");
            string jsonTxt = null;
            buttonList.Add(buttonGenerator.generateAButton("Add a new profile", this, null));
            /*due to oversight in the system, draw() needs a platform and not just a form
             * so in case of landing page, send platformBlank
             */
            platform platformBlank = new platform();
            panelProfiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelPasswordForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;

            drawButtons();

            /*if there are no profiles, draw the landing page
             * else draw the last item off the list
             */
            if(buttonList.Count == 1)
            {
                draw(null, "landing");
            }
            else
            {
                draw(platformList[platformList.Count - 1], "platform");
            }
        }

        public void draw(string platformName, string formType)
        {
            Form formToShow = null;
            switch (formType) {
                case "landing":
                    formToShow = new landingPage();
                    break;
                case "email":
                    formToShow = new addEmail();
                    break;
                case "platform":
                    formToShow = new platformDefaultForm();
                    break;
                case "add":
                    formToShow = new addNewProfile();
                    break;
                default:
                    MessageBox.Show("whaddahell");
                    break;
            }
            Form formToClose = panelPasswordForm.Controls.OfType<platformDefaultForm>().FirstOrDefault();

            if(formToShow is landingPage landing)
            {
                //?
            }
            else if(formToShow is addEmail email)
            {
                //?
            }
            else if (formToShow is platformDefaultForm platformForm)
            {
                switch (formToClose)
                {
                    case platformDefaultForm platForm:
                        platForm.memCleanup();
                        GC.Collect();
                        platForm.Close();
                        platForm.Dispose();
                        break;
                    case addNewProfile addNew:
                        addNew.Close();
                        addNew.Dispose();
                        break;
                    default:
                        MessageBox.Show("that aint right");
                        break;
                }
                panelPasswordForm.Controls.Clear();
            }

            if (formToShow is platformDefaultForm platformForm) platformForm.customizeToPlatform(platformName);
            else if (formToShow is addNewProfile profileForm)
            {
                profileForm.passMainFormReference(this);
            }
            /*else if(formToShow is landingPage landing)
            {//if needed - add
                landing
            }*/

                formToShow.TopLevel = false;
            panelPasswordForm.Controls.Add(formToShow);

            formToShow.Show();
            formToShow.BringToFront();
            /* calling draw() from addNewProfile for some reason doesnt bring the new platformForm to the front, hacky solution to a 
             * possibly bigger problem
             */
        }

        public void addNew()
        {
            draw("this wont be used, right?", "add");
        }

        public void drawButtons()
        {
            ComboBox emailList = new ComboBox();
            emailList.Font = new Font(emailList.Font.FontFamily, 10);
            emailList.Width = 225;
            panelProfiles.Controls.Add(emailList);
            emailList.Items.Add("Add new emal address");
            emailList.SelectedIndex = 0;
            // add the buttons backwards, as to not fuck around with array reversal
            for (int i = buttonList.Count - 1; i >= 0; i--)
            {
                buttonList[i].Location = new Point(0, 25 + (buttonList.Count - i - 1) * 94);
                panelProfiles.Controls.Add(buttonList[i]);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            string jsonString = JsonSerializer.Serialize(platformList, new JsonSerializerOptions { WriteIndented = true });
            //MessageBox.Show(jsonString); //i did this cause its cool to see

            formCleanup.clean(panelPasswordForm);
            panelProfiles.Controls.Clear();

            File.WriteAllText("passwords.json", jsonString);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program made by Bogi\nIcons from flaticon.com, by Google\nPython, Selenium and Requests rights reserved by their owners");
        }

        private void addEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            platform nullPlatform = null;
            formCleanup.clean(panelProfiles);
            draw(nullPlatform, "email"); 
        }

        private void backupPasswordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP");
        }
    }
}
