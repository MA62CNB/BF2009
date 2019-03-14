using System;
using System.Drawing;
using System.Windows.Forms;

namespace BF_2009
{
    public partial class Game : Form
    {
        public int ay, gun, yil, count = 0;
        int puan, mac, j;
        int l = 0;
        int[] takimlar = new int[17];
        int[] asd = new int[17];
        public string chr;
        public string aystr;
        public string oyIsim, oyTakim;
        string[] takims = new string[34];
        public Color home1, type1;
        Form main = new Form1();
        Start reg = new Start();
        Yukleme popup = new Yukleme();
        TextBox lists = new TextBox();
        Random rand = new Random();

        //mevcut takımlar
        string[] liste = new string[] {"Ankaragücü","Ankaraspor","Antalyaspor","Beşiktaş","Bursaspor","Denizlispor",
                                        "Diyarbakırspor","Eskişehirspor","Fenerbahçe","Galatasaray","Gaziantepspor",
                                        "Gençlerbirliği","İstanbul B.B.Spor","Kasımpaşa","Kayserispor","Manisaspor",
                                        "Sivasspor","Trabzonspor"};
        //ankaragücü
        string[] agfix = new string[] {"Gençlerbirliği","Trabzonspor","Galatasaray","Kasımpaşa","Sivasspor","Kayserispor",
                                        "Bursaspor","Eskişehirspor","Beşiktaş","Ankaraspor","Denizlispor","Gaziantepspor",
                                        "Diyarbakırspor","Manisaspor","İstanbul B.B.Spor","Fenerbahçe","Antalyaspor",
                                        "Gençlerbirliği","Trabzonspor","Galatasaray","Kasımpaşa","Sivasspor","Kayserispor",
                                        "Bursaspor","Eskişehirspor","Beşiktaş","Ankaraspor","Denizlispor","Gaziantepspor",
                                        "Diyarbakırspor","Manisaspor","İstanbul B.B.Spor","Fenerbahçe","Antalyaspor"};

        //ankaraspor
        string[] asfix = new string[] {"Beşiktaş","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor","Antalyaspor","Trabzonspor",
                                        "Kasımpaşa","Kayserispor","Eskişehirspor","Ankaragücü","Gaziantepspor","Manisaspor",
                                        "Fenerbahçe","Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor",
                                        "Beşiktaş","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor","Antalyaspor","Trabzonspor",
                                        "Kasımpaşa","Kayserispor","Eskişehirspor","Ankaragücü","Gaziantepspor","Manisaspor",
                                        "Fenerbahçe","Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor"};

        //antalyaspor
        string[] antfix = new string[] {"Trabzonspor","Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor","Gaziantepspor",
                                         "Manisaspor","Fenerbahçe","Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor",
                                         "Beşiktaş","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor","Ankaragücü",
                                         "Trabzonspor","Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor","Gaziantepspor",
                                         "Manisaspor","Fenerbahçe","Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor",
                                         "Beşiktaş","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor","Ankaragücü"};

        //beşiktaş
        public string[] bjkfix = new string[] {"Ankaraspor","Gaziantepspor","Manisaspor","Fenerbahçe","Gençlerbirliği","Galatasaray",
                                        "Sivasspor","Bursaspor","Ankaragücü","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor",
                                        "Antalyaspor","Trabzonspor","Kasımpaşa","Kayserispor","Eskişehirspor",
                                        "Ankaraspor","Gaziantepspor","Manisaspor","Fenerbahçe","Gençlerbirliği","Galatasaray",
                                        "Sivasspor","Bursaspor","Ankaragücü","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor",
                                        "Antalyaspor","Trabzonspor","Kasımpaşa","Kayserispor","Eskişehirspor"};

        //buraspor
        public string[] bsfix = new string[] {"Gaziantepspor","Manisaspor","Fenerbahçe","Gençlerbirliği","Galatasaray","Sivasspor",
                                        "Ankaragücü","Beşiktaş","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor",
                                        "Antalyaspor","Trabzonspor","Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor",
                                        "Gaziantepspor","Manisaspor","Fenerbahçe","Gençlerbirliği","Galatasaray","Sivasspor",
                                        "Ankaragücü","Beşiktaş","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor",
                                        "Antalyaspor","Trabzonspor","Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor"};

