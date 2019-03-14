using System;
using System.Windows.Forms;

namespace BF_2009
{
    public partial class Fix : Form
    {

        string tk_adi, ch, temp;

        public Fix()
        {
            InitializeComponent();
        }

        //Fix formu container'ı
        public Fix(TextBox lists, string oyIsim, string chr)
        {
            InitializeComponent();
            tk_adi = oyIsim;
            ch = chr;
            temp = lists.Text;
        }

        private void Fix_Load(object sender, EventArgs e)
        {
            label3.Text = tk_adi;           //takım adı
            seri.Text = ch;         //ligdeki seri
            program.Text = temp;            //fikstür
        }
    }
}
