﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_manager
{
    public class platform
    {
        public string platformName { get; set; }
        public string passwordString { get; set; }
        //public string emailString; - add when adding emails

        public platform(string platform, string password)
        {
            platformName = platform;
            passwordString = password;
        }

        public platform() { } //This is so JsonSerializer.Deserialize doesnt freak out
    }
}
