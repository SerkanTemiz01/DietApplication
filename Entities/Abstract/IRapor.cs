using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IRapor
    {
        int ID { get; set; }
        decimal AlinanKaloriDegeri { get; set; }
        decimal HedefKaloriDegeri { get; set; }
        decimal KarbonhidratDegeri { get; set; }
        decimal YagDegeri { get; set; }
        decimal ProteinDegeri { get; set; }
        decimal NetKalori { get; set; }
        decimal HarcananKalori { get; set; } //Sıfır default olarak atanacak...
        /// <summary>
        /// RAmazanın neticesi....
        /// </summary>
        Netice Netice { get; set; }
        DateTime VerilisTarihi { get; set; }

        int? KullaniciID { get; set; }
        KullaniciBilgisi KullaniciBilgisi { get; set; }

        void NetKaloriHesaplama();

        void NeticeBulma();
    }
}
