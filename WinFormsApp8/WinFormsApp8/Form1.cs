namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Hide();
            groupBox4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textContent = textBox1.Text + "\n"+  textBox2.Text + "\n" + textBox3.Text;
            string groupBoxContent = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text + "\n" + groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text + "\n";
            string hobiler = "";
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                hobiler += checkedListBox1.Items[indexChecked].ToString() + "\n";
            }
            label5.Show();
            groupBox4.Show();



            label5.Text = textContent + "\n" + groupBoxContent + "\n" + hobiler;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
