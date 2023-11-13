namespace Clicker_Game
{
    public partial class Form1 : Form
    {
        int cookies = 0;
        int Upgrade1Level = 1;
        int Upgrade2Level = 1;

        public Form1()
        {
            InitializeComponent();
            count.Text = cookies.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (Upgrade1Level == 1)
            {
                cookies++;
                count.Text = cookies.ToString();
            }
            else if (Upgrade1Level == 2)
            {
                cookies += 2;
                count.Text = cookies.ToString();
            }
            else if (Upgrade1Level == 3)
            {
                cookies += 4;
                count.Text = cookies.ToString();
            }
            else if (Upgrade1Level == 4)
            {
                cookies += 10;
                count.Text = cookies.ToString();
            }
            else
            {
                cookies += 25;
                count.Text = cookies.ToString();
            }
        }

        private void Upgrade1_Click(object sender, EventArgs e)
        {
            if (Upgrade1Level == 1 && cookies >= 30)
            {
                cookies -= 30;
                Upgrade1Level++;
                Upgrade1.Text = "-Click Upgrade-\r\nCost: 100 Cookies.\r\nIncreases Cookies per click\r\nto 4.\r\n";
                count.Text = cookies.ToString();
            }
            else if (Upgrade1Level == 2 && cookies >= 100)
            {
                cookies -= 100;
                Upgrade1Level++;
                Upgrade1.Text = "-Click Upgrade-\r\nCost: 205 Cookies.\r\nIncreases Cookies per click\r\nto 10.\r\n";
                count.Text = cookies.ToString();
            }
            else if (Upgrade1Level == 3 && cookies >= 205)
            {
                cookies -= 205;
                Upgrade1Level++;
                Upgrade1.Text = "-Click Upgrade-\r\nCost: 500 Cookies.\r\nIncreases Cookies per click\r\nto 25.\r\n";
                count.Text = cookies.ToString();
            }
            else if (Upgrade1Level == 4 && cookies >= 500)
            {
                cookies -= 500;
                Upgrade1Level++;
                Upgrade1.Text = "-Maxed Out-";
                count.Text = cookies.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Upgrade2Level == 2)
            {
                cookies++;
                count.Text = cookies.ToString();
            }
            else if (Upgrade2Level == 3)
            {
                cookies += 7;
                count.Text = cookies.ToString();
            }
            else if (Upgrade2Level == 4)
            {
                cookies += 20;
                count.Text = cookies.ToString();
            }
            else
            {
                cookies += 50;
                count.Text = cookies.ToString();
            }
        }

        private void Upgrade2_Click(object sender, EventArgs e)
        {
            if (Upgrade2Level == 1 && cookies >= 50)
            {
                cookies -= 50;
                Upgrade2Level++;
                Upgrade2.Text = "-CPS Upgrade-\r\nCost: 150 Cookies.\r\nIncreases Cookies per Second\r\nto 7.\r\n.";
                count.Text = cookies.ToString();
                timer1.Start();
            }
            else if (Upgrade2Level == 2 && cookies >= 150)
            {
                cookies -= 150;
                Upgrade2Level++;
                Upgrade2.Text = "-CPS Upgrade-\r\nCost: 450 Cookies.\r\nIncreases Cookies per Second\r\nto 20.\r\n.";
                count.Text = cookies.ToString();
            }
            else if (Upgrade2Level == 3 && cookies >= 450)
            {
                cookies -= 450;
                Upgrade2Level++;
                Upgrade2.Text = "-CPS Upgrade-\r\nCost: 1000 Cookies.\r\nIncreases Cookies per Second\r\nto 50.\r\n.";
                count.Text = cookies.ToString();
            }
            else if (Upgrade2Level == 4 && cookies >= 1000)
            {
                cookies -= 1000;
                Upgrade2Level++;
                Upgrade2.Text = "-Maxed Out-";
                count.Text = cookies.ToString();
            }
        }
    }
}