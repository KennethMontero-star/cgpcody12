namespace Duty_After_Coding
{
    partial class loadingscreen
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
            components = new System.ComponentModel.Container();
            Loading = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // Loading
            // 
            Loading.AutoSize = true;
            Loading.BackColor = Color.DarkSlateGray;
            Loading.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Loading.ForeColor = Color.GreenYellow;
            Loading.Location = new Point(380, 339);
            Loading.Name = "Loading";
            Loading.Size = new Size(148, 37);
            Loading.TabIndex = 0;
            Loading.Text = "Loading";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 20;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Interval = 50;
            timer3.Tick += timer3_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Location = new Point(302, 393);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 25);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 128);
            panel2.Location = new Point(303, 394);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 24);
            panel2.TabIndex = 2;
            // 
            // loadingscreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loadingimage3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(988, 547);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Loading);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "loadingscreen";
            Text = "loadingscreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Loading;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Panel panel1;
        private Panel panel2;
    }
}