using DataAccess.ConcreteRepository;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diyet_Programi_Querry
{
    public partial class GenelRapor : Form
    {
        public GenelRapor()
        {
            InitializeComponent();
            
        }
        DietQueryDBContext db;
        RaporRepository _raporRepository;
        KullaniciBilgisiRepository bilgisiRepository;
        List<Rapor> Rapors;
        private void GenelRapor_Load(object sender, EventArgs e)
        {
            db = new DietQueryDBContext();
            _raporRepository = new RaporRepository(db);
            bilgisiRepository = new KullaniciBilgisiRepository(db);
            chart1.BackColor = Color.Transparent;//Arka Plan rengi
            chart1.Titles.Add("Genel Rapor");
            Rapors = _raporRepository.GetAll().Where(x=>x.KullaniciID==GirisYap.gelenID).ToList();
            rdbKalori.Checked = true;
        }

        private void rdbKalori_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbKalori.Checked)
            {
                chart1.Series.Clear();
                chart1.ChartAreas[0].AxisY.Maximum = 3000;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.Series.Add("Alınan Kalori");
                int i=0;
                foreach (Rapor rapor in Rapors)
                {
                    chart1.Series["Alınan Kalori"].Points.Add((double)rapor.AlinanKaloriDegeri);
                    chart1.Series["Alınan Kalori"].Points[i].AxisLabel = rapor.VerilisTarihi.ToString();
                    i++;
                }
                
            }
        }

        private void rdbHarcananKalori_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHarcananKalori.Checked)
            {
                chart1.Series.Clear();
                chart1.ChartAreas[0].AxisY.Maximum = 500;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.Series.Add("Harcanan Kalori");
                int i = 0;
                foreach (Rapor rapor in Rapors)
                {
                    chart1.Series["Harcanan Kalori"].Points.Add((double)rapor.HarcananKalori);
                    chart1.Series["Harcanan Kalori"].Points[i].AxisLabel = rapor.VerilisTarihi.ToString();
                    i++;
                }
            }
        }

        private void rdbKarbonhidrat_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbKarbonhidrat.Checked)
            {
                chart1.Series.Clear();
                chart1.ChartAreas[0].AxisY.Maximum = 500;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.Series.Add("Alınan Karbonhidrat");
                int i = 0;
                foreach (Rapor rapor in Rapors)
                {
                    chart1.Series["Alınan Karbonhidrat"].Points.Add((double)rapor.KarbonhidratDegeri);
                    chart1.Series["Alınan Karbonhidrat"].Points[i].AxisLabel = rapor.VerilisTarihi.ToString();
                    i++;
                }
            }
        }

        private void rdbProtein_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbProtein.Checked)
            {
                chart1.Series.Clear();
                chart1.ChartAreas[0].AxisY.Maximum = 500;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.Series.Add("Alınan Protein");
                int i = 0;
                foreach (Rapor rapor in Rapors)
                {
                    chart1.Series["Alınan Protein"].Points.Add((double)rapor.ProteinDegeri);
                    chart1.Series["Alınan Protein"].Points[i].AxisLabel = rapor.VerilisTarihi.ToString();
                    i++;
                }
            }
        }

        private void rdbYag_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbYag.Checked)
            {
                chart1.Series.Clear();
                chart1.ChartAreas[0].AxisY.Maximum = 500;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.Series.Add("Alınan Yağ");
                int i = 0;
                foreach (Rapor rapor in Rapors)
                {
                    chart1.Series["Alınan Yağ"].Points.Add((double)rapor.HarcananKalori);
                    chart1.Series["Alınan Yağ"].Points[i].AxisLabel = rapor.VerilisTarihi.ToString();
                    i++;
                }
            }
        }

        private void rdbNetKalori_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNetKalori.Checked)
            {
                chart1.Series.Clear();
                chart1.ChartAreas[0].AxisY.Maximum = 500;
                chart1.ChartAreas[0].AxisY.Minimum =- 500;
                chart1.Series.Add("Net Kalori");
                int i = 0;
                foreach (Rapor rapor in Rapors)
                {
                    chart1.Series["Net Kalori"].Points.Add((double)rapor.NetKalori);
                    chart1.Series["Net Kalori"].Points[i].AxisLabel = rapor.VerilisTarihi.ToString();
                    i++;
                }
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            AnasayfaForm anasayfaForm= new AnasayfaForm();
            anasayfaForm.Show();
            this.Close();
        }
    }
}
