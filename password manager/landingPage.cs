using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_manager
{
    public partial class landingPage : Form
    {
        public landingPage()
        {
            InitializeComponent();
        }

        private void landingPage_Load(object sender, EventArgs e)
        {
            //INITIALIZING EVERYTHING
            Image butler = Image.FromFile(Path.Combine("img", "butlers", "butler no bg.png"));
            butlerImg.Image = butler;
            butlerImg.Width = butler.Width;
            butlerImg.SizeMode = PictureBoxSizeMode.Zoom;
            butlerImg.Left = this.Width / 2 - butler.Width / 2;

            string userName = Environment.UserName;
            label1.Text = $"Welcome, master {userName}";
            label2.Text = "To start my service, simply press the \"Add a new profile\" button on the side. \nI will show you how to use my services according to your needs.";
            label1.Left = this.Width / 2 - label1.Width / 2;
            label2.Left = this.Width / 2 - label2.Width / 2;
            //INITIALIZATION END
        }

        private void butlerImg_Click(object sender, EventArgs e)
        {

        }
    }
}
