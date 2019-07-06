using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApplication6
{
    public partial class Home : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Home()
        {
            InitializeComponent();
            player.URL = "musicmp3.mp3";
        }

        private void Home_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void btnstopmusic_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            try
            {
                loging form = new loging();
                form.Show();
                this.Hide();
            }
            catch (Exception ex) { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }

        private void btnnewuser_Click(object sender, EventArgs e)
        {
            try
            {
                create_new_user form = new create_new_user();
                form.Show();
                this.Hide();
            }catch(Exception ex) { }
        }
    }
}
