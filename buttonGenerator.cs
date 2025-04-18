using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_manager
{
    class buttonGenerator
    {
        public static Button generateAButton(string btnText)
        {
            Button buttonga = new Button();
            buttonga.Width = 232;
            buttonga.Height = 100;
            buttonga.Text = btnText;

            return buttonga;
        }
    }
}
