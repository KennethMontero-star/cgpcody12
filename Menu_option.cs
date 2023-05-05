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
    public partial class Menu_option : Form
    {
        public Menu_option()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // eto nayung code pag nalagyan na ng sound
            //wplayer ay para dun sa sound
            //Form1.wplayer.controls.play();
            btn_sound.Image = Properties.Resources.sound_on;
            //Form1.wplayer.settings.volume = trackBar1.Value;

            if (trackBar1.Value == 0)
            {
                // para sa trackbar para pag naga low volume maga red no sound 
                // tapos pag nagdagdag ng volume maga green ulit
                //btn_sound.Image = Properties.Resources.sound_off;
            }
        }
    }
}
