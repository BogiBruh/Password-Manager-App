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
            /*due to oversight in the system, draw() needs a platform and not just a form
             * so in case of landing page, send platformBlank
             */
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

            /*if there are no profiles, draw the landing page
             * else draw the last item off the list
             */
            if (buttonList.Count == 1)
            {
                draw(null, "landing");
            }
            else
            {
                draw(platformList[platformList.Count - 1], "platform");
            }
        }

        public void draw(platform Platform, string formType)
        {
            //initializing form variable
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
            
            formCleanup.clean(panelPasswordForm);

            if(formToShow is landingPage landing)
            {
                //?
            }
            else if(formToShow is addEmail email)
            {
                email.forwardMainReference(this, panelProfiles);
            }
            else if (formToShow is platformDefaultForm platformForm)
            {
                /* as draw() is called in addNewProfile after we add a new item, it shouldnt 
                 * create any problem if we just call the last item. I mean, there should always
                 * be at least one item, right?
                 */
                platformForm.passProfileObj(this, Platform);
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
           // MessageBox.Show(buttonList.Count + "/" + platformList.Count);

            for (int i = buttonList.Count - 1; i >= 0; i--)
            {
                buttonList[i].Location = new Point(0, (buttonList.Count - i - 1) * 100);
                panelProfiles.Controls.Add(buttonList[i]);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            savePasswords.save(this);
            formCleanup.clean(panelPasswordForm);
            panelProfiles.Controls.Clear();

            base.OnFormClosing(e);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program made by Bogi\nIcons from flaticon.com, by Google\nPython, Selenium and Requests rights reserved by their owners", "Password Manager");
        }
        private void backupPasswords(object sender, EventArgs e)
        {
            string jsonString = JsonSerializer.Serialize(platformList, new JsonSerializerOptions { WriteIndented = true });
            byte[] encryptedToWrite = backup.encryption("test", jsonString);
            string backupData= Convert.ToBase64String(encryptedToWrite);
            //MessageBox.Show(Convert.ToBase64String(encryptedToWrite));

            File.WriteAllText($"C:/Users/{Environment.UserName}/Desktop/test.butler", backupData);
            MessageBox.Show($"Backup file test.butler created on Desktop.");
        }
        private async void readBackup(object s, EventArgs e)
        {
            OpenFileDialog backupFileDialog = new OpenFileDialog();
            backupFileDialog.Filter = "Butler files (*.butler)|*.butler";
            List<Task> scraping = new List<Task>();

            if(backupFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string encryptedBase64 = File.ReadAllText(backupFileDialog.FileName);
            byte[] encryptedBinary = Convert.FromBase64String(encryptedBase64);

            string jsonTxt = backup.decryption("test", encryptedBinary);

            //Reading from JSON test
            if (jsonTxt != null)
            {
                platformList = JsonSerializer.Deserialize<List<platform>>(jsonTxt);

                for (int i = 0; i < platformList.Count(); i++)
                {
                    buttonList.Add(buttonGenerator.generateAButton(platformList[i].platformName, this, platformList[i]));
                }
            }

            File.WriteAllText("passwords.json", jsonTxt);

            //Asynchronously scrape logos for the thing

            for(int i = 0; i < platformList.Count; i++)
            {
                scraping.Add(logoScraper.scrapeLogoAsync(platformList[i].platformName));
            }

            await Task.WhenAll(scraping);

            //Draw every ui element
            drawButtons();
            draw(platformList[platformList.Count - 1], "platform");
        }

        private void deleteCurrentPlatform(object s, EventArgs e)
        {
            platformDefaultForm platformForm = panelPasswordForm.Controls.OfType<platformDefaultForm>().FirstOrDefault();

            string platformName = "";
            if (platformForm == null) MessageBox.Show("Please select a platform before calling this function.");
            else
            {
                platformName = platformForm.platformName.Text;

                for(int i = 0; i < buttonList.Count; i++)
                {
                    if (buttonList[i].Text == platformName)
                    {
                        panelProfiles.Controls.Remove(buttonList[i]);
                        buttonList.RemoveAt(i);
                        break;
                    }
                }
                for(int i = 0; i < platformList.Count; i++)
                {
                    if(platformList[i].platformName == platformName)
                    {
                        platformList.RemoveAt(i);
                        break;
                    }
                }

                panelProfiles.Controls.Clear();
                drawButtons();
                draw(platformList[platformList.Count - 1], "platform");
            }
        }

        private void changePlatformImage(object s, EventArgs e)
        {
            platformDefaultForm platformForm = panelPasswordForm.Controls.OfType<platformDefaultForm>().FirstOrDefault();
            string platformName = platformForm.platformName.Text;
            string fileName = platformName + ".png";
            OpenFileDialog imageFileDialog = new OpenFileDialog();
            imageFileDialog.Filter = "PNG files (*.png)|*.png";

            if(imageFileDialog.ShowDialog() != DialogResult.OK) //get the file to replace
            {
                return;
            }

            formCleanup.clean(panelPasswordForm); //cleans the panel to free image-to-be-changed from memory

            if(File.Exists(Path.Combine(Application.StartupPath, "img", "logos", fileName))) //deletes image-to-be-changed
            {
                File.Delete(Path.Combine(Application.StartupPath, "img", "logos", fileName));
            }

            File.Move(imageFileDialog.FileName, Path.Combine(Application.StartupPath, "img", "logos", fileName)); //brings chosen image to its rightful place

            for(int i = 0; i < platformList.Count; i++) //redraws correct platform
            {
                if(platformList[i].platformName == platformName)
                {
                    draw(platformList[i], "platform");
                }
            }
        }
    }
}
