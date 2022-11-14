using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface ISuTakibi
    {
        int ID { get; set; }
        int BardakAdeti { get; set; }

        float SuMiktari { get; set; }

        DateTime TuketilenTarih { get; set; }

        int KullaniciID { get; set; }
        KullaniciBilgisi KullaniciBilgisi { get; set; }

        void SuMiktariBulma();
    }
}
