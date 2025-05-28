using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace password_manager
{
    class buttonGenerator
    {
        public static Button generateAButton(string btnText, mainForm formWindow, platform Platform)
        {
            Font btnFont = new Font("Sans serif", 10);
            Button buttonga = new Button {
                Width = 227,
                Height = 100,
                Text = btnText,
                Font = btnFont
            };
            if(btnText != "Add a new profile")
            {
                buttonga.Click += (sender, e) => formWindow.draw(Platform, "platform");
            }
            else
            {
                buttonga.Click += (sender, e) => formWindow.addNew();
            }

            return buttonga;
        }
    }
}
