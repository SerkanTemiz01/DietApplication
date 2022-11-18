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
        public int ID { get;set; }
        public Egzersiz Egzersiz { get;set; }
        public int Sure { get;set; }
        public decimal HarcananKalori { get;set; }
        public int? KullaniciId { get;set; }
        public KullaniciBilgisi KullaniciBilgisi { get;set; }
        public DateTime CreatedDate { get;set; }=DateTime.Now;
        public DateTime? ModifiedDate { get;set; }
        public DateTime? DeletedDate { get;set; }
        public string CreatedBy { get;set; }
        public string DeletedBy { get;set; }
        public string ModifiedBy { get;set; }
        public Status Status { get; set; } = Status.Active;

        public void HarcananKaloriHesaplama()
        {          
            switch (Egzersiz)
            {
                case Egzersiz.GucAntremani:
                    HarcananKalori+= 5 * Sure;
                    break;
                case Egzersiz.Yuruyus:
                    HarcananKalori+= 4 * Sure;
                    break;
                case Egzersiz.BisikleteBinme:
                    HarcananKalori += 3 * Sure;
                    break;
                case Egzersiz.Kosu:
                    HarcananKalori += 6 * Sure;
                    break;
                case Egzersiz.KondisyonBisikleti:
                    HarcananKalori += 4 * Sure;
                    break;
                case Egzersiz.Yoga:
                    HarcananKalori += 2 * Sure;
                    break;
                case Egzersiz.Yuzme:
                    HarcananKalori += 5 * Sure;
                    break;
                case Egzersiz.Boks:
                    HarcananKalori += 6 * Sure;
                    break;                
                case Egzersiz.DansEtmek:
                    HarcananKalori += 6 * Sure;
                    break;
                case Egzersiz.EvdeYapilanEgzersiz:
                    HarcananKalori += 3 * Sure;
                    break;               
                case Egzersiz.Futbol:
                    HarcananKalori += 6 * Sure;
                    break;
                case Egzersiz.KickBoks:
                    HarcananKalori += 4 * Sure;
                    break;
                case Egzersiz.Kurek:
                    HarcananKalori += 2 * Sure;
                    break;
                case Egzersiz.Voleybol:
                    HarcananKalori += 2 * Sure;
                    break;
                case Egzersiz.Basketbol:
                    HarcananKalori += 5 * Sure;
                    break;
                case Egzersiz.Jimnastik:
                    HarcananKalori += 3 * Sure;
                    break;
                case Egzersiz.Zumba:
                    HarcananKalori += 5 * Sure;
                    break;
                case Egzersiz.Hentbol:
                    HarcananKalori += 5 * Sure;
                    break;
                case Egzersiz.Airsoft:
                    HarcananKalori += 5 * Sure;
                    break;
                case Egzersiz.AdimSayisi:
                    HarcananKalori += 4 * Sure;
                        break;
            }
            
        }
    }
}
