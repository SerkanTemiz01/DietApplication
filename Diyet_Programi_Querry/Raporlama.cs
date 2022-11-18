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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diyet_Programi_Querry
{
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }
        private DietQueryDBContext db;
        private RaporRepository _raporRepository;
        private TuketilenBesinlerRepository _tuketilenBesinlerRepository;
        private EgzersizlerRepository _egzersizlerRepository;
        private VucutAnalizRepository _vucutAnalizRepository;
        private AdimSayisiReporsitory _adimSayisiReporsitory;
        private SuTakibiRepository _suTakibiRepository;

        decimal alinanKalori;
        decimal harcananKalori;
        decimal hedefKalori;
        decimal adimHarcananKalori;
        decimal protein;
        decimal yag;
        decimal karbonhidrat;
        List<TuketilenBesinler> tuketilenBesinlerListe;
        private void Raporlama_Load(object sender, EventArgs e)
        {
            db = new DietQueryDBContext();
            _raporRepository = new RaporRepository(db);
            _tuketilenBesinlerRepository = new TuketilenBesinlerRepository(db);
            _egzersizlerRepository = new EgzersizlerRepository(db);
            _vucutAnalizRepository = new VucutAnalizRepository(db);
            _adimSayisiReporsitory = new AdimSayisiReporsitory(db);
            _suTakibiRepository = new SuTakibiRepository(db);


            tuketilenBesinlerListe = _tuketilenBesinlerRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).ToList();
            alinanKalori = tuketilenBesinlerListe.Sum(x => x.AlinanKalori);
            protein = tuketilenBesinlerListe.Sum(x => x.Protein);
            yag = tuketilenBesinlerListe.Sum(x => x.Yag);
            karbonhidrat = tuketilenBesinlerListe.Sum(x => x.Karbonhidrat);

            adimHarcananKalori = _adimSayisiReporsitory.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).Sum(x => x.AdimHarcananKalori);
            harcananKalori = _egzersizlerRepository.GetAll().Where(x => x.KullaniciId == GirisYap.gelenID).Sum(x => x.HarcananKalori);
            hedefKalori = _vucutAnalizRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).Select(x => x.HedefKalori).FirstOrDefault();

            LabelYazma();
            lblGünSonuBilgisi.Visible = false;
            

        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Gün sonu raporu al.\nRapor alınınca gün içindeki bilgiler sıfırlanıp raporlanacak!!!...", "Rapor Alma", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                Rapor rapor = new Rapor();
                rapor.KullaniciID = GirisYap.gelenID;
                rapor.HarcananKalori = harcananKalori + adimHarcananKalori;
                rapor.ProteinDegeri = protein;
                rapor.YagDegeri = yag;
                rapor.AlinanKaloriDegeri = alinanKalori;
                rapor.HedefKaloriDegeri = hedefKalori;
                rapor.KarbonhidratDegeri = karbonhidrat;
                rapor.NetKaloriHesaplama();
                rapor.NeticeBulma();
                _raporRepository.Add(rapor);

                lblGünSonuBilgisi.Visible = true;
                if (rapor.Netice == Netice.Ulaşıldı)
                {
                    lblGünSonuBilgisi.Text = Netice.Ulaşıldı.ToString();
                    lblGünSonuBilgisi.ForeColor = Color.Green;
                }
                else
                {
                    lblGünSonuBilgisi.Text = Netice.Ulaşılamadı.ToString();
                    lblGünSonuBilgisi.ForeColor = Color.Red;
                }


                ListeTemizleme();
                lblNetKalori.Text = "0";
                alinanKalori = harcananKalori = hedefKalori = adimHarcananKalori = protein = karbonhidrat = yag = 0;
                LabelYazma();
            }
            

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnasayfaForm anasayfaForm = new AnasayfaForm();
            anasayfaForm.Show();
            this.Close();
        }
        private void LabelYazma()
        {
            lblAlinanKalori.Text = alinanKalori.ToString();
            lblProtein.Text = protein.ToString();
            lblKarbonhidrat.Text = karbonhidrat.ToString();
            lblYag.Text = yag.ToString();
            lblHarcananKalori.Text = (harcananKalori + adimHarcananKalori).ToString();
            lblNetKalori.Text = (hedefKalori - alinanKalori + harcananKalori + adimHarcananKalori).ToString();
        }

        private void ListeTemizleme()
        {

            foreach (var item in _tuketilenBesinlerRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID))
            {
                _tuketilenBesinlerRepository.Delete(item);
            }
            foreach (var item in _adimSayisiReporsitory.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID))
            {
                _adimSayisiReporsitory.Delete(item);
            }
            foreach (var item in _suTakibiRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID))
            {
                _suTakibiRepository.Delete(item);
            }
            tuketilenBesinlerListe.Clear();
        }
    }
}
