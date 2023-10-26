namespace homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Ýþçi");
            comboBox1.Items.Add("muhendis");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pers = new Personel
     (adTxt.Text, adresTxt.Text, comboBox1.Text, Convert.ToInt32(yasTxt.Text), Convert.ToInt32(mesaiTxt.Text));

            if (comboBox1.Text == "Ýþçi")

            {
                MessageBox.Show(pers.ucretHesapla().ToString());

            }
            else
            {
                pers.ucretHesapla(1000);
            }
        }
    }
}