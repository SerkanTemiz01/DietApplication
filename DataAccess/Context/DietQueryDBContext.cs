using DataAccess.Mapping;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class DietQueryDBContext:DbContext
    {
        public DietQueryDBContext():base("server=DESKTOP-491CL38\\YAYLALISERVER22;database=FitQUERYDB;Trusted_Connection=True;") 
        {
           

        }
        public DbSet<AktiviteDuzeyi> AktiviteDuzeyis { get; set; }
        public DbSet<Besinler> Besinlers { get; set; }
        public DbSet<Egzersizler> Egzersizlers { get; set; }
        public DbSet<KullaniciBilgisi> KullaniciBilgisis { get; set; }
        public DbSet<KullaniciHedef> KullaniciHedefs { get; set; }
        public DbSet<Rapor> Rapors { get; set; }
        public DbSet<SuTakibi> SuTakibis { get; set; }
        public DbSet<TuketilenBesinler> TuketilenBesinlers { get; set; }
        public DbSet<VucutAnalizi> VucutAnalizis { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AktiviteDuzeyiMapping())
                .Add(new BesinlerMapping())
                .Add(new EgzersizlerMapping())
                .Add(new KullaniciBilgisiMapping())
                .Add(new KullaniciHedefMapping())
                .Add(new RaporMapping())
                .Add(new SuTakibiMapping())
                .Add(new TuketilenBesinlerMapping())
                .Add(new VucutAnalizMapping());
                
            
        }
    }
}
