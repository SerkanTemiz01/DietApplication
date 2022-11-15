using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class KullaniciHedefMapping : EntityTypeConfiguration<KullaniciHedef>
    {
        public KullaniciHedefMapping()
        {
            this.Property(x => x.CreatedBy).HasMaxLength(25).HasColumnType("nvarchar");
            this.Property(x => x.DeletedBy).HasMaxLength(25).HasColumnType("nvarchar");
            this.Property(x => x.ModifiedBy).HasMaxLength(25).HasColumnType("nvarchar");
            this.HasMany(x => x.KullaniciBilgisi)
                .WithOptional(x => x.KullaniciHedef)
                .HasForeignKey(x => x.HedefID);
            //++
        }
    }
}
