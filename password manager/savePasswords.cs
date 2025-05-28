using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace password_manager
{
    class savePasswords
    {
        public static void save(mainForm mainForm)
        {
            string jsonString = JsonSerializer.Serialize(mainForm.platformList, new JsonSerializerOptions { WriteIndented = true });
            //MessageBox.Show(jsonString); //i did this cause its cool to see

            File.WriteAllText("passwords.json", jsonString);
        }
    }
}
