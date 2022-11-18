using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Besinler : IBaseEntity, IBesinler
    {
        public int ID { get;set; }
        public string BesinAdi { get;set; }
        public decimal GramKarsiligi { get;set; }
        public decimal Kalori { get;set; }
        public decimal Karbonhidrat { get;set; }
        public decimal Protein { get;set; }
        public decimal Yag { get;set; }
        public List<TuketilenBesinler> TuketilenBesinler { get;set; }
        public DateTime CreatedDate { get;set; }=DateTime.Now;
        public DateTime? ModifiedDate { get;set; }
        public DateTime? DeletedDate { get;set; }
        public string CreatedBy { get;set; }
        public string DeletedBy { get;set; }
        public string ModifiedBy { get;set; }
        public Status Status { get; set; } = Status.Active;
    }
}
