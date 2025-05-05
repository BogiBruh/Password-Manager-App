using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_manager
{
    internal class filePath
    {
        public static string getRootPath()
        {
            return Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
        }
    }
}
