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
        decimal GramKarsiligi { get; set; }
      
        decimal Kalori { get; set; }
        decimal Karbonhidrat { get; set; }
        decimal Protein { get; set; }
        decimal Yag { get; set; }
 
        List<TuketilenBesinler> TuketilenBesinler { get; set; }
    }
}
