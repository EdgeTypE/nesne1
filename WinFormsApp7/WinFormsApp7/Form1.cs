namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            while (sayi != 0) {
                listBox1.Items.Add(sayi);
                if (sayi % 2 == 0)
                {
                    sayi /= 2;
                } else
                {
                    sayi = 3 * sayi + 1;
                }
                listBox1.Items.Add(sayi);
            }
        }
    }
}
