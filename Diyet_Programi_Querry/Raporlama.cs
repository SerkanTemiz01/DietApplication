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
        IEnumerable<Besinler> besinlerListe;
        float alinanKalori;
        decimal harcananKalori;
        decimal hedefKalori;
        List<TuketilenBesinler> tuketilenBesinlerListe;
        private void Raporlama_Load(object sender, EventArgs e)
        {
            db=new DietQueryDBContext();
            _raporRepository=new RaporRepository(db);
            _besinlerRepository=new BesinlerRepository(db);
            _tuketilenBesinlerRepository = new TuketilenBesinlerRepository(db);
            _egzersizlerRepository = new EgzersizlerRepository(db);
            _vucutAnalizRepository=new VucutAnalizRepository(db);
             tuketilenBesinlerListe = _tuketilenBesinlerRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).ToList();
            var tuketilenBesinlerID = tuketilenBesinlerListe.Select(x => x.BesinBilgileriID).ToList();
             besinlerListe = _besinlerRepository.GetAll().Where(x => tuketilenBesinlerID.Contains(x.ID));
             alinanKalori = besinlerListe.Sum(x => x.Kalori);
             harcananKalori = _egzersizlerRepository.GetAll().Where(x => x.KullaniciId == GirisYap.gelenID).Sum(x => x.HarcananKalori);
             hedefKalori = _vucutAnalizRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).Select(x => x.HedefKalori).FirstOrDefault();
            lblAlinanKalori.Text =alinanKalori.ToString();
            lblProtein.Text = besinlerListe.Sum(x => x.Protein).ToString();
            lblKarbonhidrat.Text = besinlerListe.Sum(x => x.Karbonhidrat).ToString();
            lblYag.Text = besinlerListe.Sum(x => x.Yag).ToString();
            lblHarcananKalori.Text = harcananKalori.ToString();
            lblNetKalori.Text=(hedefKalori-(decimal)alinanKalori+harcananKalori).ToString();

        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Rapor");
            Rapor rapor = new Rapor();
            rapor.KullaniciID = GirisYap.gelenID;
            rapor.HarcananKalori=harcananKalori;
            rapor.ProteinDegeri =(decimal) besinlerListe.Sum(x => x.Protein);
            rapor.YagDegeri= (decimal)besinlerListe.Sum(x => x.Yag);
            rapor.AlinanKaloriDegeri = (decimal)alinanKalori;
            rapor.HedefKaloriDegeri = hedefKalori;
            rapor.NetKaloriHesaplama();
            rapor.NeticeBulma();
            _raporRepository.Add(rapor);
          
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnasayfaForm anasayfaForm = new AnasayfaForm();
            anasayfaForm.Show();
            this.Close();
        }
    }
}
