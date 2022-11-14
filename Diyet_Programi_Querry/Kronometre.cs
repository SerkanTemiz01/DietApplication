using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diyet_Programi_Querry
{
    public partial class Kronometre : Form
    {
        public Kronometre()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1;
        }
        int saniye;
        int dakika;
        int saat;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = dakika.ToString();
            if (saniye==60)
            {
                saniye=0;
                dakika++;
            }
            if(dakika==60)
            {
                dakika=0;
                saat++;
            }
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblSaniye.Text ="00";
            lblDakika .Text="00";
            lblSaat.Text = "00";
            saniye = 0;
            dakika = 0;
            saat = 0;
            timer1.Stop();
        }
    }
}
