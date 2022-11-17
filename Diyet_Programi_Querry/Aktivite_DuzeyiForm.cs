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
    public partial class Aktivite_DuzeyiForm : Form
    {
        public Aktivite_DuzeyiForm()
        {
            InitializeComponent();
        }
        DietQueryDBContext db;
        AktiviteDuzeyiRepository aktiviteDuzeyiRepository;
        KullaniciBilgisi kullanici;
        AktiviteDuzeyi aktiviteDuzeyi;
        KullaniciBilgisiRepository kullaniciBilgisiRepository;
        private void Aktivite_Duzeyi_Load(object sender, EventArgs e)
        {
            db = new DietQueryDBContext();
            aktiviteDuzeyiRepository = new AktiviteDuzeyiRepository(db);
            kullaniciBilgisiRepository = new KullaniciBilgisiRepository(db);
        }
        private void btnGenellikleHareketsiz_Click(object sender, EventArgs e)
        {
            AktiviteDuzeyiSecme(AktiviteDuzeyiEnum.Genellikle_Hareketsiz);
        }


        private void btnAzHareketli_Click(object sender, EventArgs e)
        {
            AktiviteDuzeyiSecme(AktiviteDuzeyiEnum.Az_Hareketli);
        }

        private void btnHareketli_Click(object sender, EventArgs e)
        {
            AktiviteDuzeyiSecme(AktiviteDuzeyiEnum.Hareketli);
        }

        private void btnCokHareketli_Click(object sender, EventArgs e)
        {
            AktiviteDuzeyiSecme(AktiviteDuzeyiEnum.Cok_Hareketli);
        }
        private void AktiviteDuzeyiSecme(AktiviteDuzeyiEnum aktiviteDuzeyiEnum)
        {
            aktiviteDuzeyi = new AktiviteDuzeyi();
            aktiviteDuzeyi.AktiviteDuzeyi1 = aktiviteDuzeyiEnum;
            aktiviteDuzeyi.AktiviteKatsayisiHesaplama();
            aktiviteDuzeyiRepository.Add(aktiviteDuzeyi);
            kullanici = kullaniciBilgisiRepository.GetById(KayitOl.yeniKullanici.ID);
            kullanici.AktiviteDuzeyiID = aktiviteDuzeyi.ID;
            kullaniciBilgisiRepository.Save();
            HedefForm hedef = new HedefForm();
            hedef.Show();
            this.Close();
        }
       
    }
}
