using System;
using System.Windows.Forms;

namespace BF_2009
{
    public partial class Taktik : Form
    {
        Random rand = new Random();
        int ret;
        public Taktik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /***
             ***MAÇ MOTORU EKRANI
             ***SONUCA GÖRE MESAJA GEREKLİ SAYININ GİTMESİ
             ***GALİBİYET 2, MAĞLUBİYET 3, BERABERLİK 4, KIRMIZI KART 5, SAKATLIK 6
             ***RAKİBİN ADININ MESAJ FONK. GÖNDERİLMESİ
             ***SKORUN MESAJ FONK. GÖDERİLMESİ
             ***/
            Game gm = new Game();
            ret = rand.Next(2, 7);
            gm.haber_no = ret;
            this.Hide();
        }
    }
}
