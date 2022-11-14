using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AktiviteDuzeyi : IBaseEntity, IAktiviteDuzeyi
    {
        public int ID { get;set; }
        public AktiviteDuzeyiEnum AktiviteDuzeyi1 { get;set; }
        public float AktiviteKatsayisi { get;set; }
        public List<Entities.KullaniciBilgisi> KullaniciBilgisi { get;set; }
        public DateTime CreatedDate { get;set; }= DateTime.Now;
        public DateTime? ModifiedDate { get;set; }
        public DateTime? DeletedDate { get;set; }
        public string CreatedBy { get;set; }
        public string DeletedBy { get;set; }
        public string ModifiedBy { get;set; }
        public Status Status { get;set; }=Status.Active;

        public void AktiviteKatsayisiHesaplama()
        {
            if (AktiviteDuzeyi1 == AktiviteDuzeyiEnum.Genellikle_Hareketsiz)
                AktiviteKatsayisi = 1.2F;
            else if (AktiviteDuzeyi1 == AktiviteDuzeyiEnum.Az_Hareketli)
                AktiviteKatsayisi = 1.375F;
            else if (AktiviteDuzeyi1 == AktiviteDuzeyiEnum.Hareketli)
                AktiviteKatsayisi = 1.55F;
            else if (AktiviteDuzeyi1 == AktiviteDuzeyiEnum.Cok_Hareketli)
                AktiviteKatsayisi = 1.75F;
        }
    }
}
