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
        private BesinlerRepository _besinlerRepository;
        private EgzersizlerRepository _egzersizlerRepository;
        private VucutAnalizRepository _vucutAnalizRepository;
        private AdimSayisiReporsitory _adimSayisiReporsitory;
        private SuTakibiRepository _suTakibiRepository;
        IEnumerable<Besinler> besinlerListe;
        decimal alinanKalori;
        decimal harcananKalori;
        decimal hedefKalori;
        List<TuketilenBesinler> tuketilenBesinlerListe;

        decimal adimHarcananKalori;

        private void Raporlama_Load(object sender, EventArgs e)
        {
            db = new DietQueryDBContext();
            _raporRepository = new RaporRepository(db);
            _besinlerRepository = new BesinlerRepository(db);
            _tuketilenBesinlerRepository = new TuketilenBesinlerRepository(db);
            _egzersizlerRepository = new EgzersizlerRepository(db);
            _vucutAnalizRepository = new VucutAnalizRepository(db);
            _adimSayisiReporsitory = new AdimSayisiReporsitory(db);
            _suTakibiRepository= new SuTakibiRepository(db);


            tuketilenBesinlerListe = _tuketilenBesinlerRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).ToList();
            var tuketilenBesinlerID = tuketilenBesinlerListe.Select(x => x.BesinBilgileriID).ToList();
            besinlerListe = _besinlerRepository.GetAll().Where(x => tuketilenBesinlerID.Contains(x.ID));
            alinanKalori = tuketilenBesinlerListe.Sum(x => x.AlinanKalori);
            adimHarcananKalori = _adimSayisiReporsitory.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).Sum(x => x.AdimHarcananKalori);
            harcananKalori = _egzersizlerRepository.GetAll().Where(x => x.KullaniciId == GirisYap.gelenID).Sum(x => x.HarcananKalori);
            hedefKalori = _vucutAnalizRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).Select(x => x.HedefKalori).FirstOrDefault();
            lblAlinanKalori.Text = alinanKalori.ToString();
            lblProtein.Text = tuketilenBesinlerListe.Sum(x => x.Protein).ToString();
            lblKarbonhidrat.Text = tuketilenBesinlerListe.Sum(x => x.Karbonhidrat).ToString();
            lblYag.Text = tuketilenBesinlerListe.Sum(x => x.Yag).ToString();
            lblHarcananKalori.Text = (harcananKalori + adimHarcananKalori).ToString();
            lblNetKalori.Text = (hedefKalori - alinanKalori + harcananKalori + adimHarcananKalori).ToString();


            lblGünSonuBilgisi.Visible = false;



        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Rapor");
            Rapor rapor = new Rapor();
            rapor.KullaniciID = GirisYap.gelenID;
            rapor.HarcananKalori = harcananKalori + adimHarcananKalori;
            rapor.ProteinDegeri = (decimal)tuketilenBesinlerListe.Sum(x => x.Protein);
            rapor.YagDegeri = (decimal)tuketilenBesinlerListe.Sum(x => x.Yag);
            rapor.AlinanKaloriDegeri = (decimal)alinanKalori;
            rapor.HedefKaloriDegeri = hedefKalori;
            rapor.KarbonhidratDegeri = tuketilenBesinlerListe.Sum(x => x.Karbonhidrat);
            rapor.NetKaloriHesaplama();
            rapor.NeticeBulma();
            _raporRepository.Add(rapor);

            lblGünSonuBilgisi.Visible = true;
            if (rapor.Netice==Netice.Ulaşıldı)
            {
                lblGünSonuBilgisi.Text = Netice.Ulaşıldı.ToString();
                lblGünSonuBilgisi.ForeColor = Color.Green;
            }
            else
            {
                lblGünSonuBilgisi.Text = Netice.Ulaşılamadı.ToString();
                lblGünSonuBilgisi.ForeColor = Color.Red;
            }



            foreach (var item in _tuketilenBesinlerRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID))
            {
                _tuketilenBesinlerRepository.Delete(item);
            }
            foreach (var item in _adimSayisiReporsitory.GetAll().Where(x=>x.KullaniciID==GirisYap.gelenID))
            {
                _adimSayisiReporsitory.Delete(item);
            }
            foreach (var item in _suTakibiRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID))
            {
                _suTakibiRepository.Delete(item);
            }
            lblNetKalori.Text = "0";

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnasayfaForm anasayfaForm = new AnasayfaForm();
            anasayfaForm.Show();
            this.Close();
        }
        
    }
}
