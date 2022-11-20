using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Egzersizler : IBaseEntity, IEgzersizler
    {
        public int ID { get; set; }
        public EgzersizEnum Egzersiz { get; set; }
        public int Sure { get; set; }
        public decimal HarcananKalori { get; set; }
        public int? KullaniciId { get; set; }
        public KullaniciBilgisi KullaniciBilgisi { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;

        public void HarcananKaloriHesaplama()
        {
            switch (Egzersiz)
            {
                case EgzersizEnum.GucAntremani:
                    HarcananKalori += (4.5M * Sure);//
                    break;
                case EgzersizEnum.Yuruyus:
                    HarcananKalori += (3.67M * Sure);//
                    break;
                case EgzersizEnum.BisikleteBinme:
                    HarcananKalori += (11.67M * Sure);//
                    break;
                case EgzersizEnum.Kosu:
                    HarcananKalori += (17.9M * Sure);//
                    break;
                case EgzersizEnum.KondisyonBisikleti:
                    HarcananKalori += (10.5M * Sure);//
                    break;
                case EgzersizEnum.Yoga:
                    HarcananKalori += 5 * Sure;//
                    break;
                case EgzersizEnum.Yuzme:
                    HarcananKalori += (12 * Sure);//
                    break;
                case EgzersizEnum.Boks:
                    HarcananKalori += (10.83M * Sure);//
                    break;
                case EgzersizEnum.DansEtmek:
                    HarcananKalori += (2.5M * Sure);//
                    break;
                case EgzersizEnum.EvdeYapilanEgzersiz:
                    HarcananKalori += 7 * Sure;
                    break;
                case EgzersizEnum.Futbol:
                    HarcananKalori += (8 * Sure);//
                    break;
                case EgzersizEnum.KickBoks:
                    HarcananKalori += (11 * Sure);//
                    break;
                case EgzersizEnum.Kurek:
                    HarcananKalori += (9.33M * Sure);//
                    break;
                case EgzersizEnum.Voleybol:
                    HarcananKalori += (4.67M * Sure);
                    break;
                case EgzersizEnum.Basketbol:
                    HarcananKalori += (9.6M * Sure);//
                    break;
                case EgzersizEnum.Jimnastik:
                    HarcananKalori += 5 * Sure;//
                    break;
                case EgzersizEnum.Zumba:
                    HarcananKalori += 3 * Sure;
                    break;
                case EgzersizEnum.Hentbol:
                    HarcananKalori += 9 * Sure;
                    break;
                case EgzersizEnum.Airsoft:
                    HarcananKalori += 12 * Sure;
                    break;
                case EgzersizEnum.AdimSayisi:
                    HarcananKalori += 3.67M * Sure;
                    break;
            }
        }
    }
}
