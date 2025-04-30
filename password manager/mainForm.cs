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
using System.IO;

namespace password_manager
{
    public partial class mainForm : Form
    {
        public List<Button> buttonList = new List<Button>();

        public List<platform> platformList = new List<platform>();
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

            panelProfiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelPasswordForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;

            if (File.Exists("passwords.json"))
            {
                jsonTxt = File.ReadAllText("passwords.json");
            }
           //label1.Text = platformList[0].platformName;    

           //Reading from JSON test
           if(jsonTxt != null)
            {
                platformList = JsonSerializer.Deserialize<List<platform>>(jsonTxt);

                for(int i = 0; i < platformList.Count(); i++)
                {
                    buttonList.Add(buttonGenerator.generateAButton(platformList[i].platformName, this, platformList[i]));
                }
            }
            drawButtons();
        }

        public void draw(platform Platform, string formType)
        {
            //initializing form variable
            Form formToShow = null;
            switch (formType) {
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
            
            formCleanup.clean(panelPasswordForm);


            if (formToShow is platformDefaultForm platformForm)
            {
                /* as draw() is called in addNewProfile after we add a new item, it shouldnt 
                 * create any problem if we just call the last item. I mean, there should always
                 * be at least one item, right?
                 */
                platformForm.passProfileObj(Platform);
                platformForm.customizeToPlatform(Platform);
            }
            else if (formToShow is addNewProfile profileForm)
            {
                profileForm.passMainFormReference(this, platformList);
            }

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
            //the add form doesnt do anything with platforms so its ok(?) to  send a null
            platform platformBlank = null;
            draw(platformBlank, "add");
        }

        public void drawButtons()
        {
            // add the buttons backwards, as to not fuck around with array reversal
            for (int i = buttonList.Count - 1; i >= 0; i--)
            {
                buttonList[i].Location = new Point(0, 0 + (buttonList.Count - i - 1) * 100);
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
    }
}
