using System;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random2 = new Random();
            Color randomcolor = Color.FromArgb(random2.Next(256), random2.Next(256), random2.Next(256));
            this.BackColor = randomcolor;
            while (true)
            {
                this.BackColor = randomcolor;

            }
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    this.BackColor = Color.Red;
                    break;
                case 1:
                    this.BackColor = Color.Green;
                    break;
                case 2:
                    this.BackColor= Color.Blue;
                    break;
            }
        }
    }
}
