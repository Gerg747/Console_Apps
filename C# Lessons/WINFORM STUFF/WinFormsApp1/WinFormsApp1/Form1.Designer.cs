namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Upgrade2 = new Button();
            Upgrade1 = new Button();
            richness = new Label();
            count = new Label();
            cookie = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            // 
            // Upgrade2
            // 
            Upgrade2.Location = new Point(438, 415);
            Upgrade2.Name = "Upgrade2";
            Upgrade2.Size = new Size(175, 73);
            Upgrade2.TabIndex = 11;
            Upgrade2.Text = "-CPS Upgrade-\r\nCost: 50 Cookies.\r\nIncreases Cookies per Second\r\nto 1.\r\n";
            Upgrade2.UseVisualStyleBackColor = true;
            // 
            // Upgrade1
            // 
            Upgrade1.Location = new Point(96, 415);
            Upgrade1.Name = "Upgrade1";
            Upgrade1.Size = new Size(162, 73);
            Upgrade1.TabIndex = 10;
            Upgrade1.Text = "-Click Upgrade-\r\nCost: 30 Cookies.\r\nIncreases Cookies per click\r\nto 2.\r\n";
            Upgrade1.UseVisualStyleBackColor = true;
            // 
            // richness
            // 
            richness.AutoSize = true;
            richness.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            richness.Location = new Point(329, 32);
            richness.Name = "richness";
            richness.Size = new Size(132, 39);
            richness.TabIndex = 9;
            richness.Text = "Cookies";
            // 
            // count
            // 
            count.AutoSize = true;
            count.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            count.Location = new Point(261, 32);
            count.Name = "count";
            count.Size = new Size(35, 39);
            count.TabIndex = 8;
            count.Text = "0";
            // 
            // cookie
            // 
            cookie.AutoSize = true;
            cookie.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cookie.Location = new Point(311, 399);
            cookie.Name = "cookie";
            cookie.Size = new Size(95, 21);
            cookie.TabIndex = 7;
            cookie.Text = "Click Here!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(173, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 500);
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

        private Button Upgrade2;
        private Button Upgrade1;
        private Label richness;
        private Label count;
        private Label cookie;
        private PictureBox pictureBox1;
    }
}