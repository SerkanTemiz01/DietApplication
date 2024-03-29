﻿using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class KullaniciHedef : IBaseEntity, IKullaniciHedef
    {
        public int ID { get;set; }
        public HedefEnum Hedef { get;set; }
        public decimal HedefKatsayisi { get;set; }
        public List<KullaniciBilgisi> KullaniciBilgisi { get;set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;

        public void HedefKatSayisiHesapla()
        {
            if (HedefEnum.Kilo_Vermek ==Hedef)
                HedefKatsayisi = -200;
            else if (HedefEnum.Kilo_Almak == Hedef)
                HedefKatsayisi = +200;
            else
                HedefKatsayisi = 0;
        }
    }
}
