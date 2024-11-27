using System.Windows.Forms.VisualStyles;

namespace WinFormsApp10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            
            MessageBox.Show(Form1.kisiselBilgi);
            label1.Text = Form1.kisiselBilgi;

        }
        private static int tutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tutar += 100;
                listBox1.Items.Add(checkBox1.Text);
            }
            if (checkBox2.Checked)
            {
                tutar += 200;
                listBox1.Items.Add(checkBox2.Text);
            }
            if (checkBox3.Checked)
            {
                tutar += 300;
                listBox1.Items.Add(checkBox3.Text);
            }
            if (checkBox4.Checked)
            {
                tutar += 400;
                listBox1.Items.Add(checkBox4.Text);
            }
            label3.Text = tutar.ToString();
            richTextBox1.Text = Form1.kisiselBilgi;
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
