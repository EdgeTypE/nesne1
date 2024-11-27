namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            int rastgeleSayi = random.Next(1, 10);
            listBox1.Items.Add(rastgeleSayi);
            label1.ForeColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rastgeleSayi = random.Next(10, 99);
            listBox2.Items.Add(rastgeleSayi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rastgeleSayi = random.Next(100, 999);
            listBox3.Items.Add(rastgeleSayi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rastgeleSayi = random.Next(1000, 9999);
            listBox4.Items.Add(rastgeleSayi);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int rastgeleSayi = random.Next(10000, 99999);
            listBox5.Items.Add(rastgeleSayi);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
