using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SuTakibi : IBaseEntity, ISuTakibi
    {
        public int ID { get;set; }
        public int BardakAdeti { get;set; }
        public float SuMiktari { get;set; }

        public DateTime TuketilenTarih { get;set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
        public int? KullaniciID { get ; set ; }
        public KullaniciBilgisi KullaniciBilgisi { get ; set ; }

        public void SuMiktariBulma()
        {
            SuMiktari = BardakAdeti * 200;
        }
    }
}
