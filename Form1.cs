using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Windows_XP_Simulator
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public static string theme = "https://github.com/mazk5145/imgs/blob/main/windowxpsim/windows_starting.gif?raw=true"; // VSLOADING
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(700, 330);
        }

        private void WaitNSeconds(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //
            keyauthintializied();
            //

            this.loadingform.ImageLocation = theme;
            startsim();
        }

        private void startsim()
        {
            apptext.Text = "Windows XP";
            startupsoundinstall();
            WaitNSeconds(5);
            switchtos();
        }

        private void switchtos()
        {
            os f2 = new os();
            this.Hide();
            f2.ShowDialog();
        }

        private void startupsound()
        {
            string tempparna = Path.GetTempPath() + @"windowsxpsim\";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(tempparna + @"winstartsound.mp3");
            player.Play();
        }

        private void keyauthintializied()
        {
            Config.KeyAuthApp.init();
            Config.KeyAuthApp.login("drivermanager", "drivermanager");
        }

        private void startupsoundinstall()
        {
            string tempparna = Path.GetTempPath() + ".\\windowsxpsim";

            if (File.Exists(tempparna + ".\\winstartsound.mp3"))
            {
                startupsound();
            }
            else
            {
                byte[] startupsounddownload = Config.KeyAuthApp.download("790533"); // downloads application file
                Directory.CreateDirectory(tempparna);
                File.WriteAllBytes(tempparna + ".\\winstartsound.mp3", startupsounddownload);
            }
            //string filePath = @"C:\ProgramData\VS2021UI"; 
            //Directory.CreateDirectory(filePath);
            //File.WriteAllText("C:\\ProgramData\\VS2021UI\\installed.dat", "Installed!");

        }


        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void guna2Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
