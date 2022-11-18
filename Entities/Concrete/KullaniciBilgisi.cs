using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class KullaniciBilgisi : IBaseEntity, IKullaniciBilgisi
    {
        
        public int ID { get;set; }
        public string Ad { get;set; }
        public string Soyad { get;set; }
        public string KullaniciAd { get;set; }
        public string Email { get;set; }
        public string Sifre { get;set; }  
        public List<Egzersizler> Egzersizlers { get;set; }
       // int EgzersizID { get;set; }
        //Egzersizler Egzersizler { get;set; }
        public int? AktiviteDuzeyiID { get;set; }
        public virtual AktiviteDuzeyi AktiviteDuzeyi { get;set; }
        public int? HedefID { get;set; }
        public virtual KullaniciHedef KullaniciHedef { get;set; }
        //public int? VucutAnaliziID { get;set; }
        //public VucutAnalizi VucutAnalizi { get;set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
        public List<SuTakibi> SuTakibis { get; set; }
        public List<Rapor> Rapors { get ; set ; }
        public List<TuketilenBesinler> TuketilenBesinlers { get ; set; }
        public List<VucutAnalizi> VucutAnalizis { get; set; }
        public List<AdimSayisi> AdimSayisis { get; set; }
    }
}
