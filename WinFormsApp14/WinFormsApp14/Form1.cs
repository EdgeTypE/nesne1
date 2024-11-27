namespace WinFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string urun;
        public int fiyat;
        public int tutar = 0;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fiyat = 0;
            urun = listBox1.SelectedItem.ToString();
            switch (urun)
            {
                case "kalem":
                    fiyat = 5;
                    break;
                case "defter":
                    fiyat = 10;
                    break;
                case "silgi":
                    fiyat = 2;
                    break;
                case "kitap":
                    fiyat = 20;
                    break;
            }
            label5.Text = fiyat.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet = comboBox1.SelectedIndex+1;
            tutar += adet*fiyat;
            listBox2.Items.Add(urun + " " + adet + " adet " + fiyat + " TL");
            label6.Text = tutar.ToString();
        }
    }
}
