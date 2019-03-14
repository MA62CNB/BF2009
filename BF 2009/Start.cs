using System;
using System.Drawing;
using System.Windows.Forms;

namespace BF_2009
{
    public partial class Start : Form
    {
        public string isim, takim;
        public Color home, type;
        Form nfrm = new Form1();
                    
        public Start()
        {
            InitializeComponent();
        }

        private void nwgBut_Click(object sender, EventArgs e)
        {
            isim = ad.Text + " " + soyad.Text;
            try
            {
                takim = takimlar.SelectedItem.ToString();
                //Takim = radio button
                Form ngame = new Game(isim, takim, home, type);            
                ngame.Show();
                this.Dispose(false);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Lütfen bir takım seçin.", "Hata", MessageBoxButtons.OK);
            }
            
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            nfrm.Show();
        }

        private void takimlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (takimlar.SelectedIndex == 0)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1910";
                chair.Text = "Cengiz Topel Yıldırım";
                stad.Text = "On dokuz Mayıs, Ankara";
                fund.Text = "Berbat";
                ligsira.Text = "14";
                takimadi.BackColor = Color.Navy;
                takimadi.ForeColor = Color.Yellow;
                home = Color.Navy;
                type = Color.Yellow;
            }
            else if (takimlar.SelectedIndex == 1)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1978";
                chair.Text = "Ruhi Kurnaz";
                stad.Text = "Yenikent ASAŞ, Ankara";
                fund.Text = "Vasat";
                ligsira.Text = "9";
                takimadi.BackColor = Color.Blue;
                takimadi.ForeColor = Color.White;
                home = Color.Blue;
                type=Color.White;
            }
            else if (takimlar.SelectedIndex == 2)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1966";
                chair.Text = "Hasan Akıncıoğlu";
                stad.Text = "Atatürk, Antalya";
                fund.Text = "Berbat";
                ligsira.Text = "17";
                takimadi.BackColor = Color.Firebrick;
                takimadi.ForeColor = Color.White;
                home = Color.Red;
                type=Color.White;
            }
            else if (takimlar.SelectedIndex == 3)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1903";
                chair.Text = "Yıldırım Demirören";
                stad.Text = "Beşiktaş İnönü, İstanbul";
                fund.Text = "Vasat";
                ligsira.Text = "3";
                takimadi.BackColor = Color.Black;
                takimadi.ForeColor = Color.White;
                home = Color.Black;
                type=Color.White;
            }
            else if (takimlar.SelectedIndex == 4)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1963";
                chair.Text = "İbrahim Yazıcı";
                stad.Text = "Atatürk, Bursa";
                fund.Text = "Vasat";
                ligsira.Text = "6";
                takimadi.BackColor = Color.LimeGreen;
                takimadi.ForeColor = Color.White;
                home = Color.LimeGreen;
                type=Color.White;
            }
            else if (takimlar.SelectedIndex == 5)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1966";
                chair.Text = "Ali İpek";
                stad.Text = "Atatürk, Denizli";
                fund.Text = "Berbat";
                ligsira.Text = "18";
                takimadi.BackColor = Color.SpringGreen;
                takimadi.ForeColor = Color.Black;
                home = Color.SpringGreen;
                type=Color.Black;
            }
            else if (takimlar.SelectedIndex == 6)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1968";
                chair.Text = "Çetin Sümer";
                stad.Text = "Atatürk, Diyarbakır";
                fund.Text = "Feci";
                ligsira.Text = "15";
                takimadi.BackColor = Color.ForestGreen;
                takimadi.ForeColor = Color.Red;
                home = Color.ForestGreen;
                type=Color.Red;
            }
            else if (takimlar.SelectedIndex == 7)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1965";
                chair.Text = "Halil Ünal";
                stad.Text = "Atatürk, Eskişehir";
                fund.Text = "Berbat";
                ligsira.Text = "12";
                takimadi.BackColor = Color.Red;
                takimadi.ForeColor = Color.Black;
                home = Color.Red;
                type=Color.Black;
            }
            else if (takimlar.SelectedIndex == 8)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1907";
                chair.Text = "Aziz Yıldırım";
                stad.Text = "Şükrü Saraçoğlu, İstanbul";
                fund.Text = "Çok İyi";
                ligsira.Text = "2";
                takimadi.BackColor = Color.Yellow;
                takimadi.ForeColor = Color.Navy;
                home = Color.Yellow;
                type=Color.Navy;
            }
            else if (takimlar.SelectedIndex == 9)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1905";
                chair.Text = "Adnan Polat";
                stad.Text = "Ali Sami Yen, İstanbul";
                fund.Text = "Vasat";
                ligsira.Text = "1";
                takimadi.BackColor = Color.Gold;
                takimadi.ForeColor = Color.DarkRed;
                home = Color.Gold;
                type=Color.DarkRed;
            }
            else if (takimlar.SelectedIndex == 10)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1969";
                chair.Text = "İbrahim Kızıl";
                stad.Text = "Kamil Ocak, Gaziantep";
                fund.Text = "İyi";
                ligsira.Text = "8";
                takimadi.BackColor = Color.DarkRed;
                takimadi.ForeColor = Color.Black;
                home = Color.DarkRed;
                type=Color.Black;
            }
            else if (takimlar.SelectedIndex == 11)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1923";
                chair.Text = "İlhan Cavcav";
                stad.Text = "On dokuz Mayıs, Ankara";
                fund.Text = "İyi";
                ligsira.Text = "10";
                takimadi.BackColor = Color.Black;
                takimadi.ForeColor = Color.Red;
                home = Color.Black;
                type=Color.Red;
            }
            else if (takimlar.SelectedIndex == 12)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1990";
                chair.Text = "Göksel Gümüşdağ";
                stad.Text = "Atatürk Olimpiyat, İstanbul";
                fund.Text = "Berbat";
                ligsira.Text = "11";
                takimadi.BackColor = Color.Tomato;
                takimadi.ForeColor = Color.Blue;
                home = Color.Tomato;
                type=Color.Blue;
            }
            else if (takimlar.SelectedIndex == 13)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1921";
                chair.Text = "Hasan Hilmi Öksüz";
                stad.Text = "Recep Tayyip Erdoğan, İstanbul";
                fund.Text = "Berbat";
                ligsira.Text = "16";
                takimadi.BackColor = Color.MidnightBlue;
                takimadi.ForeColor = Color.White;
                home = Color.MidnightBlue;
                type=Color.White;
            }
            else if (takimlar.SelectedIndex == 14)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1965";
                chair.Text = "Recep Mamur";
                stad.Text = "Kadir Has, Kayseri";
                fund.Text = "Vasat";
                ligsira.Text = "7";
                takimadi.BackColor = Color.Red;
                takimadi.ForeColor = Color.Yellow;
                home = Color.Red;
                type=Color.Yellow;
            }
            else if (takimlar.SelectedIndex == 15)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1910";
                chair.Text = "Kenan Yaralı";
                stad.Text = "On dokuz Mayıs, Manisa";
                fund.Text = "Berbat";
                ligsira.Text = "13";
                takimadi.BackColor = Color.White;
                takimadi.ForeColor = Color.Black;
                home = Color.White;
                type=Color.Black;
            }
            else if (takimlar.SelectedIndex == 16)
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1965";
                chair.Text = "Mecnun Odyakmaz";
                stad.Text = "Dört Eylül, Sivas";
                fund.Text = "Vasat";
                ligsira.Text = "5";
                takimadi.BackColor = Color.Red;
                takimadi.ForeColor = Color.White;
                home = Color.Firebrick;
                type=Color.White;
            }
            else
            {
                takimadi.Text = takimlar.SelectedItem.ToString();
                yil.Text = "1967";
                chair.Text = "Sadri Şener";
                stad.Text = "Hüseyin Avni Aker, Trabzon";
                fund.Text = "İyi";
                ligsira.Text = "4";
                takimadi.BackColor = Color.Maroon;
                takimadi.ForeColor = Color.LightSkyBlue;
                home = Color.Maroon;
                type=Color.LightSkyBlue;
            }
        }
    }
}
