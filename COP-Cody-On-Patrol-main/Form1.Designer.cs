namespace Duty_After_Coding
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gunner = new PictureBox();
            zombies = new PictureBox();
            pictureBox1 = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            fence = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gunner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zombies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // gunner
            // 
            gunner.BackColor = Color.Transparent;
            gunner.Image = Properties.Resources.shooting_instance_2;
            gunner.Location = new Point(200, 317);
            gunner.Margin = new Padding(3, 2, 3, 2);
            gunner.Name = "gunner";
            gunner.Size = new Size(59, 77);
            gunner.SizeMode = PictureBoxSizeMode.StretchImage;
            gunner.TabIndex = 0;
            gunner.TabStop = false;
            gunner.Tag = "gunner";
            // 
            // zombies
            // 
            zombies.BackColor = Color.Transparent;
            zombies.Image = Properties.Resources.zombie_left;
            zombies.Location = new Point(1120, 276);
            zombies.Margin = new Padding(3, 2, 3, 2);
            zombies.Name = "zombies";
            zombies.Size = new Size(140, 134);
            zombies.SizeMode = PictureBoxSizeMode.StretchImage;
            zombies.TabIndex = 1;
            zombies.TabStop = false;
            zombies.Tag = "zombies";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.zombie_left;
            pictureBox1.Location = new Point(1013, 326);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "zombies";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // fence
            // 
            fence.BackColor = Color.Transparent;
            fence.Image = Properties.Resources.w;
            fence.Location = new Point(0, 270);
            fence.Margin = new Padding(3, 2, 3, 2);
            fence.Name = "fence";
            fence.Size = new Size(152, 58);
            fence.SizeMode = PictureBoxSizeMode.StretchImage;
            fence.TabIndex = 3;
            fence.TabStop = false;
            fence.Tag = "fence";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.w;
            pictureBox2.Location = new Point(150, 272);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "fence";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.w;
            pictureBox3.Location = new Point(294, 272);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(128, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "fence";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.level1_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1298, 443);
            Controls.Add(pictureBox1);
            Controls.Add(zombies);
            Controls.Add(gunner);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(fence);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(1298, 443);
            MinimizeBox = false;
            MinimumSize = new Size(1298, 443);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            ((System.ComponentModel.ISupportInitialize)gunner).EndInit();
            ((System.ComponentModel.ISupportInitialize)zombies).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fence).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox gunner;
        private PictureBox zombies;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox fence;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}