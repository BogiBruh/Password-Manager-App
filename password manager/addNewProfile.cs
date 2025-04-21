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
    public partial class addNewProfile : Form
    {
        mainForm MainForm = null;
        public addNewProfile()
        {
            InitializeComponent();
        }

        private void addNewProfile_Load(object sender, EventArgs e)
        {
            label1.Left = this.Width / 2 - label1.Width/2;
            loadingLabel.Text = "";
        }

        private void finalizeInput_Click(object sender, EventArgs e)
        {
            string platformName = textBox1.Text;
            loadingLabel.Text = $"Loading {platformName}'s logo, please wait...";
            loadingLabel.Refresh(); //forcing a refresh before a heavy function call should be no problem(clueless)
            loadingLabel.Left = this.Width / 2 - loadingLabel.Width / 2;
            logoScraper.scrapeLogo(platformName);

            if(MainForm == null)
            {
                MessageBox.Show("upsili dadili");
            }
            else MainForm.buttonList.Add(buttonGenerator.generateAButton(platformName, MainForm));
            loadingLabel.Text = "Generating the sidebar button, please wait...";
            loadingLabel.Refresh();
            MainForm.drawButtons();
            loadingLabel.Text = "Loading the pasword window, please wait...";
            loadingLabel.Refresh();
            MainForm.draw(platformName, "platform");
            
        }

        public void passMainFormReference(mainForm formPassed)
        {
            MainForm = formPassed;
        }
    }
}
