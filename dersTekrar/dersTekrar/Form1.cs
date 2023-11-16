namespace dersTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pers= new Personel(adTxt.Text, adresTxt.Text, Convert.ToInt32(yasTxt.Text),Convert.ToInt32(mesaiTxt.Text), comboBox1.Text );//Yapýcý metod ile tek satýrda gönderiyoruz.

            if (string.IsNullOrEmpty(adTxt.Text))
            {
                MessageBox.Show("Ad Soyad Boþ Býrakýlamaz!");
            }
            else if (string.IsNullOrEmpty(adresTxt.Text))
            {
                MessageBox.Show("Adres Boþ Býrakýlamaz!");
            }
            else if (string.IsNullOrEmpty(mesaiTxt.Text))
            {
                MessageBox.Show("Mesai Boþ Býrakýlamaz!");
            }
            else if (string.IsNullOrEmpty(yasTxt.Text))
            {
                MessageBox.Show("Yaþ Boþ Býrakýlamaz!");
            }
            else if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Bir Ünvan Seçiniz!");
            }

            


            if (comboBox1.Text == "Ýþçi")
            {
                MessageBox.Show(pers.ucretHesapla().ToString());
            }
            else
                {
                        pers.ucretHesapla(1000);
                }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ýþçi");
            comboBox1.Items.Add("Mühendis");
            cmb2Cmbx.Items.Add("Ýþçi");
            cmb2Cmbx.Items.Add("Mühendis");
            cmb3Cmbx.Items.Add("Ýþçi");
            turCmbx3.Items.Add("Gündelik");
            turCmbx3.Items.Add("maaþlý eleman");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            muhendis muh = new muhendis();
            muh.Ad = ad2Txt.Text;
            muh.Adres = adres2Txt.Text;
            muh.Unvan = cmb2Cmbx.Text;
            muh.Birim = birimCmbx.Text;
            muh.Yas = Convert.ToInt32(yas2Txt.Text);
            muh.Mesai = Convert.ToInt32(mesai2Txt.Text);
            muh.ucretHesapla();
            MessageBox.Show(muh.ucretHesapla().ToString());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb2Cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            isci iscim = new isci(ad3Txt.Text, adres3Txt.Text, yas3Txt.Text, cmb3Cmbx.Text, turCmbx3.Text, mesai3Txt.Text);
            MessageBox.Show(iscim.ucretHesapla().ToString());
        }
    }
}