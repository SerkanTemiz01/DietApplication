using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IAktiviteDuzeyi
    {
        int ID { get; set; }

        AktiviteDuzeyiEnum AktiviteDuzeyi1 { get; set; }
        float AktiviteKatsayisi { get; set; }
        List<KullaniciBilgisi> KullaniciBilgisi { get; set; }

        void AktiviteKatsayisiHesaplama();
    }
}
