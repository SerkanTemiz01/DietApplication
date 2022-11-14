using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IBesinler
    {
        int ID { get; set; }
        string BesinAdi { get; set; }
        float GramKarsiligi { get; set; }

        float Kalori { get; set; }
        float Karbonhidrat { get; set; }
        float Protein { get; set; }
        float Yag { get; set; }
 
        List<TuketilenBesinler> TuketilenBesinler { get; set; }
    }
}
