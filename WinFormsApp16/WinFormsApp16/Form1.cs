namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int input1 = 0;
        int input2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToInt32(textBox1.Text);
            input2 = Convert.ToInt32(textBox2.Text);
            label22.Text = Convert.ToString(input1 * input2);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToInt32(textBox3.Text);
            input2 = Convert.ToInt32(textBox4.Text);
            label23.Text = Convert.ToString(input1 / input2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToInt32(textBox5.Text);
            input2 = Convert.ToInt32(textBox6.Text);
            label24.Text = Convert.ToString(input1 / input2);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
