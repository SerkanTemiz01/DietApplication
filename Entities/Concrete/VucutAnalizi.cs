using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class VucutAnalizi : IBaseEntity, IVucutAnalizi
    {
        public int ID { get;set; }
        public decimal VKI { get;set; }
        public decimal BMH { get;set; }
        public decimal HedefKalori { get;set; }
        public decimal Boyu { get;set; }
        public decimal Kilo { get;set; }
        public DateTime DogumTarihi { get;set; }
        public Cinsiyet Cinsiyet { get;set; }
        public int KullaniciID { get;set; }
        public KullaniciBilgisi KullaniciBilgisi { get;set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;

        public void BMHBulma()
        {
            int yas = DateTime.Now.Year - DogumTarihi.Year;
            if (Cinsiyet == Cinsiyet.Kadın)
                BMH = 447.593M + (Kilo * 9.247M) + (3.098M * Boyu) - (4.330M * yas);
            else if (Cinsiyet == Cinsiyet.Erkek)
                BMH = 88.362M + (13.397M * Kilo) + (4.799M * Boyu) - (5.677M * yas);
        }

        public void HedefKaloriHesaplama(decimal aktivite, decimal hedef)
        {
            HedefKalori = BMH * aktivite+ hedef;
        }

        public void VKIBulma()
        {
            VKI = Kilo /(decimal)(Math.Pow((double)Boyu, 2));
        }
    }
}
