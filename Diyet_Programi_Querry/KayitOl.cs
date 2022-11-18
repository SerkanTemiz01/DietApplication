using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.Remoting.Contexts;
using DataAccess.Context;
using DataAccess.ConcreteRepository;
using Entities.Concrete;
using System.Text.RegularExpressions;
using Entities.Enums;

namespace Diyet_Programi_Querry
{
    public partial class KayitOl : Form
    {
        private DietQueryDBContext _dietQueryDBContext;
        private KullaniciBilgisiRepository _kullaniciBilgisiRepository;
        public KayitOl()
        {
            InitializeComponent();
            _dietQueryDBContext = new DietQueryDBContext();
            _kullaniciBilgisiRepository = new KullaniciBilgisiRepository(_dietQueryDBContext);
        }
        public static KullaniciBilgisi yeniKullanici;
        private void KayitOl_Load(object sender, EventArgs e)
        {
            if (yeniKullanici == null)
            {
                Aktivite_DuzeyiForm.kullaniciBilgileriDegistirme = false;
                btnKayitOl.Text = "Kayıt Ol";
            }
            else
            {
                txtAdUyeOl.Text = yeniKullanici.Ad.ToString();
                txtSoyadUyeOl.Text = yeniKullanici.Soyad.ToString();
                txtKullaniciAdi.Text = yeniKullanici.KullaniciAd.ToString();
                txtEmailUyeOl.Text = yeniKullanici.Email.ToString();
                txtSifreUyeOl.Text = yeniKullanici.Sifre.ToString();
                btnKayitOl.Text = "Güncelle";
                
            }
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (!Aktivite_DuzeyiForm.kullaniciBilgileriDegistirme)
            {
                YeniKayit();
            }
            else
            {
                KayitGuncelleme();

            }

        }

        //----------------------------------Yeni Kayıt------------------------------------------
        private void YeniKayit()
        {
            if (txtSifreUyeOl.Text == txtSifreTekrar.Text)
            {
                bool kullaniciAdiDenetleme = Kullanici(txtKullaniciAdi.Text);
                bool EmailKontrol1 = EmailKontrol(txtEmailUyeOl.Text);
                bool sifreDenetleme = Sifre(txtSifreUyeOl.Text);
                if (kullaniciAdiDenetleme && EmailKontrol1 && sifreDenetleme)
                {
                    KullaniciBilgisi kb = new KullaniciBilgisi();
                    kb.Ad = txtAdUyeOl.Text.Trim();
                    kb.Soyad = txtSoyadUyeOl.Text.Trim();
                    kb.KullaniciAd = txtKullaniciAdi.Text;
                    kb.Email = txtEmailUyeOl.Text.Trim();
                    kb.Sifre = txtSifreUyeOl.Text;
                    yeniKullanici = kb;
                    _kullaniciBilgisiRepository.Add(kb);
                    MessageBox.Show("Başarılı bir şekilde kayıt gerçekleşmiştir");
                    Aktivite_DuzeyiForm aktvForm = new Aktivite_DuzeyiForm();
                    aktvForm.Show();
                    this.Close();
                }
                else
                {
                    if (!sifreDenetleme)
                        MessageBox.Show("Şifre istenildiği şekilde değildir");

                }

            }
            else
                MessageBox.Show("Şifreler uyuşmamaktadır");
        }

        //----------------------------------Kayit Guncelleme------------------------------------
        private void KayitGuncelleme()
        {

            if (txtSifreUyeOl.Text == txtSifreTekrar.Text)
            {
                KullaniciBilgisi degisiklik = _kullaniciBilgisiRepository.GetById(yeniKullanici.ID);
                degisiklik.Status = Status.Deleted;
                _kullaniciBilgisiRepository.Save();
                bool sifreKontrol = Sifre(txtSifreUyeOl.Text);
                if (Kullanici(txtKullaniciAdi.Text) && EmailKontrol(txtEmailUyeOl.Text) && sifreKontrol)
                {
                    degisiklik.KullaniciAd = txtKullaniciAdi.Text;
                    degisiklik.Email = txtEmailUyeOl.Text.Trim();
                    degisiklik.Sifre = txtSifreUyeOl.Text;
                    degisiklik.Status = Status.Modified;
                    degisiklik.Ad = txtAdUyeOl.Text.Trim();
                    degisiklik.Soyad = txtSoyadUyeOl.Text.Trim();
                    _kullaniciBilgisiRepository.Save();
                    Aktivite_DuzeyiForm aktvForm = new Aktivite_DuzeyiForm();
                    aktvForm.Show();
                    this.Close();
                }
                else
                {
                    if (!sifreKontrol)
                        MessageBox.Show("Şifre istenildiği şekilde değildir");
                }
            }
            else
                MessageBox.Show("Şifreler uyuşmamaktadır");
        }

        //-----------------------------------Mail var mı yok mu----------------------------------
        private  bool EmailKontrol(string Email)
        {
            
            var kullaniciBilgisi = _kullaniciBilgisiRepository.GetAll().Where(x => x.Email == Email).FirstOrDefault();
            if (kullaniciBilgisi == null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Bu Kullanıcı Maili Kullanılmaktadır. Tekrar Kullanıcı Maili Giriniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }

        //---------------------------------KullanıcıAdı var mı ---------------------------------------

        private  bool Kullanici(string KullaniciAdi)
        {
            

            KullaniciBilgisi kullaniciBilgisi =_kullaniciBilgisiRepository.GetAll().Where(x => x.KullaniciAd == KullaniciAdi).FirstOrDefault();
            if (kullaniciBilgisi == null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Bu Kullanıcı Adı Kullanılmaktadır. Tekrar Kullanıcı Adı Giriniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }

        //-------------------------------Şifre Kontrolü------------------------------
        private static int Minimum_Length = 8;
        private static int Maximum_Length = 25;
        private static int Upper_Case_length = 1;
        private static int Lower_Case_length = 1;
        private static int NonAlpha_length = 1;

        private static bool Sifre(string Parola)
        {
            bool kontrol = true;
            if (Parola.Length < Minimum_Length)
                kontrol = false;
            if (Parola.Length > Maximum_Length)
                kontrol = false;
            if (UpperCaseCount(Parola) < Upper_Case_length)
                kontrol = false;
            if (LowerCaseCount(Parola) < Lower_Case_length)
                kontrol = false;
            if (NonAlphaCount(Parola) < NonAlpha_length)
                kontrol = false;
            if (kontrol)
                return true;
            else
                return false;
        }

        private static int UpperCaseCount(string Parola)
        {
            return Regex.Matches(Parola, "[A-Z]").Count;
        }
        private static int LowerCaseCount(string Parola)
        {
            return Regex.Matches(Parola, "[a-z]").Count;
        }
        private static int NonAlphaCount(string Parola)
        {
            return Regex.Matches(Parola, @"[^0-9a-zA-Z\._]").Count;
        }

        private void btnGeriTusu_Click(object sender, EventArgs e)
        {
            if (yeniKullanici == null)
            {
                Form1 gr = new Form1();
                gr.Show();
                this.Close();
            }
            else
                MessageBox.Show("Lütfen eklediğiniz kullanıcının ileri tuşunu basarak verilerini ekleyeniz");

        }

   
    }

}

