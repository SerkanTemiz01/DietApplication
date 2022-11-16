using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IVucutAnalizi
    {
        int ID { get; set; }

        decimal VKI { get; set; }

        decimal BMH { get; set; }
        decimal HedefKalori { get; set; }
        decimal Boyu { get; set; }

        decimal Kilo { get; set; }

        DateTime DogumTarihi { get; set; }

        Cinsiyet Cinsiyet { get; set; }

        int? KullaniciID { get; set; }
        KullaniciBilgisi KullaniciBilgisi { get; set; }

        void VKIBulma();
        void BMHBulma();

        void HedefKaloriHesaplama(decimal aktivite, decimal hedefKatsayisi);
    }
}
