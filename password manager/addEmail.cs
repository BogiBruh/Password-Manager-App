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
    public partial class addEmail : Form
    {
        mainForm main = null;
        Panel controls = null;
        public addEmail()
        {
            InitializeComponent();
        }
        private void addEmail_Load(object sender, EventArgs e)
        {
            btnConfirm.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] emailEndings = {"@gmail.com", "@yahoo.com", "@aol.com", "@hotmail.com", "@gs.viser.edu.rs"};
            string txtBoxStr = textBox1.Text;
            int containsEmailEnding = -1;

            for (int i = 0; i < emailEndings.Length; i++)
            {
                containsEmailEnding = txtBoxStr.IndexOf(emailEndings[i], StringComparison.OrdinalIgnoreCase);
                break;
            }
            
            if(containsEmailEnding == -1)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                btnConfirm.Enabled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ComboBox emailSelector = controls.Controls.OfType<ComboBox>().FirstOrDefault();
            emailSelector.Items.Add(textBox1.Text);
        }

        public void forwardMainReference(mainForm mainRef, Panel controlPanel)
        {
            main = mainRef;
            controls = controlPanel;
        }
    }
}
