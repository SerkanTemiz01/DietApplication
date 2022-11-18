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
using DataAccess.ConcreteRepository;
using DataAccess.Context;
using Entities.Concrete;
using Microsoft.VisualBasic;

namespace Diyet_Programi_Querry
{
    public partial class AnasayfaForm : Form
    {
        public AnasayfaForm()
        {
            InitializeComponent();
            db = new DietQueryDBContext();
            _kullaniciBilgisiRepository = new KullaniciBilgisiRepository(db);
            _vucutAnalizRepository = new VucutAnalizRepository(db);
            _egzersizlerRepository = new EgzersizlerRepository(db);
            _tuketilenBesinlerRepository = new TuketilenBesinlerRepository(db);
            _besinlerRepository = new BesinlerRepository(db);
            _suTakibiRepository = new SuTakibiRepository(db);
          
        }
        private DietQueryDBContext db;
        private KullaniciBilgisiRepository _kullaniciBilgisiRepository;
        private VucutAnalizRepository _vucutAnalizRepository;
        private EgzersizlerRepository _egzersizlerRepository;
        private TuketilenBesinlerRepository _tuketilenBesinlerRepository;
        private BesinlerRepository _besinlerRepository;
        private SuTakibiRepository _suTakibiRepository;
        private void lblHarcananKalori_Click(object sender, EventArgs e)
        {
            //asadajjcjajakkkaas26626
        }
        VucutAnalizi vucutAnalizi;
        long oranKalori;
        long alinanKalori;
        float icilenSuMiktari;
        private void Menü_Load(object sender, EventArgs e)
        {
            KullaniciBilgisi kullanici = _kullaniciBilgisiRepository.GetById(GirisYap.gelenID);
            vucutAnalizi = _vucutAnalizRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).FirstOrDefault();
            var egzersiz = _egzersizlerRepository.GetAll().Where(x => x.KullaniciId == GirisYap.gelenID).ToList();
            pnlMenu.Visible = false;
            List<int?> tuketilenBesinlerListe = _tuketilenBesinlerRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).Select(x=>x.BesinBilgileriID).ToList();
            //var besinlerListe = _besinlerRepository.GetAll().Where(x => tuketilenBesinlerListe.Contains(x.ID));
            var tuketilenBesinler = _tuketilenBesinlerRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).ToList();
            alinanKalori = (long)tuketilenBesinler.Sum(x => x.AlinanKalori);
            var hedefKalori = vucutAnalizi.HedefKalori;
            float icilmesiGerekenSu = (float)(vucutAnalizi.Kilo / 25M * 1000);
            oranKalori =(long)((decimal)alinanKalori / hedefKalori*100);
            circularProgressBar1.Value = (long)(((decimal)alinanKalori/hedefKalori)*100);
            circularProgressBar1.alinanKalori = (long)alinanKalori;
            lblEgzersizKalori.Text = egzersiz.Sum(x=>x.HarcananKalori).ToString();
            lblHedefKalori.Text = hedefKalori.ToString();
            lblBoy.Text = vucutAnalizi.Boyu.ToString();
            lblAdSoyad.Text = kullanici.Ad + " " + kullanici.Soyad;
            lblKilo.Text = vucutAnalizi.Kilo.ToString();
            lblVücutKitleİndeksi.Text = vucutAnalizi.VKI.ToString();
            lblYas.Text = (DateTime.Now.Year - vucutAnalizi.DogumTarihi.Year).ToString();
            var suListesi = _suTakibiRepository.GetAll().Where(x => x.KullaniciID == GirisYap.gelenID).ToList();
            icilenSuMiktari = suListesi.Sum(x => x.SuMiktari);
            circularProgressBar2.Value = (long)((icilenSuMiktari / icilmesiGerekenSu)*100);
            circularProgressBar2.alinanKalori =(long) icilenSuMiktari;
            lblSu.Text = icilmesiGerekenSu.ToString();
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
            if(i>oranKalori)
            {
                timer1.Stop();
                circularProgressBar1.Value=oranKalori;
                
            }
                
        }

        private void lblKilo_Click(object sender, EventArgs e)
        {
            string ilkDegerKilo = lblKilo.Text;
            string kiloVerisi= Interaction.InputBox("Kilo giriniz.", "Yeni Kilo Girişi", lblKilo.Text, this.Width/2, this.Height/2);
            
            if (int.TryParse(kiloVerisi, out int value))
            {
                vucutAnalizi.Kilo=Convert.ToDecimal(value);
                _vucutAnalizRepository.Save();
                lblKilo.Text = value.ToString();
            }
            else
            {
                lblKilo.Text = ilkDegerKilo;
                if(kiloVerisi!="")
                lblKilo_Click(sender, e);
            }
                
        }

        private void btnOgunGirisi_Click(object sender, EventArgs e)
        {
            OgunGirisi ogunGirisi = new OgunGirisi();
            ogunGirisi.Show();
            this.Close();
        }

        private void btnAdimSayisi_Click(object sender, EventArgs e)
        {
           AdimSayisi oadimSayisi = new AdimSayisi();
            oadimSayisi.Show();
            this.Close();
        }

        private void btnSu_Click(object sender, EventArgs e)
        {
            SuEkle suEkle = new SuEkle();
            suEkle.Show();
            this.Close();
        }

        private void btnKronometre_Click(object sender, EventArgs e)
        {
            Kronometre kronometre = new Kronometre();
            kronometre.Show();
            this.Close();
        }

        private void btnEgzersiz_Click(object sender, EventArgs e)
        {
            Egzersiz egzersiz = new Egzersiz();
            egzersiz.Show();
            this.Close();
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            Raporlama rp = new Raporlama();
            rp.Show();
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int j;
        private void circularProgressBar2_Click(object sender, EventArgs e)
        {

            timer2.Start();
            timer2.Interval = 10;
            j = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            circularProgressBar2.Value = j;
            j++;
            if (j > ((icilenSuMiktari / 2500F) * 100))
            {
                timer2.Stop();
                
            }
        }
    }
}
