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
            platformDefaultForm form2 = new platformDefaultForm();
            form2.TopLevel = false;
            panelPasswordForm.Controls.Clear();

            panelPasswordForm.Controls.Add(form2);
            form2.Show();

            label1.Text = Convert.ToString(panelPasswordForm.Size.Width);
        }
    }
}
