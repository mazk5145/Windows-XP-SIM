using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyAuth;

namespace Windows_XP_Simulator
{
    class Config
    {
        static string name = "";
        static string ownerid = "";
        static string secret = "";
        static string version = "1.0";

        public static api KeyAuthApp = new api(name, ownerid, secret, version);
    }
}
