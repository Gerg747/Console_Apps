namespace Calculatory_Device
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
            btnplus = new Button();
            btnminus = new Button();
            btnmultiply = new Button();
            btndivide = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btnclear = new Button();
            btnEquals = new Button();
            btn7 = new Button();
            btn8 = new Button();
            Display = new TextBox();
            btnnegative = new Button();
            btnDouble = new Button();
            btnonecl = new Button();
            btn1 = new Button();
            materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            SuspendLayout();
            // 
            // btnplus
            // 
            btnplus.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnplus.Location = new Point(226, 121);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(65, 55);
            btnplus.TabIndex = 34;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += btnplus_Click;
            // 
            // btnminus
            // 
            btnminus.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnminus.Location = new Point(226, 182);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(65, 55);
            btnminus.TabIndex = 33;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            btnminus.Click += btnminus_Click;
            // 
            // btnmultiply
            // 
            btnmultiply.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnmultiply.Location = new Point(226, 243);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(65, 55);
            btnmultiply.TabIndex = 32;
            btnmultiply.Text = "x";
            btnmultiply.UseVisualStyleBackColor = true;
            btnmultiply.Click += btnmultiply_Click;
            // 
            // btndivide
            // 
            btndivide.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btndivide.Location = new Point(226, 304);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(65, 55);
            btndivide.TabIndex = 31;
            btndivide.Text = "÷";
            btndivide.UseVisualStyleBackColor = true;
            btndivide.Click += btndivide_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(12, 304);
            btn0.Name = "btn0";
            btn0.Size = new Size(65, 55);
            btn0.TabIndex = 30;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(155, 243);
            btn9.Name = "btn9";
            btn9.Size = new Size(65, 55);
            btn9.TabIndex = 29;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(155, 182);
            btn6.Name = "btn6";
            btn6.Size = new Size(65, 55);
            btn6.TabIndex = 28;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(83, 121);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 55);
            btn2.TabIndex = 27;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(154, 121);
            btn3.Name = "btn3";
            btn3.Size = new Size(66, 55);
            btn3.TabIndex = 26;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(12, 182);
            btn4.Name = "btn4";
            btn4.Size = new Size(65, 55);
            btn4.TabIndex = 25;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(83, 182);
            btn5.Name = "btn5";
            btn5.Size = new Size(65, 55);
            btn5.TabIndex = 24;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnclear.Location = new Point(297, 182);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(65, 55);
            btnclear.TabIndex = 23;
            btnclear.Text = "C";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.Location = new Point(297, 243);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(65, 116);
            btnEquals.TabIndex = 22;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(12, 243);
            btn7.Name = "btn7";
            btn7.Size = new Size(65, 55);
            btn7.TabIndex = 21;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(83, 243);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 55);
            btn8.TabIndex = 20;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // Display
            // 
            Display.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Display.Location = new Point(12, 12);
            Display.Multiline = true;
            Display.Name = "Display";
            Display.ReadOnly = true;
            Display.Size = new Size(350, 65);
            Display.TabIndex = 18;
            // 
            // btnnegative
            // 
            btnnegative.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnnegative.Location = new Point(83, 304);
            btnnegative.Name = "btnnegative";
            btnnegative.Size = new Size(65, 55);
            btnnegative.TabIndex = 35;
            btnnegative.Text = "(-)";
            btnnegative.UseVisualStyleBackColor = true;
            btnnegative.Click += btnnegative_Click;
            // 
            // btnDouble
            // 
            btnDouble.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDouble.Location = new Point(155, 304);
            btnDouble.Name = "btnDouble";
            btnDouble.Size = new Size(65, 55);
            btnDouble.TabIndex = 36;
            btnDouble.Text = ".";
            btnDouble.UseVisualStyleBackColor = true;
            btnDouble.Click += btnDouble_Click;
            // 
            // btnonecl
            // 
            btnonecl.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnonecl.Location = new Point(297, 121);
            btnonecl.Name = "btnonecl";
            btnonecl.Size = new Size(65, 55);
            btnonecl.TabIndex = 37;
            btnonecl.Text = "CE";
            btnonecl.UseVisualStyleBackColor = true;
            btnonecl.Click += btnonecl_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(12, 121);
            btn1.Name = "btn1";
            btn1.Size = new Size(65, 55);
            btn1.TabIndex = 38;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click_1;
            // 
            // materialSwitch1
            // 
            materialSwitch1.AutoSize = true;
            materialSwitch1.Depth = 0;
            materialSwitch1.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            materialSwitch1.ForeColor = SystemColors.ControlText;
            materialSwitch1.Location = new Point(13, 81);
            materialSwitch1.Margin = new Padding(0);
            materialSwitch1.MouseLocation = new Point(-1, -1);
            materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSwitch1.Name = "materialSwitch1";
            materialSwitch1.Ripple = true;
            materialSwitch1.Size = new Size(135, 37);
            materialSwitch1.TabIndex = 39;
            materialSwitch1.Text = "Dark Mode";
            materialSwitch1.UseVisualStyleBackColor = true;
            materialSwitch1.CheckedChanged += materialSwitch1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 371);
            Controls.Add(materialSwitch1);
            Controls.Add(btn1);
            Controls.Add(btnonecl);
            Controls.Add(btnDouble);
            Controls.Add(btnnegative);
            Controls.Add(btnplus);
            Controls.Add(btnminus);
            Controls.Add(btnmultiply);
            Controls.Add(btndivide);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btnclear);
            Controls.Add(btnEquals);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(Display);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnplus;
        private Button btnminus;
        private Button btnmultiply;
        private Button btndivide;
        private Button btn0;
        private Button btn9;
        private Button btn6;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btnclear;
        private Button btnEquals;
        private Button btn7;
        private Button btn8;
        private TextBox Display;
        private Button btnnegative;
        private Button btnDouble;
        private Button btnonecl;
        private Button btn1;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
    }
}