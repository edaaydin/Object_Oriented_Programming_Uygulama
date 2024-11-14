namespace _02_Encapsulation_Ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Personel personel = new Personel()
                {
                    Ad = textBox1.Text,
                    Soyad = textBox2.Text,
                    Tc = textBox3.Text
                };

                ListViewItem kayit = new ListViewItem(personel.Tc);
                kayit.Text = personel.Tc;
                kayit.SubItems.Add(personel.Ad);
                kayit.SubItems.Add(personel.Soyad);


                listView1.Items.Add(kayit);
                Temizle();
            }
            catch (Exception ex) // set kontolunde hata alırsan, buraya dus.
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Temizle()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox) ((TextBox)item).Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) // Gercekten birini sectiyse sil.
            {
                listView1.Items.Remove
                    (listView1.SelectedItems[0]);
            }
        }
    }
}
/*
Personel Class icin

- Adý set ederken ilk harfi buyuk olsun.
- Soyadýn ilk iki hanesi buyuk olsun hem de soyadýn buyuk harflerinden sonra geri kalanýný * yapsýn ve listwiev da öyle gozuksun.
- TC icin 11 karakter ve rakan kontrolunun yani sira listwievda son 2 karakter gozuksun ve oncesi * gozuksun yani listwiev da bu sekilde gozukmeli.
*/
