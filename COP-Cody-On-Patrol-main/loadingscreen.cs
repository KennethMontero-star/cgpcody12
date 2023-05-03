using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Duty_After_Coding
{
    public partial class loadingscreen : Form
    {
        public loadingscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Loading.Top -= 1;
            if (Loading.Top <= 335)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Loading.Top += 1;
            if (Loading.Top >= 355)
            {
                timer1.Start();
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if (panel2.Width >= 282)
            {
                timer3.Stop();
                Form1 fm1 = new Form1();
                fm1.Show();
                this.Hide();
            }
        }
    }
}
