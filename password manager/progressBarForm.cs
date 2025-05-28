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
    public partial class progressBarForm : Form
    {
        public progressBarForm()
        {
            InitializeComponent();
        }

        private void progressBarForm_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
        }

        public void getTaskCount(int taskCount)
        {
            progressBar1.Maximum = taskCount;
        }
    }
}
