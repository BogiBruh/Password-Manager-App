using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_manager
{
    public class platform
    {
        public string platformName;
        public string passwordString;
        //public string emailString; - add when adding emails

        public platform(string platform, string password)
        {
            platformName = platform;
            passwordString = password;
        }

        public void setPassword(string password)
        {
            passwordString = password;
        }
    }
}
