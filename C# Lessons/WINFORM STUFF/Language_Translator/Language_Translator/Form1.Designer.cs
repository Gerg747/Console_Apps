namespace Language_Translator
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
            araBtn = new MaterialSkin.Controls.MaterialButton();
            spaBtn = new MaterialSkin.Controls.MaterialButton();
            gerBtn = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            languageBox = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // araBtn
            // 
            araBtn.AutoSize = false;
            araBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            araBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            araBtn.Depth = 0;
            araBtn.HighEmphasis = true;
            araBtn.Icon = null;
            araBtn.Location = new Point(25, 126);
            araBtn.Margin = new Padding(4, 6, 4, 6);
            araBtn.MouseState = MaterialSkin.MouseState.HOVER;
            araBtn.Name = "araBtn";
            araBtn.NoAccentTextColor = Color.Empty;
            araBtn.Size = new Size(101, 36);
            araBtn.TabIndex = 0;
            araBtn.Text = "Arabic";
            araBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            araBtn.UseAccentColor = false;
            araBtn.UseVisualStyleBackColor = true;
            araBtn.Click += araBtn_Click;
            // 
            // spaBtn
            // 
            spaBtn.AutoSize = false;
            spaBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            spaBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            spaBtn.Depth = 0;
            spaBtn.HighEmphasis = true;
            spaBtn.Icon = null;
            spaBtn.Location = new Point(155, 126);
            spaBtn.Margin = new Padding(4, 6, 4, 6);
            spaBtn.MouseState = MaterialSkin.MouseState.HOVER;
            spaBtn.Name = "spaBtn";
            spaBtn.NoAccentTextColor = Color.Empty;
            spaBtn.Size = new Size(101, 36);
            spaBtn.TabIndex = 1;
            spaBtn.Text = "Spanish";
            spaBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            spaBtn.UseAccentColor = false;
            spaBtn.UseVisualStyleBackColor = true;
            spaBtn.Click += spaBtn_Click;
            // 
            // gerBtn
            // 
            gerBtn.AutoSize = false;
            gerBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gerBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            gerBtn.Depth = 0;
            gerBtn.HighEmphasis = true;
            gerBtn.Icon = null;
            gerBtn.Location = new Point(290, 126);
            gerBtn.Margin = new Padding(4, 6, 4, 6);
            gerBtn.MouseState = MaterialSkin.MouseState.HOVER;
            gerBtn.Name = "gerBtn";
            gerBtn.NoAccentTextColor = Color.Empty;
            gerBtn.Size = new Size(101, 36);
            gerBtn.TabIndex = 2;
            gerBtn.Text = "German";
            gerBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            gerBtn.UseAccentColor = false;
            gerBtn.UseVisualStyleBackColor = true;
            gerBtn.Click += gerBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 22);
            label1.Name = "label1";
            label1.Size = new Size(394, 21);
            label1.TabIndex = 4;
            label1.Text = "Select A Language, I will say \"Good Morning\" in it.";
            // 
            // languageBox
            // 
            languageBox.BorderStyle = BorderStyle.FixedSingle;
            languageBox.Depth = 0;
            languageBox.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            languageBox.Location = new Point(60, 67);
            languageBox.MouseState = MaterialSkin.MouseState.HOVER;
            languageBox.Name = "languageBox";
            languageBox.Size = new Size(288, 39);
            languageBox.TabIndex = 5;
            languageBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 179);
            Controls.Add(languageBox);
            Controls.Add(label1);
            Controls.Add(gerBtn);
            Controls.Add(spaBtn);
            Controls.Add(araBtn);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Language Translator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton araBtn;
        private MaterialSkin.Controls.MaterialButton spaBtn;
        private MaterialSkin.Controls.MaterialButton gerBtn;
        private Label label1;
        private MaterialSkin.Controls.MaterialLabel languageBox;
    }
}