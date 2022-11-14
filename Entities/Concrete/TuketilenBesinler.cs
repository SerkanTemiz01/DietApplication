using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TuketilenBesinler : IBaseEntity, ITuketilenBesinler
    {
        public int ID { get;set; }
        public int KullaniciID { get;set; }
        public Entities.KullaniciBilgisi Kullanici { get;set; }
        public int BesinBilgileriID { get;set; }
        public Besinler BesinBilgileri { get;set; }
        public Ogun Ogun { get;set; }
        public DateTime TuketilenTarih { get;set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
