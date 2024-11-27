namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("bo� de�er b�rakt�n");
            }
            MessageBox.Show(
                Convert.ToString(
                    Math.Pow(Convert.ToDouble(textBox2.Text), 2) - 4 * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox3.Text)
                ));
            
   

            listBox1.Items.Add("Delta: " + Convert.ToString(Math.Pow(Convert.ToDouble(textBox2.Text), 2)
                - 4 * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox3.Text)));
            double delta = Math.Pow(Convert.ToDouble(textBox2.Text), 2) - 4 * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox3.Text);

            if (delta > 0)
            {
                MessageBox.Show("k�k var, 2 tane");
                double kok1 = (-Convert.ToDouble(textBox2.Text) + Math.Sqrt(delta)) / 2 * Convert.ToDouble(textBox1.Text);
                double kok2 = (-Convert.ToDouble(textBox2.Text) - Math.Sqrt(delta)) / 2 * Convert.ToDouble(textBox1.Text);
                listBox1.Items.Add("K�k1: " + Convert.ToString(kok1) + "K�k 2" + Convert.ToString(kok2));
            }
            else if (delta < 0)
            {
                MessageBox.Show("K�kleri namevcuttur.");
            }
            else {
                MessageBox.Show("�ift k�k");
                double kok2 = (-Convert.ToDouble(textBox2.Text) - Math.Sqrt(delta)) / 2 * Convert.ToDouble(textBox1.Text);
                listBox1.Items.Add( "K�k:" + Convert.ToString(kok2));
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
