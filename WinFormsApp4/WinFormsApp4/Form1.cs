namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1 = 0;
        int sayi2 = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            MessageBox.Show(sayi1.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sayi2 = Convert.ToInt32(textBox2.Text);
            MessageBox.Show(sayi2.ToString());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toplamaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text));
        }

        private void çýkartmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text));

        }

        private void çarpmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));

        }

        private void bölmeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));

        }
    }
}
