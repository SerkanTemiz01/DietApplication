using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rapor : IBaseEntity, IRapor
    {
        public int ID { get;set; }
        public decimal AlinanKaloriDegeri { get;set; }
        public decimal HedefKaloriDegeri { get ; set; }
        public decimal KarbonhidratDegeri { get;set; }
        public decimal YagDegeri { get;set; }
        public decimal ProteinDegeri { get;set; }
        public decimal NetKalori { get;set; }
        public decimal HarcananKalori { get;set; }
        public Netice Netice { get;set; }
        public DateTime VerilisTarihi { get;set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
        
        public void NeticeBulma()
        {
            if (NetKalori >= 0)
                Netice = Netice.Ulaşıldı;
            else if (NetKalori < 0)
                Netice = Netice.Ulaşılamadı;
        }

        public void NetKaloriHesaplama()
        {
            NetKalori = HedefKaloriDegeri - AlinanKaloriDegeri + HarcananKalori;
        }
    }
}
