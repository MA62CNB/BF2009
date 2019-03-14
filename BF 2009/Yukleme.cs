using System;
using System.Windows.Forms;

namespace BF_2009
{
    public partial class Yukleme : Form
    {
        public Yukleme()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (pbar.Value < 100)
            {
                pbar.Value += 25;           //yirmi beş birim doldur
            }
            this.Hide();
        }

        private void Yukleme_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