        //denizlispor
        string[] dsfix = new string[] {"Eskişehirspor","Ankaraspor","Gaziantepspor","Manisaspor","Fenerbahçe",
                                        "Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor","Beşiktaş","Ankaragücü",
                                        "Diyarbakırspor","İstanbul B.B.Spor","Antalyaspor","Trabzonspor","Kasımpaşa","Kayserispor",
                                        "Eskişehirspor","Ankaraspor","Gaziantepspor","Manisaspor","Fenerbahçe",
                                        "Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor","Beşiktaş","Ankaragücü",
                                        "Diyarbakırspor","İstanbul B.B.Spor","Antalyaspor","Trabzonspor","Kasımpaşa","Kayserispor"};

        //diyarbakırspor
        string[] dbfix = new string[] {"Kayserispor","Eskişehirspor","Ankaraspor","Gaziantepspor","Manisaspor",
                                        "Fenerbahçe","Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor","Beşiktaş",
                                        "Denizlispor","Ankaragücü","İstanbul B.B.Spor","Antalyaspor","Trabzonspor","Kasımpaşa",
                                        "Kayserispor","Eskişehirspor","Ankaraspor","Gaziantepspor","Manisaspor",
                                        "Fenerbahçe","Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor","Beşiktaş",
                                        "Denizlispor","Ankaragücü","İstanbul B.B.Spor","Antalyaspor","Trabzonspor","Kasımpaşa"};

        //eskişehirspor
        string[] esfix = new string[] {"Denizlispor","Diyarbakırspor","İstanbul B.B.Spor","Antalyaspor","Trabzonspor",
                                        "Kasımpaşa","Kayserispor","Ankaraspor","Ankaragücü","Gaziantepspor","Manisaspor",
                                        "Fenerbahçe","Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor","Beşiktaş",
                                        "Denizlispor","Diyarbakırspor","İstanbul B.B.Spor","Antalyaspor","Trabzonspor",
                                        "Kasımpaşa","Kayserispor","Ankaraspor","Ankaragücü","Gaziantepspor","Manisaspor",
                                        "Fenerbahçe","Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor","Beşiktaş"};

        //fenerbahçe
        string[] fbfix = new string[] {"Galatasaray","Sivasspor","Bursaspor","Beşiktaş","Denizlispor","Diyarbakırspor",
                                        "İstanbul B.B.Spor","Antalyaspor","Trabzonspor","Kasımpaşa","Kayserispor",
                                        "Eskişehirspor","Ankaraspor","Gaziantepspor","Manisaspor","Ankaragücü","Gençlerbirliği",
                                        "Galatasaray","Sivasspor","Bursaspor","Beşiktaş","Denizlispor","Diyarbakırspor",
                                        "İstanbul B.B.Spor","Antalyaspor","Trabzonspor","Kasımpaşa","Kayserispor",
                                        "Eskişehirspor","Ankaraspor","Gaziantepspor","Manisaspor","Ankaragücü","Gençlerbirliği"};

        //galatasaray
        string[] gsfix = new string[] {"Fenerbahçe","Gençlerbirliği","Ankaragücü","Sivasspor","Bursaspor","Beşiktaş",
                                        "Denizlispor","Diyarbakırspor","İstanbul B.B.Spor","Antalyaspor","Trabzonspor",
                                        "Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor","Gaziantepspor","Manisaspor",
                                        "Fenerbahçe","Gençlerbirliği","Ankaragücü","Sivasspor","Bursaspor","Beşiktaş",
                                        "Denizlispor","Diyarbakırspor","İstanbul B.B.Spor","Antalyaspor","Trabzonspor",
                                        "Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor","Gaziantepspor","Manisaspor"};

        //gaziantepspor
        string[] gasfix = new string[] {"Bursaspor","Beşiktaş","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor",
                                         "Antalyaspor","Trabzonspor","Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor",
                                         "Ankaragücü","Manisaspor","Fenerbahçe","Gençlerbirliği","Galatasaray","Sivasspor",
                                         "Bursaspor","Beşiktaş","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor",
                                         "Antalyaspor","Trabzonspor","Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor",
                                         "Ankaragücü","Manisaspor","Fenerbahçe","Gençlerbirliği","Galatasaray","Sivasspor"};

