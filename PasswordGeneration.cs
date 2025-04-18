using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_manager
{
    class PasswordGeneration
    {
        public static string generateAPassword()
        {
            string passwordString = "";
            int passLenght = 16;
            const string charArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/"; //base64 *should* work on most sites?
            Random rng = new Random();

            for(int i = 0; i < passLenght; i++)
            {
                passwordString += charArray[rng.Next(0, 64)];
            }

            return passwordString;
        }
    }
}
