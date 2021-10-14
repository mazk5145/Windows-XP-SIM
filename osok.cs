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
    public partial class osok : Form
    {
        public static string theme = "https://github.com/mazk5145/imgs/blob/main/windowxpsim/background.jpg?raw=true"; // VSLOADING
        public static string starmenubtn = "https://github.com/mazk5145/imgs/blob/main/windowxpsim/starmenu.png?raw=true"; // VSLOADING
        public osok()
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

        private void osok_Load(object sender, EventArgs e)
        {
            this.Show();
            apptext.Text = "Windows XP";
            this.loadingform.ImageLocation = theme;
            this.startmenuico.ImageLocation = starmenubtn;
            startupsound();
            WaitNSeconds(4);
            startmenupanel.Visible = true;

        }

        private void startupsound()
        {
            string tempparna = Path.GetTempPath() + @"windowsxpsim\";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(tempparna + @"startup.mp3");
            player.Play();
        }

        private void startmenuico_Click(object sender, EventArgs e)
        {
            startmenupaneeli.Visible = true;
        }

        private void loadingform_Click(object sender, EventArgs e)
        {
            if (startmenupaneeli.Visible == false)
            {
                startmenupaneeli.Visible = true;
            }
            else if (startmenupaneeli.Visible == true)
            {
                startmenupaneeli.Visible = false;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            osdown f3 = new osdown();
            this.Hide();
            f3.ShowDialog();
        }
    }
}
