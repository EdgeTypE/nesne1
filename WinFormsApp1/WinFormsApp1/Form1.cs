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
                MessageBox.Show("boþ deðer býraktýn");
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
                MessageBox.Show("kök var, 2 tane");
                double kok1 = (-Convert.ToDouble(textBox2.Text) + Math.Sqrt(delta)) / 2 * Convert.ToDouble(textBox1.Text);
                double kok2 = (-Convert.ToDouble(textBox2.Text) - Math.Sqrt(delta)) / 2 * Convert.ToDouble(textBox1.Text);
                listBox1.Items.Add("Kök1: " + Convert.ToString(kok1) + "Kök 2" + Convert.ToString(kok2));
            }
            else if (delta < 0)
            {
                MessageBox.Show("Kökleri namevcuttur.");
            }
            else {
                MessageBox.Show("Çift kök");
                double kok2 = (-Convert.ToDouble(textBox2.Text) - Math.Sqrt(delta)) / 2 * Convert.ToDouble(textBox1.Text);
                listBox1.Items.Add( "Kök:" + Convert.ToString(kok2));
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
