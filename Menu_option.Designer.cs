namespace Duty_After_Coding
{
    partial class Menu_option
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            trackBar1 = new TrackBar();
            btn_sound = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_sound).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.option_menu;
            pictureBox1.Location = new Point(63, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(157, 256);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(160, 45);
            trackBar1.TabIndex = 2;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // btn_sound
            // 
            btn_sound.Image = Properties.Resources.sound_on;
            btn_sound.Location = new Point(212, 190);
            btn_sound.Name = "btn_sound";
            btn_sound.Size = new Size(50, 50);
            btn_sound.SizeMode = PictureBoxSizeMode.AutoSize;
            btn_sound.TabIndex = 3;
            btn_sound.TabStop = false;
            // 
            // Menu_option
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 105, 54);
            ClientSize = new Size(476, 519);
            Controls.Add(btn_sound);
            Controls.Add(trackBar1);
            Controls.Add(pictureBox1);
            Name = "Menu_option";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu_option";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_sound).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TrackBar trackBar1;
        private PictureBox btn_sound;
    }
}