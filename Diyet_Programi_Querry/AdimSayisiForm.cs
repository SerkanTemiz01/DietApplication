using DataAccess.ConcreteRepository;
using DataAccess.Context;
using Entities.Concrete;
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
    public partial class AdimSayisiForm : Form
    {
        public AdimSayisiForm()
        {
            InitializeComponent();
            db = new DietQueryDBContext();
            _adimSayisiReporsitory = new AdimSayisiReporsitory(db);
        }
        DietQueryDBContext db;
        AdimSayisiReporsitory _adimSayisiReporsitory;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            AdimSayisi adim = new AdimSayisi();
            adim.KullaniciID = GirisYap.gelenID;
            adim.AdimSayisi1 =(int) nmrAdimSayisi.Value;
            adim.HarcaKaloriBulma();
            _adimSayisiReporsitory.Add(adim);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnasayfaForm anasayfaForm = new AnasayfaForm();
            anasayfaForm.Show();
            this.Close();
        }

        private void AdimSayisiForm_Load(object sender, EventArgs e)
        {
            nmrAdimSayisi.Maximum = 50000;
        }
    }
}
