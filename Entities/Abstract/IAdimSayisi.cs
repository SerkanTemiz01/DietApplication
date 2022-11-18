using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IAdimSayisi
    {
        int ID { get; set; }
        int AdimSayisi1 { get; set; }
        decimal AdimHarcananKalori { get; set; }
        int? KullaniciID { get; set; }      
        KullaniciBilgisi KullaniciBilgisi { get; set; }
        void HarcaKaloriBulma();
        
    }
}
