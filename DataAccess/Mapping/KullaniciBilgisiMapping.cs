using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KullaniciBilgisi = Entities.Concrete.KullaniciBilgisi;

namespace DataAccess.Mapping
{
    public class KullaniciBilgisiMapping : EntityTypeConfiguration<KullaniciBilgisi>
    {
        public KullaniciBilgisiMapping()
        {
            this.HasKey(x => x.ID);
            this.Property(x => x.CreatedBy).HasMaxLength(25).HasColumnType("nvarchar");
            this.Property(x => x.DeletedBy).HasMaxLength(25).HasColumnType("nvarchar");
            this.Property(x => x.ModifiedBy).HasMaxLength(25).HasColumnType("nvarchar");
            //bir kişi birden çok egzersiz yapabilir
            this.HasMany(x => x.Egzersizlers)
           .WithOptional(x => x.KullaniciBilgisi)
           .HasForeignKey(x => x.KullaniciId);

            //bir kişi birden fazla su içer
            this.HasMany(x => x.SuTakibis)
           .WithOptional(x => x.KullaniciBilgisi)
           .HasForeignKey(x => x.KullaniciID);

            //bir kişinin birden fazla raporu olmalı 
            this.HasMany(x => x.Rapors)
          .WithOptional(x => x.KullaniciBilgisi)
          .HasForeignKey(x => x.KullaniciID);


            //tüketilen besni birden çok kişi tüketebilir
            this.HasMany(x => x.TuketilenBesinlers)
          .WithOptional(x => x.Kullanici)
          .HasForeignKey(x => x.KullaniciID);
        }
    }
}
