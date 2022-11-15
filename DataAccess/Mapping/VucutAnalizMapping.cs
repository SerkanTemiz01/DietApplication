using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class VucutAnalizMapping : EntityTypeConfiguration<VucutAnalizi>
    {
        public VucutAnalizMapping()
        {
            this.Property(x => x.CreatedBy).HasMaxLength(25).HasColumnType("nvarchar");
            this.Property(x => x.DeletedBy).HasMaxLength(25).HasColumnType("nvarchar");
            this.Property(x => x.ModifiedBy).HasMaxLength(25).HasColumnType("nvarchar");
            this.HasOptional(m => m.KullaniciBilgisi)
                 .WithRequired(mr => mr.VucutAnalizi).WillCascadeOnDelete(false);
            ///+++

        }
    }
}
