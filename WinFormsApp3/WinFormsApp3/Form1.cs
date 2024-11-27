namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dogru = 0;
            int yanlis = 0;

            if (radioButton1.Checked == true)
            {
                dogru = dogru + 1;
            }
            else { yanlis = yanlis + 1; }

            if (radioButton2.Checked == true)
            {
                dogru = dogru + 1;
            }
            else { yanlis = yanlis + 1; }

            if (radioButton8.Checked == true)
            {
                dogru = dogru + 1;
            }
            else { yanlis = yanlis + 1; }

            if (radioButton12.Checked == true)
            {
                dogru = dogru + 1;
            }
            else { yanlis = yanlis + 1; }

            if (radioButton16.Checked == true)
            {
                dogru = dogru + 1;
            }
            else { yanlis = yanlis + 1; }

            if (radioButton20.Checked == true)
            {
                dogru = dogru + 1;
            }
            else { yanlis = yanlis + 1; }

            textBox1.Text = Convert.ToString(dogru);
            textBox2.Text = Convert.ToString(yanlis);
            textBox3.Text = Convert.ToString((double)dogru / yanlis);
            
        }
    }
}
