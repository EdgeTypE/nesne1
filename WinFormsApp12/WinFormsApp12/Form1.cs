namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int denemeSayisi = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if ((denemeSayisi < 3) && (textBox2.Text == "admin") && (textBox2.Text == "admin"))
            {
                pictureBox1.BackColor = Color.Green;
                Form form2 = new Form2();
                form2.Show();
                MessageBox.Show("Giri� Ba�ar�l� \n" + denemeSayisi + " seferde giri� yapt�n!!1!");
            }
            else
            {
                denemeSayisi++;
                pictureBox1.BackColor = Color.Red;
                MessageBox.Show("Giri� Ba�ar�s�z");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
