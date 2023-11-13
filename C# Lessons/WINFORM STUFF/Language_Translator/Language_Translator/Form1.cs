namespace Language_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            languageBox.Text = "صباح الخير";
        }

        private void spaBtn_Click(object sender, EventArgs e)
        {
            languageBox.Text = "Buenos días";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void gerBtn_Click(object sender, EventArgs e)
        {
            languageBox.Text = "Guten Morgen";
        }
    }
}