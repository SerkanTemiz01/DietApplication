using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Diyet_Programi_Querry
{
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        private void lblKalori_Click(object sender, EventArgs e)
        {
            //asadajjcjajakkkaas26626
        }

        private void Menü_Load(object sender, EventArgs e)
        {
            long kalori = 2050;
            pnlMenu.Visible = false;
            circularProgressBar1.Value = 75;
            circularProgressBar1.alinanKalori = 1345;
            lblEgzersizKalori.Text = "500";
            lblKalori.Text=kalori.ToString();
            lblBoy.Text = "178";
            lblAdSoyad.Text = "Serkan Temiz";
            lblKilo.Text = "75";
            lblYas.Text = "27";
            
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            pnlMenu.Visible = true;
                           
        }

        private void Menü_MouseEnter(object sender, EventArgs e)
        {

            pnlMenu.Visible = false;

        }

        private void lblKilo_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 10;
            i = 0;
        }
        long i;
        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value = i;
            i++;
            if(i==76)
                timer1.Stop();
        }

        private void lblKilo_Click(object sender, EventArgs e)
        {
            string ilkDegerKilo = lblKilo.Text;
            string kiloVerisi= Interaction.InputBox("Kilo giriniz.", "Yeni Kilo Girişi", lblKilo.Text, this.Width/2, this.Height/2);
            
            if (int.TryParse(kiloVerisi, out int value))
            {
                lblKilo.Text = value.ToString();
            }
            else
            {
                lblKilo.Text = ilkDegerKilo;
                if(kiloVerisi!="")
                lblKilo_Click(sender, e);
            }
                
        }
    }
}
