namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int etiketFiyati;
        double indirimli;
        private void button3_Click(object sender, EventArgs e)
        {
            etiketFiyati = Convert.ToInt32(textBox1.Text);
            indirimli = etiketFiyati - (etiketFiyati * 0.50);
            label3.Text = indirimli.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            etiketFiyati = Convert.ToInt32(textBox1.Text);
            indirimli = etiketFiyati - (etiketFiyati * 0.1);
            label1.Text = indirimli.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            etiketFiyati = Convert.ToInt32(textBox1.Text);
            indirimli = etiketFiyati - (etiketFiyati * 0.2);
            label2.Text = indirimli.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            etiketFiyati = Convert.ToInt32(textBox1.Text);
            indirimli = etiketFiyati - (etiketFiyati * 0.9);
            label4.Text = indirimli.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