        //gençlerbirliği
        string[] gbfix = new string[] {"Ankaragücü","Galatasaray","Sivasspor","Bursaspor","Beşiktaş","Denizlispor",
                                        "Diyarbakırspor","İstanbul B.B.Spor","Antalyaspor","Trabzonspor","Kasımpaşa",
                                        "Kayserispor","Eskişehirspor","Ankaraspor","Gaziantepspor","Manisaspor","Fenerbahçe",
                                        "Ankaragücü","Galatasaray","Sivasspor","Bursaspor","Beşiktaş","Denizlispor",
                                        "Diyarbakırspor","İstanbul B.B.Spor","Antalyaspor","Trabzonspor","Kasımpaşa",
                                        "Kayserispor","Eskişehirspor","Ankaraspor","Gaziantepspor","Manisaspor","Fenerbahçe"};
        //ibbspor
        string[] ibbfix = new string[] {"Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor","Gaziantepspor",
                                         "Manisaspor","Fenerbahçe","Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor",
                                         "Beşiktaş","Denizlispor","Diyarbakırspor","Ankaragücü","Antalyaspor","Trabzonspor",
                                         "Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor","Gaziantepspor",
                                         "Manisaspor","Fenerbahçe","Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor",
                                         "Beşiktaş","Denizlispor","Diyarbakırspor","Ankaragücü","Antalyaspor","Trabzonspor"};

        //kasımpaşa
        string[] kpfix = new string[] {"İstanbul B.B.Spor","Antalyaspor","Trabzonspor","Ankaragücü","Kayserispor",
                                        "Eskişehirspor","Ankaraspor","Gaziantepspor","Manisaspor","Fenerbahçe",
                                        "Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor","Beşiktaş","Denizlispor","Diyarbakırspor",
                                        "İstanbul B.B.Spor","Antalyaspor","Trabzonspor","Ankaragücü","Kayserispor",
                                        "Eskişehirspor","Ankaraspor","Gaziantepspor","Manisaspor","Fenerbahçe",
                                        "Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor","Beşiktaş","Denizlispor","Diyarbakırspor"};

        //kayserispor
        string[] ksfix = new string[] {"Diyarbakırspor","İstanbul B.B.Spor","Antalyaspor","Trabzonspor","Kasımpaşa",
                                        "Ankaragücü","Eskişehirspor","Ankaraspor","Gaziantepspor","Manisaspor","Fenerbahçe",
                                        "Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor","Beşiktaş","Denizlispor",
                                        "Diyarbakırspor","İstanbul B.B.Spor","Antalyaspor","Trabzonspor","Kasımpaşa",
                                        "Ankaragücü","Eskişehirspor","Ankaraspor","Gaziantepspor","Manisaspor","Fenerbahçe",
                                        "Gençlerbirliği","Galatasaray","Sivasspor","Bursaspor","Beşiktaş","Denizlispor"};

        //manisaspor
        string[] manfix = new string[] {"Sivasspor","Bursaspor","Beşiktaş","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor",
                                         "Antalyaspor","Trabzonspor","Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor",
                                         "Gaziantepspor","Ankaragücü","Fenerbahçe","Gençlerbirliği","Galatasaray",
                                         "Sivasspor","Bursaspor","Beşiktaş","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor",
                                         "Antalyaspor","Trabzonspor","Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor",
                                         "Gaziantepspor","Ankaragücü","Fenerbahçe","Gençlerbirliği","Galatasaray"};

        //sivasspor
        string[] ssfix = new string[] {"Manisaspor","Fenerbahçe","Gençlerbirliği","Galatasaray","Ankaragücü",
                                        "Bursaspor","Beşiktaş","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor","Antalyaspor",
                                        "Trabzonspor","Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor","Gaziantepspor",
                                        "Manisaspor","Fenerbahçe","Gençlerbirliği","Galatasaray","Ankaragücü",
                                        "Bursaspor","Beşiktaş","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor","Antalyaspor",
                                        "Trabzonspor","Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor","Gaziantepspor"};

