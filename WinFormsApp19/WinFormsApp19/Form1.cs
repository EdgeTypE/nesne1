namespace WinFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> koltukAd = new List<string>();
        List<string> koltukNoList = new List<string>();
        List<string> tumKoltuklar = new List<string>();

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sa");
            string isim = textBox1.Text;
            koltukAd.Add(isim);
            koltukNoList.Add(koltukNo);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(koltukNoList.ToArray());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int count1 = 1;
            foreach (Button b in groupBox1.Controls.OfType<Button>())
            {
                b.Text = count1.ToString();
                tumKoltuklar.Add(count1.ToString());
                count1++;

            }

            foreach (Control control in groupBox1.Controls)
            {
                if (control is Button button)
                {
                    button.Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                koltuk(clickedButton.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            koltuk(button1.Text.ToString());
        }
        string koltukNo = "0";
        private void koltuk(string v)
        {
            textBox2.Text = v;
            koltukNo = v;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(koltukAd.ToArray());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(koltukNoList.ToArray());
        }
    }
}
