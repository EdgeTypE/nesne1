namespace WinFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan gunFarki = dateTimePicker1.Value - dateTimePicker2.Value;
            DateTime gun1 = dateTimePicker1.Value;
            DateTime gun2 = dateTimePicker2.Value;
            int gun = gunFarki.Days + 1;
            textBox1.Text = gun.ToString();

            int fiyat = 0;
            while (gun1 <= gun2)
            {
                if (gun1.DayOfWeek == DayOfWeek.Friday || gun1.DayOfWeek == DayOfWeek.Saturday)
                {
                    fiyat += 120;
                }
                else
                {
                    fiyat += 250;
                }
                gun1 = gun1.AddDays(1);
            }

            textBox2.Text = fiyat.ToString();
            textBox3.Text = (fiyat / gun).ToString();
        }

    }
}
