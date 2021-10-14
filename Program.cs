using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_XP_Simulator
{
    static class Program
    {
        public static string github = "github.com/mazk5145";

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        static void Main()
        {
            Config.KeyAuthApp.init();
            Config.KeyAuthApp.login("drivermanager", "drivermanager");
            var handle = GetConsoleWindow();

            winxplogo();
            Console.Title = "Windows XP Console";
            Console.WriteLine("Checking XP Files....");
            installallfiles();
            Console.WriteLine("Files are updated, Starting OS....");
            WaitNSeconds(1);
            Console.WriteLine("Starting Service.dux");
            WaitNSeconds(1);
            Console.WriteLine("Intializing osinterface.dll");
            WaitNSeconds(1);
            Console.WriteLine("Starting services...");
            WaitNSeconds(1);
            Console.WriteLine("Intializing Services.dll");
            WaitNSeconds(1);
            Console.WriteLine("Starting OS.dll");
            WaitNSeconds(1);
            Console.WriteLine("Intializing OS.dll");
            WaitNSeconds(1);
            Console.WriteLine("---------------------------------");
            WaitNSeconds(1);
            Console.WriteLine("Windows XP Simulator by mazk#9154");
            WaitNSeconds(1);
            ShowWindow(handle, SW_HIDE);
            


            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        public static void installallfiles()
        {
            string tempparna = Path.GetTempPath() + ".\\windowsxpsim";

            byte[] startupsounddownload = Config.KeyAuthApp.download("790533");
            Directory.CreateDirectory(tempparna);
            File.WriteAllBytes(tempparna + ".\\winstartsound.mp3", startupsounddownload);

            byte[] shutdownaudio = Config.KeyAuthApp.download("213289");
            File.WriteAllBytes(tempparna + ".\\shutdownsound.mp3", shutdownaudio);

            byte[] sw = Config.KeyAuthApp.download("587170");
            File.WriteAllBytes(tempparna + ".\\startup.mp3", sw);

        }

        public static void WaitNSeconds(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        public static void winxplogo()
        {
            Console.WriteLine("");
            Console.WriteLine("               ██     ██ ██ ███    ██ ██   ██ ██████  ");
            Console.WriteLine("               ██     ██ ██ ████   ██  ██ ██  ██   ██ ");
            Console.WriteLine("               ██  █  ██ ██ ██ ██  ██   ███   ██████  ");
            Console.WriteLine("               ██ ███ ██ ██ ██  ██ ██  ██ ██  ██      ");
            Console.WriteLine("                ███ ███  ██ ██   ████ ██   ██ ██      ");
            Console.WriteLine("                        " + github + "           ");
            Console.WriteLine("");
        }

    }
}


