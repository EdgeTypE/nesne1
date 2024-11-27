namespace WinFormsApp5
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
            bool asal = true;
            for (int i = 2; i < sayi-1; i++) {
                if (sayi%i == 0)
                {
                    asal = false;
                    
                }


            }
            if (asal==true)
            {
                MessageBox.Show(sayi + " asaldýr.");
            } else { MessageBox.Show(sayi + "'nýn asal sayýlar listesindeki mevcudiyeti namevcuttur."); }
        }
    }
}
