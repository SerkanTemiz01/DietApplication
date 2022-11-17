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
    public partial class HedefForm : Form
    {
        public HedefForm()
        {
            InitializeComponent();
        }
        DietQueryDBContext db;
        KullaniciHedefRepository _kullaniciHedefRepository;
        KullaniciBilgisi kullanici;
        KullaniciBilgisiRepository _kullaniciBilgisiRepository;
        KullaniciHedef kullaniciHedef;
        private void Hedef_Load(object sender, EventArgs e)
        {
            db=new DietQueryDBContext();
            _kullaniciBilgisiRepository = new KullaniciBilgisiRepository(db);
            _kullaniciHedefRepository=new KullaniciHedefRepository(db);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Aktivite_DuzeyiForm aktivite_Duzeyi=new Aktivite_DuzeyiForm();
            aktivite_Duzeyi.Show();
            this.Close();
        }

        private void btnKiloVermek_Click(object sender, EventArgs e)
        {
            HedefSecme(HedefEnum.Kilo_Vermek);
        }

        private void btnKilomuKorumak_Click(object sender, EventArgs e)
        {
            HedefSecme(HedefEnum.Kilo_Korumak);
        }

        private void btnKiloAlmak_Click(object sender, EventArgs e)
        {
            HedefSecme(HedefEnum.Kilo_Almak);
        }

        private void HedefSecme(HedefEnum hedefEnum)
        {
            kullaniciHedef=new KullaniciHedef();
            kullaniciHedef.Hedef = hedefEnum;
            kullaniciHedef.HedefKatSayisiHesapla();
            _kullaniciHedefRepository.Add(kullaniciHedef);
            kullanici = _kullaniciBilgisiRepository.GetById(KayitOl.yeniKullanici.ID);
            kullanici.HedefID = kullaniciHedef.ID;
            _kullaniciBilgisiRepository.Save();

            VucutAnaliziForm vctForm = new VucutAnaliziForm();
            vctForm.Show();
            this.Close();
        }
    }
}
