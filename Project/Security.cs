using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project
{
    public class Security
    {
        public static bool Login(string username, string password)
        {
            return (username == "Arpi" && password == "true");
        }
    }
}
