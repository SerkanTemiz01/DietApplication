using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface ITuketilenBesinler
    {
        int ID { get; set; }

        int? KullaniciID { get; set; }
        KullaniciBilgisi Kullanici { get; set; }

        int? BesinBilgileriID { get; set; }
        Besinler BesinBilgileri { get; set; }

        Ogun Ogun { get; set; }
        DateTime TuketilenTarih { get; set; }
    }
}
