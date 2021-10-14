using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_XP_Simulator
{
    public partial class osdown : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public static string theme = "https://github.com/mazk5145/imgs/blob/main/windowxpsim/shuttingdown.jpg?raw=true"; // VSLOADING
        public osdown()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(700, 330);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void osdown_Load(object sender, EventArgs e)
        {
            this.Show();
            apptext.Text = "Windows XP";
            this.loadingform.ImageLocation = theme;
            startupsound();
            WaitNSeconds(9);
            Environment.Exit(0);
        }

        private void startupsound()
        {
            string tempparna = Path.GetTempPath() + @"windowsxpsim\";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(tempparna + @"shutdownsound.mp3");
            player.Play();
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
