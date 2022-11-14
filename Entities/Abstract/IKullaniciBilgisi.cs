using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IKullaniciBilgisi
    {
         int ID { get; set; }
         string Ad { get; set; }
         string Soyad { get; set; }
         string KullaniciAd { get; set; }
         string Mail { get; set; }
         string Email { get; set; }
         string Sifre { get; set; }
         List<Egzersizler> Egzersizlers { get; set; }
         int? AktiviteDuzeyiID { get; set; }
         AktiviteDuzeyi AktiviteDuzeyi { get; set; }
        int? HedefID { get;set; }
        KullaniciHedef KullaniciHedef { get; set; }

        int? VucutAnaliziID { get; set; }
        VucutAnalizi VucutAnalizi { get; set; }

        List<SuTakibi> SuTakibis { get; set; }
    }
}
