namespace Duty_After_Coding
{
    partial class Menu
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
            btn_start = new PictureBox();
            btn_option = new PictureBox();
            btn_exit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_option).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.menu;
            pictureBox1.Location = new Point(33, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 455);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_start
            // 
            btn_start.Image = Properties.Resources.start_normal;
            btn_start.Location = new Point(168, 123);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(129, 62);
            btn_start.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_start.TabIndex = 1;
            btn_start.TabStop = false;
            btn_start.Click += btn_start_Click;
            btn_start.MouseLeave += btn_start_MouseLeave;
            btn_start.MouseHover += btn_start_MouseHover;
            // 
            // btn_option
            // 
            btn_option.Image = Properties.Resources.option_normal;
            btn_option.Location = new Point(168, 212);
            btn_option.Name = "btn_option";
            btn_option.Size = new Size(129, 62);
            btn_option.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_option.TabIndex = 2;
            btn_option.TabStop = false;
            btn_option.Click += btn_option_Click;
            btn_option.MouseLeave += btn_option_MouseLeave;
            btn_option.MouseHover += btn_option_MouseHover;
            // 
            // btn_exit
            // 
            btn_exit.Image = Properties.Resources.exit_normal;
            btn_exit.Location = new Point(168, 298);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(129, 62);
            btn_exit.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_exit.TabIndex = 3;
            btn_exit.TabStop = false;
            btn_exit.Click += btn_exit_Click;
            btn_exit.MouseLeave += btn_exit_MouseLeave;
            btn_exit.MouseHover += btn_exit_MouseHover;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 105, 54);
            ClientSize = new Size(476, 519);
            Controls.Add(btn_exit);
            Controls.Add(btn_option);
            Controls.Add(btn_start);
            Controls.Add(pictureBox1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_option).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox btn_start;
        private PictureBox btn_option;
        private PictureBox btn_exit;
    }
}