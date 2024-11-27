namespace WinFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ucret = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string adSoyad = textBox1.Text;
            string tel = textBox2.Text;
            string adres = richTextBox1.Text;
            string pizzaBilgi = comboBox1.Text + " x " + numericUpDown1.Value;
            string icecekBilgi = comboBox2.Text + " x " + numericUpDown2.Value;

            ucret = (comboBox1.SelectedIndex * 15 * (int)numericUpDown1.Value) + (comboBox2.SelectedIndex * 15 * (int)numericUpDown2.Value);
            string ekstralar = "";
            foreach (CheckBox c in groupBox1.Controls.OfType<CheckBox>())
            {
                if (c.Checked)
                {
                    ekstralar += " " + c.Text;
                    ucret += 10;
                }
            }
            listBox1.Items.Add(adSoyad);
            listBox2.Items.Add(tel);
            listBox3.Items.Add(adres);
            listBox4.Items.Add(pizzaBilgi);
            listBox5.Items.Add(ekstralar);
            listBox6.Items.Add(icecekBilgi);
            listBox7.Items.Add(ucret);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();



        }
    }
}
