using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IKullaniciHedef
    {
        int ID { get; set; }

        Hedef Hedef { get; set; }

        decimal HedefKatsayisi { get; set; }

        List<KullaniciBilgisi> KullaniciBilgisi { get; set; }

        void HedefKatSayisiHesapla(Hedef hedef);
    }
}
