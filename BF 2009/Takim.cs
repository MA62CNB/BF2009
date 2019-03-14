using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BF_2009
{
    public partial class Takim : Form
    {
        public string takim_adi;

        RichTextBox rtb = new RichTextBox();
        
        public Takim()
        {
            InitializeComponent();
        }

        public Takim(RichTextBox send)
        {
            InitializeComponent();
            rtb = send;
        }

        public Takim(string oyIsim)
        {
            InitializeComponent();
            takim_adi = oyIsim;
            //db sorgu
            //takımın oyuncularını göster
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Train ant = new Train();
            ant.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //tıklanan oyuncunun ismi alınacak
            //kontrat seçenekleri oyuncuya göre gödüntülenecek
            Kontrat newcon = new Kontrat();
            Takim win = new Takim();
            newcon.ShowDialog();            
            win.Hide();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            PDetail players = new PDetail();
            Takim win = new Takim();
            players.ShowDialog();
            win.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TStatus transfere = new TStatus();
            Takim win = new Takim();
            transfere.ShowDialog();
            win.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Interact talk = new Interact();
            Takim win = new Takim();
            talk.ShowDialog();
            win.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Finans funds = new Finans();
            Takim win = new Takim();
            funds.ShowDialog();
            win.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fix fiks = new Fix();
            fiks.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtb.Visible = true;
            this.Hide();
        }
    }
}
