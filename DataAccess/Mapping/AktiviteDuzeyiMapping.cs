using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class AktiviteDuzeyiMapping:EntityTypeConfiguration<AktiviteDuzeyi>
    {
        public AktiviteDuzeyiMapping()
        {
            this.Property(x => x.CreatedBy).HasMaxLength(25).HasColumnType("nvarchar");
            this.Property(x => x.DeletedBy).HasMaxLength(25).HasColumnType("nvarchar");
            this.Property(x => x.ModifiedBy).HasMaxLength(25).HasColumnType("nvarchar");
            this.HasMany(x => x.KullaniciBilgisi)
                .WithOptional(x => x.AktiviteDuzeyi)
                .HasForeignKey(x => x.AktiviteDuzeyiID);
            //++
        }
    }
}
