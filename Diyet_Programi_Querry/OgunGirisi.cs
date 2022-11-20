using DataAccess.ConcreteRepository;
using DataAccess.Context;
using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Diyet_Programi_Querry
{
    public partial class OgunGirisi : Form
    {
        public OgunGirisi()
        {
            InitializeComponent();
        }
        DietQueryDBContext db;
        BesinlerRepository _besinlerRepository;
        TuketilenBesinlerRepository _tuketilenBesinlerRepository;

        private void OgunGirisi_Load(object sender, EventArgs e)
        {
            dgwliste.BackgroundColor = Color.Snow;
            dgwTuketilenListesi.BackgroundColor = Color.Snow;

            db = new DietQueryDBContext();
            _besinlerRepository = new BesinlerRepository(db);
            _tuketilenBesinlerRepository = new TuketilenBesinlerRepository(db);

            cmbOgunSec.DataSource = Enum.GetValues(typeof(Ogun));
            dgwliste.DataSource = _besinlerRepository.GetAll();
            nmrGram.Maximum = 1000;
            btnEkle.Enabled = false;
            btnSil.Enabled = false;
            dgwTuketilenListeleme();
        }



        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            var besinlerListesi = db.Besinlers.Where(X => X.ID == seciliID).ToList();
            TuketilenBesinler tuketilen = new TuketilenBesinler();
            tuketilen.KullaniciID = GirisYap.gelenID;
            tuketilen.BesinBilgileriID = seciliID;
            tuketilen.AlinanGramaj = nmrGram.Value;
            tuketilen.AlınanKaloriHesaplama((decimal)besinAl.Kalori, nmrGram.Value);
            tuketilen.BesinBilgileriDoldurma(besinAl.Karbonhidrat, besinAl.Yag, besinAl.Protein,nmrGram.Value);
            tuketilen.Ogun = (Ogun)cmbOgunSec.SelectedValue;
            _tuketilenBesinlerRepository.Add(tuketilen);
            dgwTuketilenListeleme();
        }

        private void btnYeniÖgun_Click_1(object sender, EventArgs e)
        {
            YeniOgunEkle yeniOgunEkle = new YeniOgunEkle();
            yeniOgunEkle.Show();
            this.Close();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            var silinecekTuketilenBesin = _tuketilenBesinlerRepository.GetById(tuketilenID);
            silinecekTuketilenBesin.DeletedDate = DateTime.Now;
            _tuketilenBesinlerRepository.Delete(silinecekTuketilenBesin);
            dgwTuketilenListeleme();
        }

        int seciliID;
        Besinler besinAl;
        private void dgwliste_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(nmrGram.Value>0)
            btnEkle.Enabled = true;
            besinAl = (Besinler)dgwliste.CurrentRow.DataBoundItem;
            seciliID = besinAl.ID;
        }
        int tuketilenID;
        private void dgwTuketilenListesi_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSil.Enabled = true;
            tuketilenID = (int)dgwTuketilenListesi.CurrentRow.Cells[7].Value;
        }
        private void dgwTuketilenListeleme()
        {
            dgwTuketilenListesi.DataSource = _tuketilenBesinlerRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).Select(x => new
            {
                BESİNADI = x.BesinBilgileri.BesinAdi,
                ÖĞÜN=x.Ogun,
                YAĞ = x.Yag,
                KARBONHİDRAT = x.Karbonhidrat,
                PROTEIN = x.Protein,
                TUKETİLENGRAMAJ = x.AlinanGramaj,
                KALORİ = x.AlinanKalori,
                PrimaryKey = x.ID

            }).ToList();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnasayfaForm anasayfaForm = new AnasayfaForm();
            anasayfaForm.Show();
            this.Close();
        }

        private void txtBesinArama_TextChanged(object sender, EventArgs e)
        {
            string Besin=txtBesinArama.Text;
            if(txtBesinArama.Text.Length>0)
            {
                 Besin = txtBesinArama.Text.Substring(0, 1).ToUpper() +
                txtBesinArama.Text.Substring(1, txtBesinArama.Text.Length - 1).ToLower();
                
            }

            dgwliste.DataSource = _besinlerRepository.GetAll().Where(x => x.BesinAdi.StartsWith(Besin)).ToList();
        }
    }
}