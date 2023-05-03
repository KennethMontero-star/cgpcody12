namespace Duty_After_Coding
{
    public partial class Form1 : Form
    {
        bool goUp, goDown;
        public Form1()
        {
            InitializeComponent();
        }

        //controls if keys are holding or press
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                gunner.Image = Properties.Resources.shooting_instances;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                gunner.Image = Properties.Resources.shooting_instances;
            }
        }

        //controls if keys are release
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
                gunner.Image = Properties.Resources.shooting_instance_2;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
                gunner.Image = Properties.Resources.shooting_instance_2;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (goUp == true)
            {
                gunner.Top -= 10;
            }
            if (goDown == true)
            {
                gunner.Top += 10;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}