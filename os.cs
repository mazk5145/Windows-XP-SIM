using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_XP_Simulator
{
    public partial class os : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public static string theme = "https://github.com/mazk5145/imgs/blob/main/windowxpsim/loginscreenbg.png?raw=true"; // VSLOADING
        public static string pfpicico = "https://github.com/mazk5145/imgs/blob/main/windowxpsim/windowsxplogo.jpg?raw=true"; // VSLOADING
        public static string shutdownbtn = "https://github.com/mazk5145/imgs/blob/main/windowxpsim/image.png?raw=true"; // VSLOADING
        public static string signinico = "https://github.com/mazk5145/imgs/blob/main/windowxpsim/kuva_2021-10-14_164819.png?raw=true"; // VSLOADING
        public os()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(700, 330);
        }

        private void os_Load(object sender, EventArgs e)
        {
            apptext.Text = "Windows XP";
            this.loadingform.ImageLocation = theme;
            this.pfpic.ImageLocation = pfpicico;
            this.signin.ImageLocation = signinico;
            this.shutdownosimage.ImageLocation = shutdownbtn;
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

        private void shutdownosimage_Click(object sender, EventArgs e)
        {
            osdown f3 = new osdown();
            this.Hide();
            f3.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            osdown f3 = new osdown();
            this.Hide();
            f3.ShowDialog();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            osok f4 = new osok();
            this.Hide();
            f4.ShowDialog();
        }
    }
}