        //trabzonspor
        string[] tsfix = new string[] {"Antalyaspor","Ankaragücü","Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor",
                                        "Gaziantepspor","Manisaspor","Fenerbahçe","Gençlerbirliği","Galatasaray",
                                        "Sivasspor","Bursaspor","Beşiktaş","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor",
                                        "Antalyaspor","Ankaragücü","Kasımpaşa","Kayserispor","Eskişehirspor","Ankaraspor",
                                        "Gaziantepspor","Manisaspor","Fenerbahçe","Gençlerbirliği","Galatasaray",
                                        "Sivasspor","Bursaspor","Beşiktaş","Denizlispor","Diyarbakırspor","İstanbul B.B.Spor"};

        public static int durum = 1;

        public int haber_no
        {
            set
            {
                durum = value;
            }
        }

        public Game()
        {
            InitializeComponent();
        }

        //Game formu container'ı
        public Game(string isim, string takim, Color home, Color type)
        {
            oyIsim = isim;
            oyTakim = takim;
            home1 = home;
            type1 = type;
            InitializeComponent();
        }

        private void anaMenu_Click(object sender, EventArgs e)
        {
            DialogResult yesno;
            yesno = MessageBox.Show("Oyundan çıkmadan önce kaydetmek ister misiniz?", "Kaydet", MessageBoxButtons.YesNoCancel);
            
            if (yesno == DialogResult.No)
            {
                main.Show();            //ana menüye döner
                haberler.Clear();           //haberleri temizler
                this.Dispose(true);         //tüm kaynakları bırakır, oyun kapanır
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            reg.Close();
            textBox1.Text = oyIsim;         //oyuncu ismi
            linkLabel1.Text = oyTakim;          //takım ismi

            //lig başlangıç tarihi
            virGun.Text = "8";
            virAy.Text = "Ağu";
            virYil.Text = "2009";
            haber(haberler, durum);     //ilk haber. göreve getirilme


            //takımların tüm ayarları
            //logo
            //arkaplan rengi
            //yazı rengi
            //yazı arkaplan rengi
            //fikstür
            if (oyTakim == "Ankaragücü")
            {
                pictureBox1.Image = Properties.Resources.ag;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = agfix;
            }
            else if (oyTakim == "Ankaraspor")
            {
                pictureBox1.Image = Properties.Resources._as;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = asfix;
            }
            else if (oyTakim == "Antalyaspor")
            {
                pictureBox1.Image = Properties.Resources.ants;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = antfix;
            }
            else if (oyTakim == "Beşiktaş")
            {
                pictureBox1.Image = Properties.Resources.bjk;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = bjkfix;
            }
            else if (oyTakim == "Bursaspor")
            {
                pictureBox1.Image = Properties.Resources.bs;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = bsfix;
            }
            else if (oyTakim == "Denizlispor")
            {
                pictureBox1.Image = Properties.Resources.ds;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = dsfix;
            }
            else if (oyTakim == "Diyarbakırspor")
            {
                pictureBox1.Image = Properties.Resources.dbs;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = dbfix;
            }
            else if (oyTakim == "Eskişehirspor")
            {
                pictureBox1.Image = Properties.Resources.eses;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = esfix;
            }
            else if (oyTakim == "Fenerbahçe")
            {
                pictureBox1.Image = Properties.Resources.fb;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = fbfix;
            }
            else if (oyTakim == "Galatasaray")
            {
                pictureBox1.Image = Properties.Resources.gs;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = gsfix;
            }
            else if (oyTakim == "Gaziantepspor")
            {
                pictureBox1.Image = Properties.Resources.gas;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = gasfix;
            }
            else if (oyTakim == "Gençlerbirliği")
            {
                pictureBox1.Image = Properties.Resources.gb;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = gbfix;
            }
            else if (oyTakim == "İstanbul B.B.Spor")
            {
                pictureBox1.Image = Properties.Resources.ibbs;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = ibbfix;
            }
            else if (oyTakim == "Kasımpaşa")
            {
                pictureBox1.Image = Properties.Resources.kas;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = kpfix;
            }
            else if (oyTakim == "Kayserispor")
            {
                pictureBox1.Image = Properties.Resources.ks;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = ksfix;
            }
            else if (oyTakim == "Manisaspor")
            {
                pictureBox1.Image = Properties.Resources.ms;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = manfix;
            }
            else if (oyTakim == "Sivasspor")
            {
                pictureBox1.Image = Properties.Resources.ss;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = ssfix;
            }
            else if (oyTakim == "Trabzonspor")
            {
                pictureBox1.Image = Properties.Resources.ts;
                panel1.BackColor = home1;
                linkLabel1.ForeColor = type1;
                textBox1.BackColor = home1;
                takims = tsfix;
            }

            aystr = virAy.Text;
            gun = Convert.ToInt32(virGun.Text);
            yil = Convert.ToInt32(virYil.Text);
        }

        private void takimEkr_Click(object sender, EventArgs e)
        {
            Takim takimp = new Takim(richTextBox1);
            takimp.ShowDialog();            //takim ve oyuncular
        }

        private void oyuncuAra_Click(object sender, EventArgs e)
        {
            Arama search = new Arama();
            search.ShowDialog();            //oyuncu arama ekranı
        }

        private void antrenman_Click(object sender, EventArgs e)
        {
            Train antrenman = new Train();
            antrenman.ShowDialog();         //antrenman ekranı
        }

        private void taktikEkr_Click(object sender, EventArgs e)
        {
            Taktik formation = new Taktik();
            formation.ShowDialog();         //taktik ekranı
        }

        //güne göre ayı değiştirme
        private void tarih(ref int gun, ref int ay, ref int yil)
        {
            if (ay == 2)
            {
                if (gun >= 28)
                {
                    ay++;
                    gun -= 28;
                }
            }
            if (ay % 2 == 1 || ay == 6 || ay == 12)
            {
                if (gun > 31)
                {
                    ay++;
                    gun -= 31;
                    if (ay > 12)
                    {
                        ay = 1;
                        yil++;
                    }
                }
            }
            else
            {
                if (gun > 30)
                {
                    ay++;
                    gun -= 30;
                    if (ay > 12)
                    {
                        ay = 1;
                        yil++;
                    }
                }
            }
        }

        //gün ilerletme
        //her hafta bir maç
        private void devam_Click(object sender, EventArgs e)
        {
            popup.ShowDialog();
            gun += 7;
            ay = convertAy(aystr);

            if (j < 34)
            {
                if (takims[j] == oyTakim)
                {
                    j++;
                    label6.Text = takims[j];            //bir sonraki takım
                    j++;
                }
                else
                {
                    label6.Text = takims[j];            //bir sonraki takım
                    j++;
                }

                tarih(ref gun, ref ay, ref yil);            //tarih çevirim fonksiyonu
                aystr = convertNum(ay);         //tarih çevirim fonksiyonu
                virGun.Text = gun.ToString();
                virAy.Text = aystr;
                virYil.Text = yil.ToString();
                count++;

                if (count == 1)
                {
                    match.Enabled = true;
                    asd = ligPuan();        //diğer takımların maç sonuçlarına göre puanı
                    tablo(asd);         //tablo oluşturma
                    devam.Enabled = false;
                    count = 0;
                }
            }
            else
            {
                MessageBox.Show("Lig bitti.");
                match.Enabled = false;
                devam.Enabled = true;
                //kovulma + otun bitti mesajı
            }
        }

        //maçı oynatır
        private void match_Click(object sender, EventArgs e)
        {
            Taktik prematch = new Taktik();
            prematch.ShowDialog();
            haber(haberler, durum);     //haber oluşturur
            label1.Text = puan.ToString();
            mac++;      //maç sayısını gösterir
            label3.Text = mac.ToString();
            match.Enabled = false;
            devam.Enabled = true;
            count = 0;
        }

        //sayıyı string aya çeviren (1->Ocak)
        private string convertNum(int mon)
        {
            string month = "";
            switch (mon)
            {
                case 1:
                    month = "Oca";
                    break;
                case 2:
                    month = "Şub";
                    break;
                case 3:
                    month = "Mar";
                    break;
                case 4:
                    month = "Nis";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "Haz";
                    break;
                case 7:
                    month = "Tem";
                    break;
                case 8:
                    month = "Ağu";
                    break;
                case 9:
                    month = "Eyl";
                    break;
                case 10:
                    month = "Eki";
                    break;
                case 11:
                    month = "Kas";
                    break;
                case 12:
                    month = "Ara";
                    break;
                default:
                    break;
            }
            return month;
        }

        //string ayı sayıya çeviren   (Ocak->1)
        private int convertAy(string aystr)
        {
            int mon = 0;
            switch (aystr)
            {
                case "Oca":
                    mon = 1;
                    break;
                case "Şub":
                    mon = 2;
                    break;
                case "Mar":
                    mon = 3;
                    break;
                case "Nis":
                    mon = 4;
                    break;
                case "May":
                    mon = 5;
                    break;
                case "Haz":
                    mon = 6;
                    break;
                case "Tem":
                    mon = 7;
                    break;
                case "Ağu":
                    mon = 8;
                    break;
                case "Eyl":
                    mon = 9;
                    break;
                case "Eki":
                    mon = 10;
                    break;
                case "Kas":
                    mon = 11;
                    break;
                case "Ara":
                    mon = 12;
                    break;
                default:
                    break;
            }
            return mon;
        }

        //alınan sonuca göre haber üretir, puanı ekler, seriyi belirler
        //ilk gün için haber oluşturur
        public void haber(RichTextBox haberler, int durum)
        {
            if (durum == 1)
            {
                haberler.Text = oyTakim + " teknik direktörlük görevi için " + oyIsim + " ile anlaştı.\n";
                haberler.Text += "\nTaraftarlar takımın başına tecrübesiz bir adayın getirilmesinden şikayetçiyse de yönetim başarıdan emin gözüküyor.";
            }
            else if (durum == 2 || durum == 3)
            {
                haberler.Text = oyTakim + " - " + label6.Text + "\n\n";
                haberler.Text += oyTakim + " bu hafta oynadığı maçta kazanan taraf oldu.";
                haberler.Text += "\nAlınan üç puan ile birlikte maç boyunca destek veren taraftarlar galibiyeti doyasıya kutladı.";
                puan += 3;
                chr += "G";
            }
            else if (durum == 4 || durum == 5)
            {
                haberler.Text = oyTakim + " - " + label6.Text + "\n\n";
                haberler.Text += oyTakim + " bu hafta oynadığı maçta kaybeden taraf oldu.";
                haberler.Text += "\nKaçırılan üç puanın ardından taraftarlar tesisleri basarak futbolculara hesap sordu.";
                puan += 0;
                chr += "M";
            }
            else if (durum == 6 || durum == 7)
            {
                haberler.Text = oyTakim + " - " + label6.Text + "\n\n";
                haberler.Text += oyTakim + " bu hafta oynadığı maçta berabere kaldı.";
                haberler.Text += "\nOynanan kötü oyunun yanında kaybedilen puanlar da taraftarları üzdü.";
                puan += 1;
                chr += "B";
            }
        }

        private void Fikstür_Click(object sender, EventArgs e)
        {
            //ligdeki seriyi gösterir - G,B,M
            if (l < 34)
            {
                for (l = 0; l < 34; l++)
                {
                    lists.Text += takims[l] + "\r\n";
                }
                Fix fiks = new Fix(lists, oyTakim, chr);
                fiks.ShowDialog();
            }
            else
            {
                Fix fiks = new Fix(lists, oyTakim, chr);
                fiks.ShowDialog();
            }
        }

        //diğerlerinin puanı
        private int[] ligPuan()
        {
            int rnd;
            int[] puanlar = new int[17];

            for (int k = 0; k < 17; k++)
            {
                rnd = rand.Next(0, 8);
                if (rnd >= 0 & rnd < 3)
                {
                    takimlar[k] = 0;
                }
                else if (rnd >= 3 & rnd < 6)
                {
                    takimlar[k] = 1;
                }
                else
                {
                    takimlar[k] = 3;
                }
                puanlar[k] += takimlar[k];
            }
            return takimlar;
        }

        
        //puan tablosunu oluşturma
        private void tablo(int[] asd)
        {
            for (int i = 0; i < asd.Length; i++)
            {
                if (liste[i] != oyTakim)
                {
                    richTextBox1.Text += liste[i] + " " + asd[i] + "\n";
                }
                else
                {
                    richTextBox1.Text += oyTakim + " " + label1.Text + "\n";
                }
            }
        }

        //tabloyu kapatma
        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }
    }
}
