using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_manager
{
    internal class formCleanup
    {
        public static void clean(Panel formPanel)
        {
            //formToClose initialized and fetches the first(and only) form shown in panelPasswordForm
            Form formToClose = formPanel.Controls.OfType<platformDefaultForm>().FirstOrDefault();

            if (formToClose != null)
            {
                switch (formToClose)
                {
                    case platformDefaultForm platForm:
                        platForm.memCleanup();
                        GC.Collect();
                        platForm.Close();
                        platForm.Dispose();
                        break;
                    case addNewProfile addNew:
                        addNew.Close();
                        addNew.Dispose();
                        break;
                    default:
                        MessageBox.Show("that aint right");
                        break;
                }
                formPanel.Controls.Clear();
            }
        }
    }
}
