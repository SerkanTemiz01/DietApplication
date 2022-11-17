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
    public partial class VucutAnaliziForm : Form
    {
        public VucutAnaliziForm()
        {
            InitializeComponent();
        }
        DietQueryDBContext db;
        VucutAnalizRepository _vucutAnalizRepository;

        KullaniciBilgisi kullanici;
        KullaniciBilgisiRepository _kullaniciBilgisiRepository;
        
        private void VucutAnalizi_Load(object sender, EventArgs e)
        {
            db = new DietQueryDBContext();
            _kullaniciBilgisiRepository = new KullaniciBilgisiRepository(db);
            _vucutAnalizRepository = new VucutAnalizRepository(db);
          
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            HedefForm hedefForm = new HedefForm();
            hedefForm.Show();
            this.Close();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtBoy.Text) < 250 && int.Parse(txtKilo.Text) < 250&& int.Parse(txtBoy.Text) >50 && int.Parse(txtKilo.Text) > 30)
            {
                VucutAnalizi vucutAnalizi=new VucutAnalizi();
                vucutAnalizi.Boyu = Convert.ToDecimal(txtBoy.Text);
                vucutAnalizi.Kilo= Convert.ToDecimal(txtKilo.Text);
                if (rdbErkek.Checked)
                    vucutAnalizi.Cinsiyet = Cinsiyet.Erkek;
                else
                    vucutAnalizi.Cinsiyet = Cinsiyet.Kadın;
                vucutAnalizi.DogumTarihi = dtpDogumTarihi.Value;
                vucutAnalizi.VKIBulma();
                vucutAnalizi.BMHBulma();
                kullanici = _kullaniciBilgisiRepository.GetById(KayitOl.yeniKullanici.ID);
                vucutAnalizi.HedefKaloriHesaplama(kullanici.AktiviteDuzeyi.AktiviteKatsayisi,kullanici.KullaniciHedef.HedefKatsayisi);
                vucutAnalizi.KullaniciID=kullanici.ID;
                _vucutAnalizRepository.Add(vucutAnalizi);
                lblVKI.Text = vucutAnalizi.VKI.ToString();
                lblBMH.Text=vucutAnalizi.BMH.ToString();
            }
            else
                MessageBox.Show("Girdiğiniz aralıkta bir hesaplama yapılamaz");
            
        }

        private void txtBoy_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ayrac = ',';// buraya istediğiniz bir ayracı yazabilirsiniz.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ayrac))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ayrac) && ((sender as TextBox).Text.IndexOf(ayrac) > -1))//İlk karakterin '.' olup olmadığını kontrol ediyoruzuz
            {
                e.Handled = true;//Değilse görmezden geliyoruz.
            }
        }

        private void btnileri_Click(object sender, EventArgs e)
        {
            GirisYap girisYap = new GirisYap();
            girisYap.Show();
            this.Close();
        }
    }
}
