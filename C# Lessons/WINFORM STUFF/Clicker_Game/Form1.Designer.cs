namespace Clicker_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            cookie = new Label();
            count = new Label();
            richness = new Label();
            Upgrade1 = new Button();
            cps = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            Upgrade2 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(169, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 295);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cookie
            // 
            cookie.AutoSize = true;
            cookie.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cookie.Location = new Point(313, 367);
            cookie.Name = "cookie";
            cookie.Size = new Size(95, 21);
            cookie.TabIndex = 1;
            cookie.Text = "Click Here!";
            // 
            // count
            // 
            count.AutoSize = true;
            count.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            count.Location = new Point(248, 10);
            count.Name = "count";
            count.Size = new Size(35, 39);
            count.TabIndex = 2;
            count.Text = "0";
            // 
            // richness
            // 
            richness.AutoSize = true;
            richness.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            richness.Location = new Point(336, 10);
            richness.Name = "richness";
            richness.Size = new Size(132, 39);
            richness.TabIndex = 3;
            richness.Text = "Cookies";
            // 
            // Upgrade1
            // 
            Upgrade1.Location = new Point(86, 423);
            Upgrade1.Name = "Upgrade1";
            Upgrade1.Size = new Size(162, 73);
            Upgrade1.TabIndex = 4;
            Upgrade1.Text = "-Click Upgrade-\r\nCost: 30 Cookies.\r\nIncreases Cookies per click\r\nto 2.\r\n";
            Upgrade1.UseVisualStyleBackColor = true;
            Upgrade1.Click += Upgrade1_Click;
            // 
            // cps
            // 
            cps.Interval = 1000;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Upgrade2
            // 
            Upgrade2.Location = new Point(458, 423);
            Upgrade2.Name = "Upgrade2";
            Upgrade2.Size = new Size(175, 73);
            Upgrade2.TabIndex = 5;
            Upgrade2.Text = "-CPS Upgrade-\r\nCost: 50 Cookies.\r\nIncreases Cookies per Second\r\nto 1.\r\n";
            Upgrade2.UseVisualStyleBackColor = true;
            Upgrade2.Click += Upgrade2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 508);
            Controls.Add(Upgrade2);
            Controls.Add(Upgrade1);
            Controls.Add(richness);
            Controls.Add(count);
            Controls.Add(cookie);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label cookie;
        private Label count;
        private Label richness;
        private Button Upgrade1;
        private System.Windows.Forms.Timer cps;
        private System.Windows.Forms.Timer timer1;
        private Button Upgrade2;
        private System.Windows.Forms.Timer timer2;
    }
}