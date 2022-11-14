using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IEgzersizler
    {
        int ID { get; set; }
        Egzersiz Egzersiz { get; set; }

        int Sure { get; set; }
        decimal HarcananKalori { get; set; }

        int? KullaniciId { get; set; }
        KullaniciBilgisi KullaniciBilgisi { get; set; }

        void HarcananKaloriHesaplama();
    }
}
