namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ogrNo, adsoyad, sinif;
            ogrNo = textBox1.Text;
            adsoyad = textBox2.Text;
            sinif = comboBox1.Text;
            MessageBox.Show(ogrNo + " " + adsoyad + " " + sinif);
            panel1.Show();

            label8.Text = ogrNo;
            label9.Text = adsoyad;
            label10.Text = sinif;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox3.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            groupBox1.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
        }
    }
}
