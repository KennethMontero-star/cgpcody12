using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duty_After_Coding
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            /*public Menu()
        {
            InitializeComponent();
            wplayer.URL = (@"C:\Users\ALL IN ONE\source\newrepo\menupractice\menupractice\Resources\hhhhhhhhhhhhhhhh.wav");
            wplayer.controls.play();
            axWindowsMediaPlayer1.Hide();
            
        }*/
        }

        /*public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
         * code para sa sound ng menu
        */
        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start_hover;
            // pang pa tunog pag napili dun sa tatlong button
            /*System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\ALL IN ONE\source\newrepo\menupractice\menupractice\Resources\background sound.wav");
            sound.Play();*/
            // sa bawat Mouse hover lang to alagay pre

        }

        private void btn_option_MouseHover(object sender, EventArgs e)
        {
            btn_option.Image = Properties.Resources.option_hover;
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_hover;
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start_normal;
        }

        private void btn_option_MouseLeave(object sender, EventArgs e)
        {
            btn_option.Image = Properties.Resources.option_normal;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_normal;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_option_Click(object sender, EventArgs e)
        {
            Menu_option Mp = new Menu_option();
            Mp.Show();
        }
    }
}
