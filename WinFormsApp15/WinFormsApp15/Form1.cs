namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kalan1 = 100;
        private void button1_Click(object sender, EventArgs e)
        {
            bool alis = radioButton1.Checked;
            int adet = Convert.ToInt32(textBox1.Text);
            string stokKodu = comboBox1.Text;
            if (alis)
            {
                kalan1 += adet;
                listView1.Items.Add(stokKodu+": "+ adet);
                
            }
            label1.Text = "Kalan: " + kalan1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Stok Kodu", 100);
            listView1.Columns.Add("Ýþlem Türü", 100);
            listView1.Columns.Add("Miktar", 100);
            listView1.Columns.Add("Fiyat", 100);
        }
    }
}
