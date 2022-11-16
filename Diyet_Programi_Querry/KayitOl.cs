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

namespace Diyet_Programi_Querry
{
    public partial class KayitOl : Form
    {
        private  DietQueryDBContext _dietQueryDBContext;
        private  KullaniciBilgisiRepository _kullaniciBilgisiRepository;




        public KayitOl()
        {
            InitializeComponent();
            _dietQueryDBContext = new DietQueryDBContext();
            _kullaniciBilgisiRepository = new KullaniciBilgisiRepository(_dietQueryDBContext);
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {

            KullaniciBilgisi kb = new KullaniciBilgisi();
            kb.Ad = txtAdUyeOl.Text.Trim();
            kb.Soyad = txtSoyadUyeOl.Text.Trim();
            if (Kullanici(txtKullaniciAdi.Text)==true)
            {
                kb.KullaniciAd = txtKullaniciAdi.Text;
            }
            else
            {
                txtKullaniciAdi.Clear();
            }
            if (EmailKontrol(txtEmailUyeOl.Text)==true)
            {
                kb.Email = txtEmailUyeOl.Text.Trim();
            }
            else
            {
                txtEmailUyeOl.Clear();
            }
            if (Sifre(txtSifreUyeOl.Text)==true)
            {
                kb.Sifre = txtSifreUyeOl.Text;
            }
            else
            {
                txtSifreUyeOl.Clear();
                txtSifreTekrar.Clear();
            }
            _kullaniciBilgisiRepository.Add(kb);
           
        }
        //-----------------------------------Mail var mı yok mu----------------------------------
        public static bool EmailKontrol(string Email)
        {


            DietQueryDBContext db = new DietQueryDBContext();
            KullaniciBilgisi kullaniciBilgisi = db.KullaniciBilgisis.Where(x => x.Email == Email).FirstOrDefault();
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

        public static bool Kullanici(string KullaniciAdi)
        {
           

            DietQueryDBContext db = new DietQueryDBContext();
             KullaniciBilgisi kullaniciBilgisi =db.KullaniciBilgisis.Where(x=>x.KullaniciAd==KullaniciAdi).FirstOrDefault();
            if (kullaniciBilgisi==null)
            {
                return  true;
            }
            else
            {
                MessageBox.Show("Bu Kullanıcı Adı Kullanılmaktadır. Tekrar Kullanıcı Adı Giriniz...","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }

        }




        //-------------------------------Şifre Kontrolü------------------------------
        private static int Minimum_Length = 8;
        private static int Maximum_Length = 25;
        private static int Upper_Case_length = 2;
        private static int Lower_Case_length = 2;
        private static int NonAlpha_length = 1;
        private static int Numeric_length = 1;



        public static bool Sifre(string Parola)
        {
            if (Parola.Length < Minimum_Length)
                return false;
            if (Parola.Length > Maximum_Length)
                return false;
            if (UpperCaseCount(Parola) < Upper_Case_length)
                return false;
            if (NumericCount(Parola) < Numeric_length)
                return false;
            if (LowerCaseCount(Parola) < Lower_Case_length)
                return false;
            if (NonAlphaCount(Parola) < NonAlpha_length)
                return false;
            return true;
        }

        private static int UpperCaseCount(string Parola)
        {
            return Regex.Matches(Parola, "[A-Z]").Count;
        }
        private static int LowerCaseCount(string Parola)
        {
            return Regex.Matches(Parola, "[a-z]").Count;
        }
        private static int NumericCount(string Parola)
        {
            return Regex.Matches(Parola, "[0-9]").Count;
        }
        private static int NonAlphaCount(string Parola)
        {
            return Regex.Matches(Parola, @"[^0-9a-zA-Z\._]").Count;
        }


    }

}

