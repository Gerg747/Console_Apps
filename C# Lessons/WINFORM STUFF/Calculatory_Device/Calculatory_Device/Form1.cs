namespace Calculatory_Device
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string option;
        string Total;
        double num1;
        double num2;
        double Result;
        private void btn1_Click_1(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "0";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Display.Clear();
            Result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(Display.Text);

            Display.Clear();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(Display.Text);

            Display.Clear();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(Display.Text);

            Display.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(Display.Text);

            Display.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(Display.Text);

            if (option == "+")
            {
                Result = num1 + num2;
            }
            else if (option == "-")
            {
                Result = num1 - num2;
            }
            else if (option == "*")
            {
                Result = num1 * num2;
            }
            else if (option == "/")
            {
                Result = num1 / num2;
            }
            Display.Text = Result + "";
        }

        private void btnnegative_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "-";
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + ".";
        }

        private void btnonecl_Click(object sender, EventArgs e)
        {
            if (Display.Text != string.Empty)
            {
                int txtlength = Display.Text.Length;
                if (txtlength != 1)
                {
                    Display.Text = Display.Text.Remove(txtlength - 1);
                }
                else
                {
                    Display.Text = "";
                }
            }
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            Button[] buttons = { btn1, btn2, btn3, btn4, btn5, btn6, btn7 };

            if (BackColor != Color.Black) 
            { 
                BackColor = Color.Black; ForeColor = ColorTranslator.FromHtml("#ffffff");

                Display.BackColor = Color.Black;
                Display.ForeColor = ColorTranslator.FromHtml("#ffffff");

                btn1.BackColor = Color.Black;
                btn2.BackColor = Color.Black;
                btn3.BackColor = Color.Black;
                btn4.BackColor = Color.Black;
                btn5.BackColor = Color.Black;
                btn6.BackColor = Color.Black;
                btn7.BackColor = Color.Black;
                btn8.BackColor = Color.Black;
                btn9.BackColor = Color.Black;
                btn0.BackColor = Color.Black;
                btnonecl.BackColor = Color.Black;
                btnclear.BackColor = Color.Black;
                btnplus.BackColor = Color.Black;
                btnminus.BackColor = Color.Black;
                btnmultiply.BackColor = Color.Black;
                btndivide.BackColor = Color.Black;
                btnDouble.BackColor = Color.Black;
                btnnegative.BackColor = Color.Black;
                btnEquals.BackColor = Color.Black;
            }
            else 
            { 
                BackColor = ColorTranslator.FromHtml("#ffffff"); ForeColor = ColorTranslator.FromHtml("#000000");
                Display.BackColor = ColorTranslator.FromHtml("#ffffff");
                Display.ForeColor = Color.Black;
                btn1.BackColor = ColorTranslator.FromHtml("#ffffff");
                btn2.BackColor = ColorTranslator.FromHtml("#ffffff");
                btn3.BackColor = ColorTranslator.FromHtml("#ffffff");
                btn4.BackColor = ColorTranslator.FromHtml("#ffffff");
                btn5.BackColor = ColorTranslator.FromHtml("#ffffff");
                btn6.BackColor = ColorTranslator.FromHtml("#ffffff");
                btn7.BackColor = ColorTranslator.FromHtml("#ffffff");
                btn8.BackColor = ColorTranslator.FromHtml("#ffffff");
                btn9.BackColor = ColorTranslator.FromHtml("#ffffff");
                btn0.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnonecl.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnclear.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnplus.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnminus.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnmultiply.BackColor = ColorTranslator.FromHtml("#ffffff");
                btndivide.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnDouble.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnnegative.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnEquals.BackColor = ColorTranslator.FromHtml("#ffffff");
            }
        }
    }
}