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
        public int ID { get; set; }
        public int? KullaniciID { get; set; }
        public decimal AlinanKalori { get; set; }
        public decimal AlinanGramaj { get; set; }
        public decimal Karbonhidrat { get; set; }
        public decimal Protein { get; set; }
        public decimal Yag { get; set; }

        public void AlınanKaloriHesaplama(decimal kalori, decimal AlınanGramaj)//kalori hesabı
        {
            this.AlinanGramaj = AlınanGramaj;
            AlinanKalori = (kalori / 100) * AlınanGramaj;
        }
        public KullaniciBilgisi Kullanici { get; set; }
        public int? BesinBilgileriID { get; set; }
        public virtual Besinler BesinBilgileri { get; set; }
        public Ogun Ogun { get; set; }
        public DateTime TuketilenTarih { get; set; } = DateTime.Now;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;

        public void BesinBilgileriDoldurma(decimal karbonhidrat,decimal yag,decimal protein,decimal _alinanGramaj)
        {
            this.Karbonhidrat = (karbonhidrat / 100) * _alinanGramaj;
            this.Yag = (yag / 100) * _alinanGramaj;
            this.Protein = (protein / 100) * _alinanGramaj;
        }
    }
}