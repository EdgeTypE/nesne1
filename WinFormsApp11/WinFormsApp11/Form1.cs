namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool alanMi = false;
        public string shape = "daire";
        private void button1_Click(object sender, EventArgs e)
        {
            alanMi = radioButton1.Checked;
            if (radioButton3.Checked)
            {
                shape = "daire";
            }
            else if (radioButton4.Checked)
            {
                shape = "kare";
            }
            else if (radioButton5.Checked)
            {
                shape = "dikdörtgen";
            }
            int girdi = Convert.ToInt32(textBox1.Text);
            int girdi2;
            int h;
            if (textBox3.Text == "")
            {
                girdi2 = 0;
            } else {                 
                girdi2 = Convert.ToInt32(textBox3.Text);
                       }

            if (textBox4.Text == "")
            {
                h = 0;
            }
            else
            {
                h = Convert.ToInt32(textBox3.Text);
            }

            if (alanMi)
            {
                if (shape == "daire")
                {
                    textBox2.Text = (Math.PI * girdi * girdi).ToString();
                }
                else if (shape == "kare")
                {
                    textBox2.Text = (girdi * girdi).ToString();
                }
                else if (shape == "dikdörtgen")
                {
                    textBox2.Text = (girdi * girdi2).ToString();
                }
            }
            else
            {
                if (shape == "daire")
                {
                    textBox2.Text = (2 * Math.PI * girdi).ToString();
                }
                else if (shape == "kare")
                {
                    textBox2.Text = (girdi * girdi * h).ToString();
                }
                else if (shape == "dikdörtgen")
                {
                    textBox2.Text = (girdi * girdi2 * h).ToString();
                }
            }

            
        }
    }
}
