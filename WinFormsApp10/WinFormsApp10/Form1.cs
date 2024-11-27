namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string kisiselBilgi = "";
        private void button1_Click(object sender, EventArgs e)
        {
            kisiselBilgi = "Ad: " + textBox1.Text + "\nSoyad: " + textBox2.Text + "\nTC: " + textBox3.Text + "\nAdres" + richTextBox1.Text;

            Form2 form2 = new Form2();

            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
