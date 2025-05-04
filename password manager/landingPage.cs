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
            arrowImg.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img", "icons", "arrow.png"));
            /*if (File.Exists(Path.Combine(Application.StartupPath, "img", "icons", "arrow.png")))
            {
                MessageBox.Show("arrow.png exists");
            }
            else
            {
                MessageBox.Show("lololo");
            }*/
        }
    }
}
