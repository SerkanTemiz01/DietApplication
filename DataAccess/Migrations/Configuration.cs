namespace DataAccess.Migrations
{
    using Entities.Concrete;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.Context.DietQueryDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DataAccess.Context.DietQueryDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //BALIKLAR VE DENİZ ÜRÜNLERİ



            Besinler somon = new Besinler() { BesinAdi = "Somon", Kalori = 2.08m, Karbonhidrat = 0, Protein = 0.19m, Yag = 0.13m, CreatedBy = "Admin" };
            context.Besinlers.Add(somon);



            Besinler ahtapot = new Besinler() { BesinAdi = "Ahtapot", Kalori = 0.73m, Karbonhidrat = 0.01m, Protein = 0.15m, Yag = 0.08m, CreatedBy = "Admin" };
            context.Besinlers.Add(ahtapot);



            Besinler alabalik = new Besinler() { BesinAdi = "Alabalık", Kalori = 1.01m, Karbonhidrat = 0, Protein = 0.19m, Yag = 0.02m, CreatedBy = "Admin" };
            context.Besinlers.Add(alabalik);



            Besinler barbun = new Besinler() { BesinAdi = "Barbun", Kalori = 1.2m, Karbonhidrat = 0, Protein = 0.16m, Yag = 0.06m, CreatedBy = "Admin" };
            context.Besinlers.Add(barbun);



            Besinler cipura = new Besinler() { BesinAdi = "Çipura", Kalori = 1.2m, Karbonhidrat = 0, Protein = 0.16m, Yag = 0.06m, CreatedBy = "Admin" };
            context.Besinlers.Add(cipura);



            Besinler dilBaligi = new Besinler() { BesinAdi = "Dil Balığı", Kalori = 0.79m, Karbonhidrat = 0, Protein = 0.19m, Yag = 0, CreatedBy = "Admin" };
            context.Besinlers.Add(dilBaligi);



            Besinler hamsiIzgara = new Besinler() { BesinAdi = "Izgara Hamsi", Kalori = 2m, Karbonhidrat = 0.05m, Protein = 0.19m, Yag = 0.1m, CreatedBy = "Admin" };
            context.Besinlers.Add(hamsiIzgara);



            Besinler hamsiKizartma = new Besinler() { BesinAdi = "Kızartma Hamsi", Kalori = 1.15m, Yag = 0.05m, Karbonhidrat = 0, Protein = 0.17m, CreatedBy = "Admin" };
            context.Besinlers.Add(hamsiKizartma);



            Besinler havyar = new Besinler() { BesinAdi = "Havyar", Kalori = 2.62m, Karbonhidrat = 0.03m, Protein = 0.26m, Yag = 0.15m, CreatedBy = "Admin" };
            context.Besinlers.Add(havyar);



            Besinler istakoz = new Besinler() { BesinAdi = "Istakoz", Kalori = 0.91m, Karbonhidrat = 0m, Protein = 0.17m, Yag = 0.02m, CreatedBy = "Admin" };
            context.Besinlers.Add(istakoz);



            Besinler istavrit = new Besinler() { BesinAdi = "İstavrit", Kalori = 0.81m, Karbonhidrat = 0m, Protein = 0.17m, Yag = 0.01m, CreatedBy = "Admin" };
            context.Besinlers.Add(istavrit);



            Besinler istiridye = new Besinler() { BesinAdi = "İstiridye", Kalori = 0.68m, Karbonhidrat = 0m, Protein = 0.09m, Yag = 0.01m, CreatedBy = "Admin" };
            context.Besinlers.Add(istiridye);



            Besinler izmarit = new Besinler() { BesinAdi = "İzmarit", Kalori = 1.53m, Karbonhidrat = 0m, Protein = 0.23m, Yag = 0.06m, CreatedBy = "Admin" };
            context.Besinlers.Add(izmarit);



            Besinler kalkan = new Besinler() { BesinAdi = "Kalkan Balığı", Kalori = 1.35m, Karbonhidrat = 0m, Protein = 0.20m, Yag = 0.06m, CreatedBy = "Admin" };
            context.Besinlers.Add(kalkan);



            Besinler karidesGuvec = new Besinler() { BesinAdi = "Karides Güveç", Kalori = 1.25m, Karbonhidrat = 0.02m, Protein = 0.16m, Yag = 0.07m, CreatedBy = "Admin" };
            context.Besinlers.Add(karidesGuvec);



            Besinler tereyagdaKarides = new Besinler() { BesinAdi = "Tereyağda Karides", Kalori = 3.19m, Karbonhidrat = 0m, Protein = 0.16m, Yag = 0.29m, CreatedBy = "Admin" };
            context.Besinlers.Add(tereyagdaKarides);



            Besinler kefal = new Besinler() { BesinAdi = "Kefal Balığı", Kalori = 1.73m, Karbonhidrat = 0m, Protein = 0.19m, Yag = 0, CreatedBy = "Admin" };
            context.Besinlers.Add(kefal);



            Besinler kilic = new Besinler() { BesinAdi = "Kılıç Balığı", Kalori = 1.53m, Karbonhidrat = 0m, Protein = 0.23m, Yag = 0.06m, CreatedBy = "Admin" };
            context.Besinlers.Add(kilic);



            Besinler levrek = new Besinler() { BesinAdi = "İzmarit", Kalori = 0.86m, Karbonhidrat = 0m, Protein = 0.18m, Yag = 0, CreatedBy = "Admin" };
            context.Besinlers.Add(levrek);



            Besinler lufer = new Besinler() { BesinAdi = "Lüfer", Kalori = 1.37m, Karbonhidrat = 0m, Protein = 0.16m, Yag = 0.09m, CreatedBy = "Admin" };
            context.Besinlers.Add(lufer);



            Besinler mezgit = new Besinler() { BesinAdi = "Mezgit", Kalori = 0.82m, Karbonhidrat = 0m, Protein = 0.18m, Yag = 0.06m, CreatedBy = "Admin" };
            context.Besinlers.Add(mezgit);



            Besinler midyeDolma = new Besinler() { BesinAdi = "Midye Dolma", Kalori = 26m, Karbonhidrat = 3.08m, Protein = 1.62m, Yag = 0.71m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(midyeDolma);



            Besinler midyeTava = new Besinler() { BesinAdi = "Midye Tava", Kalori = 2m, Karbonhidrat = 0.08m, Protein = 0.09m, Yag = 0.10m, CreatedBy = "Admin" };
            context.Besinlers.Add(midyeTava);



            Besinler palamut = new Besinler() { BesinAdi = "Palamut", Kalori = 1.51m, Karbonhidrat = 0m, Protein = 0.19m, Yag = 0.07m, CreatedBy = "Admin" };
            context.Besinlers.Add(palamut);



            Besinler sardalya = new Besinler() { BesinAdi = "Sardalya", Kalori = 1.60m, Karbonhidrat = 0m, Protein = 0.15m, Yag = 0.09m, CreatedBy = "Admin" };
            context.Besinlers.Add(sardalya);



            Besinler sazan = new Besinler() { BesinAdi = "Sazan", Kalori = 1.45m, Karbonhidrat = 0m, Protein = 0.19m, Yag = 0.07m, CreatedBy = "Admin" };
            context.Besinlers.Add(sazan);



            Besinler denizTaragi = new Besinler() { BesinAdi = "Deniz Tarağı", Kalori = 0.70m, Karbonhidrat = 0m, Protein = 0.10m, Yag = 0.01m, CreatedBy = "Admin" };
            context.Besinlers.Add(denizTaragi);



            Besinler tekir = new Besinler() { BesinAdi = "Tekir", Kalori = 1.51m, Yag = 0.04m, Karbonhidrat = 0m, Protein = 0.25m, CreatedBy = "Admin" };
            context.Besinlers.Add(tekir);



            Besinler ton = new Besinler() { BesinAdi = "Ton Balığı", Kalori = 2.90m, Karbonhidrat = 0m, Protein = 0.25m, Yag = 0.21m, CreatedBy = "Admin" };
            context.Besinlers.Add(ton);



            Besinler uskumru = new Besinler() { BesinAdi = "İzmarit", Kalori = 1.91m, Karbonhidrat = 0m, Protein = 0.19m, Yag = 0.12m, CreatedBy = "Admin" };
            context.Besinlers.Add(uskumru);



            Besinler yengec = new Besinler() { BesinAdi = "İzmarit", Kalori = 1.01m, Karbonhidrat = 0m, Protein = 0.19m, Yag = 0.18m, CreatedBy = "Admin" };
            context.Besinlers.Add(yengec);



            Besinler susi = new Besinler() { BesinAdi = "Suşi", Kalori = 125m, Karbonhidrat = 12.42m, Protein = 3.04m, Yag = 7.15m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(susi);
            //BEYAZ ET URUNLERİ



            Besinler HaslanmisTavukGogsu = new Besinler() { BesinAdi = "Haşlanmış Tavuk Göğsü", Kalori = 1.97m, Karbonhidrat = 0m, Protein = 0.30m, Yag = 0.08m, CreatedBy = "Admin" };
            context.Besinlers.Add(HaslanmisTavukGogsu);



            Besinler PismisTavukEti = new Besinler() { BesinAdi = "Pişmiş Tavuk Eti", Kalori = 2.20m, Yag = 0.12m, Karbonhidrat = 0m, Protein = 0.25m, CreatedBy = "Admin" };
            context.Besinlers.Add(PismisTavukEti);



            Besinler KizarmisKanat = new Besinler() { BesinAdi = "Kızarmış Tavuk Kanadı", Kalori = 69m, Karbonhidrat = 0.50m, Protein = 5.85m, Yag = 4.92m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(KizarmisKanat);



            Besinler KizarmisBut = new Besinler()
            {
                BesinAdi = "Kızarmış Tavuk But",
                Kalori = 300m,
                Karbonhidrat = 0.76m,
                Protein = 13.8m,
                Yag = 26.65m,
                GramKarsiligi = 100,
                CreatedBy = "Admin"
            };



            context.Besinlers.Add(KizarmisBut);



            Besinler HaslanmisBut = new Besinler() { BesinAdi = "Haşlanmış Tavuk But", Kalori = 117m, Karbonhidrat = 4.38m, Protein = 7.96m, GramKarsiligi = 100, Yag = 7.17m, CreatedBy = "Admin" };
            context.Besinlers.Add(HaslanmisBut);



            Besinler TavukKoftesi = new Besinler() { BesinAdi = "Tavuk Köftesi", Kalori = 46m, Karbonhidrat = 2.25m, Protein = 4.13m, GramKarsiligi = 100, Yag = 2.25m, CreatedBy = "Admin" };
            context.Besinlers.Add(TavukKoftesi);



            Besinler TavukCigeri = new Besinler() { BesinAdi = "Tavuk Ciğeri", Kalori = 1.72m, Karbonhidrat = 0.01m, Protein = 026m, Yag = 0.06m, CreatedBy = "Admin" };
            context.Besinlers.Add(TavukCigeri);



            Besinler TavukluPilav = new Besinler() { BesinAdi = "Tavuklu Pilav", Kalori = 336m, Karbonhidrat = 46.77m, Protein = 15.90m, Yag = 9.03m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(TavukluPilav);



            Besinler TavukNugget = new Besinler() { BesinAdi = "Tavuk Nugget", Kalori = 121m, Karbonhidrat = 2.7m, Protein = 7.2m, Yag = 9m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(TavukNugget);



            Besinler EkmekAraTavukDoner = new Besinler() { BesinAdi = "Ekmek Arası Tavuk Döner", Kalori = 309m, Karbonhidrat = 15.13m, Protein = 43.10m, Yag = 36.37m, CreatedBy = "Admin" };
            context.Besinlers.Add(EkmekAraTavukDoner);



            Besinler KoriSosluTavuk = new Besinler() { BesinAdi = "Ekmek Arası Tavuk Döner", Kalori = 243m, Karbonhidrat = 8.92m, Protein = 31.95m, Yag = 7.9m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(KoriSosluTavuk);



            Besinler TavukSote = new Besinler() { BesinAdi = "Tavuk Sote", Kalori = 309m, Karbonhidrat = 15.13m, Protein = 43.10m, Yag = 36.37m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(TavukSote);
            //MEYVELER



            Besinler Elma = new Besinler() { BesinAdi = "Elma", Kalori = 95m, Karbonhidrat = 25.13m, Protein = 0.47m, Yag = 0.31m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Elma);



            Besinler Armut = new Besinler() { BesinAdi = "Elma", Kalori = 101m, Karbonhidrat = 27.11m, Protein = 0.64m, Yag = 0.25m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Armut);



            Besinler Portakal = new Besinler() { BesinAdi = "Portakal", Kalori = 62m, Karbonhidrat = 15.40m, Protein = 1.25m, Yag = 0.16m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Portakal);



            Besinler Greyfurt = new Besinler() { BesinAdi = "Greyfurt", Kalori = 74m, Karbonhidrat = 18.45m, Protein = 1.35m, Yag = 0.25m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Greyfurt);



            Besinler Ayva = new Besinler() { BesinAdi = "Elma", Kalori = 57m, Karbonhidrat = 15.30m, Protein = 0.40m, Yag = 0.10m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Ayva);



            Besinler Mandalina = new Besinler() { BesinAdi = "Mandalina", Kalori = 40m, Karbonhidrat = 10.15m, Protein = 0.60m, Yag = 0.25m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Mandalina);



            Besinler Kivi = new Besinler() { BesinAdi = "Kivi", Kalori = 42m, Karbonhidrat = 10.10m, Protein = 0.62m, Yag = 0.25m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Kivi);



            Besinler Muz = new Besinler() { BesinAdi = "Muz", Kalori = 105m, Karbonhidrat = 27m, Protein = 1.30m, Yag = 0.40m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Muz);



            Besinler Kayisi = new Besinler() { BesinAdi = "Kayısı", Kalori = 17m, Karbonhidrat = 3.90m, Protein = 0.50m, Yag = 0.15m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Kayisi);



            Besinler Cilek = new Besinler() { BesinAdi = "Çilek", Kalori = 46m, Karbonhidrat = 11m, Protein = 0.95m, Yag = 0.45m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Cilek);



            Besinler TrabzonHurmasi = new Besinler() { BesinAdi = "Trabzon Hurması", Kalori = 60m, Karbonhidrat = 16m, Protein = 0.50m, Yag = 0.17m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(TrabzonHurmasi);



            Besinler Kiraz = new Besinler() { BesinAdi = "Kiraz", Kalori = 87m, Karbonhidrat = 22.10m, Protein = 1.45m, Yag = 0.30m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Kiraz);



            Besinler Visne = new Besinler() { BesinAdi = "Vişne", Kalori = 52m, Karbonhidrat = 13m, Protein = 1.03m, Yag = 0.30m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Visne);



            Besinler Kavun = new Besinler() { BesinAdi = "Kavun", Kalori = 54m, Karbonhidrat = 13.05m, Protein = 1.35m, Yag = 0.30m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Kavun);



            Besinler Karpuz = new Besinler() { BesinAdi = "Karpuz", Kalori = 46m, Karbonhidrat = 15.13m, Protein = 43.10m, Yag = 36.37m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Karpuz);



            Besinler Ananas = new Besinler() { BesinAdi = "Ananas", Kalori = 28m, Karbonhidrat = 7.35m, Protein = 0.30m, Yag = 0.07m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Ananas);




            Besinler Avakado = new Besinler() { BesinAdi = "Avakado", Kalori = 160m, Karbonhidrat = 8.5m, Protein = 2.0m, Yag = 14.7m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Avakado);



            Besinler Mango = new Besinler() { BesinAdi = "Mango", Kalori = 100m, Karbonhidrat = 24.70m, Protein = 1.35m, Yag = 0.63m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Mango);



            Besinler Ahududu = new Besinler() { BesinAdi = "Ahududu", Kalori = 64m, Karbonhidrat = 14.70m, Protein = 1.5m, Yag = 0.80m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Ahududu);



            Besinler Bogurtlen = new Besinler() { BesinAdi = "Böğürtlen", Kalori = 62m, Karbonhidrat = 13.80m, Protein = 1.5m, Yag = 0.80m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Bogurtlen);



            Besinler YesilErik = new Besinler() { BesinAdi = "Yeşil Erik", Kalori = 76m, Karbonhidrat = 18.85m, Protein = 1.15m, Yag = 0.5m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(YesilErik);



            Besinler Incir = new Besinler() { BesinAdi = "İncir", Kalori = 37m, Karbonhidrat = 9.35m, Protein = 0.4m, Yag = 0.15m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Incir);



            Besinler Dut = new Besinler() { BesinAdi = "Dut", Kalori = 60m, Karbonhidrat = 13.70m, Protein = 2m, Yag = 0.55m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Dut);



            Besinler Uzum = new Besinler() { BesinAdi = "Üzüm", Kalori = 104m, Karbonhidrat = 27.3m, Protein = 1.1m, Yag = 0.25m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Uzum);



            Besinler Nar = new Besinler() { BesinAdi = "Nar", Kalori = 145m, Karbonhidrat = 33m, Protein = 3m, Yag = 2m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Nar);



            Besinler Seftali = new Besinler() { BesinAdi = "Şeftali", Kalori = 60m, Karbonhidrat = 14.30m, Protein = 1.36m, Yag = 0.38m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Seftali);



            Besinler Limon = new Besinler() { BesinAdi = "Limon", Kalori = 17m, Karbonhidrat = 5.4m, Protein = 0.65m, Yag = 0.17m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Limon);



            Besinler KirmiziErik = new Besinler() { BesinAdi = "Kırmızı Erik", Kalori = 80m, Karbonhidrat = 21m, Protein = 1m, Yag = 0.15m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(KirmiziErik);
            // SÜTLÜ TATLILAR



            Besinler Sutlac = new Besinler() { BesinAdi = "Sütlaç", Kalori = 133m, Karbonhidrat = 21.9m, Protein = 4m, Yag = 3m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Sutlac);



            Besinler Kazandibi = new Besinler() { BesinAdi = "Kazandibi", Kalori = 294m, Karbonhidrat = 47.9m, Protein = 5.7m, Yag = 8m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Kazandibi);



            Besinler Magnolia = new Besinler() { BesinAdi = "Magnolia", Kalori = 300m, Karbonhidrat = 50m, Protein = 3.5m, Yag = 7.2m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Magnolia);



            Besinler Tiramisu = new Besinler() { BesinAdi = "Tiramisu", Kalori = 380m, Karbonhidrat = 56.80m, Protein = 9.25m, Yag = 11.2m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Tiramisu);



            Besinler Cheesecake = new Besinler() { BesinAdi = "Cheesecake", Kalori = 510m, Karbonhidrat = 62m, Protein = 9.75m, Yag = 23.47m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Cheesecake);



            Besinler Gullac = new Besinler() { BesinAdi = "Güllaç", Kalori = 143m, Karbonhidrat = 21.7m, Protein = 2.55m, Yag = 4.83m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Gullac);



            Besinler TavukGogsuTatli = new Besinler() { BesinAdi = "Tavuk Göğsü Tatlısı", Kalori = 165m, Karbonhidrat = 31.1m, Protein = 6.25m, Yag = 0.2m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(TavukGogsuTatli);



            Besinler Muhallebi = new Besinler() { BesinAdi = "Muhallebi", Kalori = 233m, Karbonhidrat = 38.18m, Protein = 4.7m, Yag = 4.60m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Muhallebi);



            Besinler Puding = new Besinler() { BesinAdi = "Puding", Kalori = 132m, Karbonhidrat = 16.63m, Protein = 7.45m, Yag = 3.8m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Puding);



            Besinler Supangle = new Besinler() { BesinAdi = "Supangle", Kalori = 160m, Karbonhidrat = 19m, Protein = 4.52m, Yag = 6.63m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Supangle);



            Besinler Trilece = new Besinler() { BesinAdi = "Trileçe", Kalori = 301m, Karbonhidrat = 39m, Protein = 12.85m, Yag = 9.25m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Trilece);



            Besinler Hosmerim = new Besinler() { BesinAdi = "Höşmerim", Kalori = 343m, Karbonhidrat = 111m, Protein = 17m, Yag = 10.8m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Hosmerim);



            Besinler Keskul = new Besinler() { BesinAdi = "Keşkül", Kalori = 273m, Karbonhidrat = 42.55m, Protein = 7.3m, Yag = 7.7m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Keskul);



            Besinler Asure = new Besinler() { BesinAdi = "Aşure", Kalori = 344m, Karbonhidrat = 61.21m, Protein = 7.84m, Yag = 5.5m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Asure);



            Besinler Profiterol = new Besinler() { BesinAdi = "Profiterol", Kalori = 429m, Karbonhidrat = 55.8m, Protein = 5.8m, Yag = 19.3m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Profiterol);



            Besinler MeyveliDondurma = new Besinler() { BesinAdi = "Meyveli Dondurma", Kalori = 99m, Karbonhidrat = 21.05m, Protein = 0.97m, Yag = 1.02m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(MeyveliDondurma);



            Besinler SutluDondurma = new Besinler() { BesinAdi = "Sütlü Dondurma", Kalori = 240m, Karbonhidrat = 30.75m, Protein = 9m, Yag = 9m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(SutluDondurma);



            Besinler CikolataliDondurma = new Besinler() { BesinAdi = "Çikolatalı Dondurma", Kalori = 216m, Karbonhidrat = 28.2m, Protein = 3.8m, Yag = 11m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(CikolataliDondurma);



            Besinler IrmikTatlisi = new Besinler() { BesinAdi = "Sütlü İrmik Tatlısı", Kalori = 262m, Karbonhidrat = 43.15m, Protein = 7m, Yag = 5m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(IrmikTatlisi);



            Besinler IrmikHelvasi = new Besinler() { BesinAdi = "İrmik Helvası", Kalori = 532m, Karbonhidrat = 64.9m, Protein = 7.77m, Yag = 25.20m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(IrmikHelvasi);



            Besinler UnHelvasi = new Besinler() { BesinAdi = "Un Helvası", Kalori = 294m, Karbonhidrat = 43.5m, Protein = 0.12m, Yag = 12.18m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(UnHelvasi);



            //ŞERBETLİ TATLILAR



            Besinler Baklava = new Besinler() { BesinAdi = "Baklava", Kalori = 660m, Karbonhidrat = 79m, Protein = 12.36m, Yag = 34.35m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Baklava);



            Besinler Kadayif = new Besinler() { BesinAdi = "Kadayıf", Kalori = 422m, Karbonhidrat = 51.75m, Protein = 6.85m, Yag = 22.55m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Kadayif);



            Besinler SogukBaklava = new Besinler() { BesinAdi = "Soğuk Baklava", Kalori = 242m, Karbonhidrat = 34.45m, Protein = 3.3m, Yag = 14.75m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(SogukBaklava);



            Besinler Tulumba = new Besinler() { BesinAdi = "Tulumba", Kalori = 256m, Karbonhidrat = 40.7m, Protein = 2.51m, Yag = 7.25m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Tulumba);



            Besinler Kemalpasa = new Besinler() { BesinAdi = "Kemalpaşa", Kalori = 476m, Karbonhidrat = 84.4m, Protein = 16.6m, Yag = 13.55m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Kemalpasa);



            Besinler HalkaTatlisi = new Besinler() { BesinAdi = "Halka Tatlısı", Kalori = 673m, Karbonhidrat = 66.75m, Protein = 5m, Yag = 40.6m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(HalkaTatlisi);



            Besinler SamTatlisi = new Besinler() { BesinAdi = "Şam Tatlısı", Kalori = 330m, Karbonhidrat = 150.75m, Protein = 18.88m, Yag = 0.94m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(SamTatlisi);



            Besinler Sobiyet = new Besinler() { BesinAdi = "Şöbiyet", Kalori = 522m, Karbonhidrat = 59.76m, Protein = 5.95m, Yag = 29.15m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Sobiyet);



            Besinler Kunefe = new Besinler() { BesinAdi = "Künefe", Kalori = 426m, Karbonhidrat = 55m, Protein = 7.36m, Yag = 20.52m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Kunefe);



            Besinler Sekerpare = new Besinler() { BesinAdi = "Şekerpare", Kalori = 272m, Karbonhidrat = 45.95m, Protein = 2.65m, Yag = 8.95m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Sekerpare);



            Besinler Revani = new Besinler() { BesinAdi = "Revani", Kalori = 348m, Karbonhidrat = 55m, Protein = 5.82m, Yag = 9.4m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Revani);



            Besinler LokmaTatlisi = new Besinler() { BesinAdi = "Lokma Tatlısı", Kalori = 78m, Karbonhidrat = 7.52m, Protein = 0.35m, Yag = 4.82m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(LokmaTatlisi);



            Besinler Kalburabasti = new Besinler() { BesinAdi = "Kalburabastı", Kalori = 251m, Karbonhidrat = 34.38m, Protein = 4m, Yag = 11.33m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(Kalburabasti);



            Besinler FistikliSarma = new Besinler() { BesinAdi = "Fıstıklı Sarma Tatlısı", Kalori = 210m, Karbonhidrat = 20.95m, Protein = 3.71m, Yag = 12.08m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(FistikliSarma);



            Besinler DilberDudagi = new Besinler() { BesinAdi = "Un Helvası", Kalori = 99m, Karbonhidrat = 12.63m, Protein = 0.48m, Yag = 4.81m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(DilberDudagi);



            Besinler SanSebastian = new Besinler() { BesinAdi = "San Sebastian", Kalori = 480m, Karbonhidrat = 37.05m, Protein = 7.8m, Yag = 33.3m, GramKarsiligi = 100, CreatedBy = "Admin" };
            context.Besinlers.Add(SanSebastian);

            //SÜT ÜRÜNLERİ

            Besinler TamyagliInekSutu = new Besinler() { BesinAdi = "Tam Yağlı İnek Sütü", Kalori = 110m, Karbonhidrat = 8.64m, Protein = 5.65m, Yag = 5.85m, CreatedBy = "Admin" }; context.Besinlers.Add(TamyagliInekSutu);

            Besinler YarimYagliInekSutu = new Besinler() { BesinAdi = "Yarım Yağlı İnek Sütü", Kalori = 92m, Karbonhidrat = 10.84m, Protein = 6.66m, Yag = 2.10m, CreatedBy = "Admin" }; context.Besinlers.Add(YarimYagliInekSutu);

            Besinler KeciSutu = new Besinler() { BesinAdi = "Keçi Sütü", Kalori = 124m, Karbonhidrat = 10m, Protein = 6.66m, Yag = 6.66m, CreatedBy = "Admin" }; context.Besinlers.Add(KeciSutu);

            Besinler SoyaSutu = new Besinler() { BesinAdi = "Soya Sütü", Kalori = 112m, Karbonhidrat = 17.6m, Protein = 4m, Yag = 2.4m, CreatedBy = "Admin" }; context.Besinlers.Add(SoyaSutu);

            Besinler BademSutu = new Besinler() { BesinAdi = "Badem Sütü", Kalori = 48m, Karbonhidrat = 6m, Protein = 1m, Yag = 2.2m, CreatedBy = "Admin" }; context.Besinlers.Add(BademSutu);

            Besinler BeyazPeynir = new Besinler() { BesinAdi = "Beyaz Peynir", Kalori = 93m, Karbonhidrat = 0.76m, Protein = 6.11m, Yag = 7.30m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(BeyazPeynir);

            Besinler SuzmePeynir = new Besinler() { BesinAdi = "Süzme Peynir", Kalori = 72m, Karbonhidrat = 1.14m, Protein = 3.4m, Yag = 6m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(SuzmePeynir);

            Besinler LorPeyniri = new Besinler() { BesinAdi = "Lor Peyniri", Kalori = 30m, Karbonhidrat = 0.14m, Protein = 2.17m, Yag = 2.34m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(LorPeyniri);

            Besinler KasarPeyniri = new Besinler() { BesinAdi = "Kaşar Peyniri", Kalori = 71m, Karbonhidrat = 0.51m, Protein = 5.4m, Yag = 5.32m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(KasarPeyniri);

            Besinler Labne = new Besinler() { BesinAdi = "Labne", Kalori = 10m, Karbonhidrat = 0.28m, Protein = 0.25m, Yag = 0.9m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Labne);

            Besinler OrguPeynir = new Besinler() { BesinAdi = "Örgü Peynir", Kalori = 72m, Karbonhidrat = 0.38m, Protein = 6.25m, Yag = 5m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(OrguPeynir);

            Besinler DilPeyniri = new Besinler() { BesinAdi = "Dil Peyniri", Kalori = 68m, Karbonhidrat = 1.58m, Protein = 4.3m, Yag = 4.93m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(DilPeyniri);

            Besinler HellimPeyniri = new Besinler() { BesinAdi = "Hellim Peyniri", Kalori = 90m, Karbonhidrat = 0.26m, Protein = 6.98m, Yag = 7.38m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(HellimPeyniri);

            Besinler Mozarella = new Besinler() { BesinAdi = "Beyaz Peynir", Kalori = 90m, Karbonhidrat = 0.66m, Protein = 6.61m, Yag = 6.71m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Mozarella);

            Besinler CheddarPeyniri = new Besinler() { BesinAdi = "Beyaz Peynir", Kalori = 61m, Karbonhidrat = 0m, Protein = 3.71m, Yag = 5.1m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(CheddarPeyniri);

            Besinler Kefir = new Besinler() { BesinAdi = "Kefir", Kalori = 120m, Karbonhidrat = 10m, Protein = 5.6m, Yag = 6m, CreatedBy = "Admin" }; context.Besinlers.Add(Kefir);

            Besinler Yogurt = new Besinler() { BesinAdi = "Yoğurt", Kalori = 122m, Karbonhidrat = 9.32m, Protein = 6.94m, Yag = 6.5m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Yogurt);

            Besinler Ayran = new Besinler() { BesinAdi = "Ayran", Kalori = 76m, Karbonhidrat = 5.6m, Protein = 4m, Yag = 4m, CreatedBy = "Admin" }; context.Besinlers.Add(Ayran);

            Besinler Cacik = new Besinler() { BesinAdi = "Cacık", Kalori = 115m, Karbonhidrat = 11m, Protein = 6.66m, Yag = 4.85m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Cacik);


            //KAHVALTILI SICAKLARI

            Besinler HaslanmisYumurta = new Besinler() { BesinAdi = "Haşlanmış Yumurta", Kalori = 78m, Karbonhidrat = 0.56m, Protein = 6.3m, Yag = 5.31m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(HaslanmisYumurta);

            Besinler Omlet = new Besinler() { BesinAdi = "Omlet", Kalori = 101m, Karbonhidrat = 1.27m, Protein = 6.7m, Yag = 7.94m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Omlet);

            Besinler PeynirliOmlet = new Besinler() { BesinAdi = "Peynirli Omlet", Kalori = 254m, Karbonhidrat = 2.05m, Protein = 15.3m, Yag = 15m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(PeynirliOmlet);

            Besinler MantarliOmlet = new Besinler() { BesinAdi = "Mantarlı Omlet", Kalori = 205m, Karbonhidrat = 3.7m, Protein = 12.45m, Yag = 10m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(MantarliOmlet);

            Besinler Menemen = new Besinler() { BesinAdi = "Menemen", Kalori = 205m, Karbonhidrat = 3.7m, Protein = 12.45m, Yag = 10m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Menemen);

            Besinler SucukluYumurta = new Besinler() { BesinAdi = "Sucuklu Yumurta", Kalori = 242m, Karbonhidrat = 3.4m, Protein = 13.5m, Yag = 19.5m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(SucukluYumurta);

            Besinler Kuymak = new Besinler() { BesinAdi = "Kuymak - Mıhlama", Kalori = 489m, Karbonhidrat = 3.95m, Protein = 19.1m, Yag = 44.4m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Kuymak);

            //SARKUTERI

            Besinler Sucuk = new Besinler() { BesinAdi = "Sucuk", Kalori = 166m, Karbonhidrat = 2.57m, Protein = 7.1m, Yag = 14.2m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Sucuk);

            Besinler Sosis = new Besinler() { BesinAdi = "Sosis", Kalori = 60m, Karbonhidrat = 0.12m, Protein = 2.24m, Yag = 5.6m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Sosis);

            Besinler DanaSalam = new Besinler() { BesinAdi = "Dana Salam", Kalori = 45m, Karbonhidrat = 0.64m, Protein = 1.65m, Yag = 3.92m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(DanaSalam);

            Besinler HindiSalam = new Besinler() { BesinAdi = "Hindi Salam", Kalori = 17m, Karbonhidrat = 0.24m, Protein = 1.31m, Yag = 1.13m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(HindiSalam);

            Besinler DanaJambon = new Besinler() { BesinAdi = "Dana Jambon", Kalori = 32m, Karbonhidrat = 0.7m, Protein = 4.92m, Yag = 0m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(DanaJambon);

            Besinler HindiJambon = new Besinler() { BesinAdi = "Hindi Jambon", Kalori = 15m, Karbonhidrat = 0.35m, Protein = 2.35m, Yag = 0.46m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(HindiJambon);

            Besinler PilicJambon = new Besinler() { BesinAdi = "Piliç Jambon", Kalori = 11m, Karbonhidrat = 0.12m, Protein = 1.56m, Yag = 0.44m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(PilicJambon);

            Besinler HindiFume = new Besinler() { BesinAdi = "Hindi Füme", Kalori = 51m, Karbonhidrat = 0m, Protein = 8.8m, Yag = 1.5m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(HindiFume);

            Besinler PilicFume = new Besinler() { BesinAdi = "Pilic Füme", Kalori = 26m, Karbonhidrat = 0.3m, Protein = 3.9m, Yag = 0.9m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(PilicFume);

            Besinler Pastirma = new Besinler() { BesinAdi = "Pastırma", Kalori = 75m, Karbonhidrat = 0m, Protein = 8.85m, Yag = 4.17m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Pastirma);

            //KAHVALTILIKLAR

            Besinler SiyahZeytin = new Besinler() { BesinAdi = "Siyah Zeytin", Kalori = 5m, Karbonhidrat = 0.24m, Protein = 0.03m, Yag = 0.44m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(SiyahZeytin);

            Besinler YesilZeytin = new Besinler() { BesinAdi = "Yeşil Zeytin", Kalori = 6m, Karbonhidrat = 0.15m, Protein = 0.05m, Yag = 0.61m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(YesilZeytin);

            Besinler Bal = new Besinler() { BesinAdi = "Bal", Kalori = 30m, Karbonhidrat = 8.25m, Protein = 0.04m, Yag = 0m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Bal);

            Besinler Kaymak = new Besinler() { BesinAdi = "Kaymak", Kalori = 29m, Karbonhidrat = 0.17m, Protein = 0.05m, Yag = 3.16m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Kaymak);

            Besinler TahinHelvasi = new Besinler() { BesinAdi = "Keçi Sütü", Kalori = 197m, Karbonhidrat = 15.8m, Protein = 5.11m, Yag = 12.53m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(TahinHelvasi);

            Besinler YazHelvasi = new Besinler() { BesinAdi = "Cevizli Yaz Helvası", Kalori = 169m, Karbonhidrat = 13.55m, Protein = 4.41m, Yag = 10m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(YazHelvasi);

            Besinler Tahin = new Besinler() { BesinAdi = "Tahin", Kalori = 87m, Karbonhidrat = 3.18m, Protein = 2.67m, Yag = 7.2m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Tahin);

            Besinler Pekmez = new Besinler() { BesinAdi = "Pekmez", Kalori = 29m, Karbonhidrat = 0m, Protein = 0m, Yag = 0.01m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Pekmez);

            Besinler TahinPekmez = new Besinler() { BesinAdi = "Tahin Pekmez", Kalori = 66m, Karbonhidrat = 6.45m, Protein = 1.52m, Yag = 3.48m, CreatedBy = "Admin" }; context.Besinlers.Add(TahinPekmez);

            Besinler Nutella = new Besinler() { BesinAdi = "Nutella", Kalori = 27m, Karbonhidrat = 2.88m, Protein = 0.32m, Yag = 1.55m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Nutella);

            Besinler KakaoluFindikKremasi = new Besinler() { BesinAdi = "Kakaolu Fındık Kreması", Kalori = 25m, Karbonhidrat = 2.71m, Protein = 0.44m, Yag = 1.38m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(KakaoluFindikKremasi);

            Besinler FindikEzmesi = new Besinler() { BesinAdi = "Fındık Ezmesi", Kalori = 34m, Karbonhidrat = 3.08m, Protein = 0.55m, Yag = 2.23m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(FindikEzmesi);

            Besinler FistikEzmesi = new Besinler() { BesinAdi = "Fıstık Ezmesi ", Kalori = 35m, Karbonhidrat = 1.3m, Protein = 1.44m, Yag = 3m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(FistikEzmesi);

            Besinler SekersizFistikEzmesi = new Besinler() { BesinAdi = "Şekersiz Fıstık Ezmesi", Kalori = 36m, Karbonhidrat = 1.1m, Protein = 1.32m, Yag = 2.76m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(SekersizFistikEzmesi);

            // MAKARNALAR            Besinler HaslanmisMakarna = new Besinler() { BesinAdi = "Haşlanmış Makarna", Kalori = 157m, Karbonhidrat = 30.59m, Protein = 5.8m, Yag = 0.93m, GramKarsiligi = 100, CreatedBy = "Admin" };            context.Besinlers.Add(HaslanmisMakarna);

            Besinler DomatesliMakarna = new Besinler() { BesinAdi = "Domatesli Makarna", Kalori = 178m, Karbonhidrat = 27.43m, Protein = 6.55m, Yag = 4.48m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(DomatesliMakarna);

            Besinler SpagettiBolonez = new Besinler() { BesinAdi = "Spagetti Bolonez", Kalori = 303m, Karbonhidrat = 20.9m, Protein = 15.83m, Yag = 17m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(SpagettiBolonez);

            Besinler PenneArabiata = new Besinler() { BesinAdi = "Penne Arabiata", Kalori = 164m, Karbonhidrat = 31.18m, Protein = 26.5m, Yag = 4.43m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(PenneArabiata);

            Besinler Fettucini = new Besinler() { BesinAdi = "Fettucini Alfredo", Kalori = 289m, Karbonhidrat = 50.1m, Protein = 10.4m, Yag = 3.8m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Fettucini);

            Besinler Lazanya = new Besinler() { BesinAdi = "Lazanya", Kalori = 272m, Karbonhidrat = 25m, Protein = 12.65m, Yag = 13.56m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Lazanya);

            Besinler FirinMakarna = new Besinler() { BesinAdi = "Fırında Makarna", Kalori = 382m, Karbonhidrat = 52.26m, Protein = 17.14m, Yag = 11.2m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(FirinMakarna);

            Besinler MakarnaSalatasi = new Besinler() { BesinAdi = "Makarna Salatası", Kalori = 283m, Karbonhidrat = 53.75m, Protein = 8.52m, Yag = 4.04m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(MakarnaSalatasi);


            // SOSLAR

            Besinler Ketçap = new Besinler() { BesinAdi = "Ketçap", Kalori = 22m, Karbonhidrat = 4.8m, Protein = 0.25m, Yag = 0m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Ketçap);

            Besinler Mayonez = new Besinler() { BesinAdi = "Mayonez", Kalori = 50m, Karbonhidrat = 3.11m, Protein = 0.12m, Yag = 4.34m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Mayonez);

            Besinler Hardal = new Besinler() { BesinAdi = "Hardal", Kalori = 6m, Karbonhidrat = 0.58m, Protein = 0.37m, Yag = 0.33m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Hardal);

            Besinler BarbekuSos = new Besinler() { BesinAdi = "Barbekü Sos", Kalori = 26m, Karbonhidrat = 6.38m, Protein = 0.12m, Yag = 0.06m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(BarbekuSos);

            Besinler RanchSos = new Besinler() { BesinAdi = "Ranch Sos", Kalori = 24m, Karbonhidrat = 1.79m, Protein = 0.46m, Yag = 1.7m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(RanchSos);

            Besinler BuffaloSos = new Besinler() { BesinAdi = "Buffalo Sos", Kalori = 56m, Karbonhidrat = 1.4m, Protein = 0.4m, Yag = 5.4m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(BuffaloSos);

            Besinler PestoSos = new Besinler() { BesinAdi = "Pesto Sos", Kalori = 9m, Karbonhidrat = 0.54m, Protein = 3.47m, Yag = 4.86m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(PestoSos);

            Besinler NarEkşisi = new Besinler() { BesinAdi = "Nar Ekşisi", Kalori = 15m, Karbonhidrat = 3.7m, Protein = 0.05m, Yag = 0m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(NarEkşisi);

            Besinler KoriSos = new Besinler() { BesinAdi = "Köri Sos", Kalori = 22m, Karbonhidrat = 1.6m, Protein = 0.05m, Yag = 1.7m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(KoriSos);

            Besinler SoyaSos = new Besinler() { BesinAdi = "Soya Sos", Kalori = 6m, Karbonhidrat = 0.56m, Protein = 1.05m, Yag = 0m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(SoyaSos);

            //FASTFOODLAR            Besinler CitirTavuk = new Besinler() { BesinAdi = "Çıtır Tavuk", Kalori = 529m, Karbonhidrat = 38.05m, Protein = 34m, Yag = 26.65m, GramKarsiligi = 100, CreatedBy = "Admin" };            context.Besinlers.Add(CitirTavuk);

            Besinler TavukBurger = new Besinler() { BesinAdi = "Tavuk Burger ", Kalori = 270m, Karbonhidrat = 33m, Protein = 13m, Yag = 10m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(TavukBurger);

            Besinler Cheeseburger = new Besinler() { BesinAdi = "Cheeseburger", Kalori = 290m, Karbonhidrat = 30.96m, Protein = 16.95m, Yag = 12m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Cheeseburger);

            Besinler EtliEkmek = new Besinler() { BesinAdi = "Etli Ekmek", Kalori = 277m, Karbonhidrat = 31.07m, Protein = 15.28m, Yag = 9.56m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(EtliEkmek);

            Besinler Lahmacun = new Besinler() { BesinAdi = "Lahmacun", Kalori = 221m, Karbonhidrat = 32.27m, Protein = 9.75m, Yag = 5.55m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Lahmacun);

            Besinler Tantuni = new Besinler() { BesinAdi = "Tantuni", Kalori = 380m, Karbonhidrat = 19.05m, Protein = 43.6m, Yag = 50.34m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Tantuni);

            Besinler PizzaKarisik = new Besinler() { BesinAdi = "Karışık Pizza", Kalori = 241m, Karbonhidrat = 40m, Protein = 7.8m, Yag = 5.63m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(PizzaKarisik);

            Besinler PizzaSebzeli = new Besinler() { BesinAdi = "Sebzeli Pizza", Kalori = 266m, Karbonhidrat = 41.23m, Protein = 13.1m, Yag = 6.6m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(PizzaSebzeli);

            Besinler Kokorec = new Besinler() { BesinAdi = "Kokoreç Yarım Ekmek", Kalori = 433m, Karbonhidrat = 68.77m, Protein = 28.1m, Yag = 3.93m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Kokorec);

            Besinler Cigkofte = new Besinler() { BesinAdi = "Çiğköfte Dürüm", Kalori = 361m, Karbonhidrat = 64.75m, Protein = 15.06m, Yag = 30.64m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Cigkofte);

            Besinler DurumTavukDoner = new Besinler() { BesinAdi = "Tavuk Döner Dürüm", Kalori = 309m, Karbonhidrat = 15.13m, Protein = 43.1m, Yag = 36.37m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(DurumTavukDoner);

            Besinler DurumEtDoner = new Besinler() { BesinAdi = "Et Döner Dürüm", Kalori = 301m, Karbonhidrat = 19.7m, Protein = 29.65m, Yag = 45.6m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(DurumEtDoner);

            Besinler Kumpir = new Besinler() { BesinAdi = "Kumpir", Kalori = 1296m, Karbonhidrat = 65.74m, Protein = 50m, Yag = 92.35m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(Kumpir);

            Besinler AdanaDurum = new Besinler() { BesinAdi = "Adana Dürüm", Kalori = 325m, Karbonhidrat = 15.02m, Protein = 27.80m, Yag = 45.5m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(AdanaDurum);

            Besinler UrfaDurum = new Besinler() { BesinAdi = "Urfa Dürüm", Kalori = 325m, Karbonhidrat = 15.02m, Protein = 27.80m, Yag = 45.5m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(UrfaDurum);

            Besinler PatatesKizartmasi = new Besinler() { BesinAdi = "Patates Kızartması", Kalori = 250m, Karbonhidrat = 33.15m, Protein = 2.75m, Yag = 11.8m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(PatatesKizartmasi);

            Besinler SoganHalkasi = new Besinler() { BesinAdi = "Soğan Halkası", Kalori = 97m, Karbonhidrat = 18.91m, Protein = 3.4m, Yag = 0.63m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(SoganHalkasi);

            Besinler KiymaliPide = new Besinler() { BesinAdi = "Kıymalı Pide", Kalori = 628m, Karbonhidrat = 73.44m, Protein = 24.6m, Yag = 25.57m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(KiymaliPide);

            Besinler KasarliPide = new Besinler() { BesinAdi = "Kaşarlı Pide", Kalori = 600m, Karbonhidrat = 69m, Protein = 19.75m, Yag = 26.83m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(KasarliPide);

            Besinler KusbasiPide = new Besinler() { BesinAdi = "Kuşbaşılı pide", Kalori = 515m, Karbonhidrat = 73.2m, Protein = 28.3m, Yag = 11.5m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(KusbasiPide);


            //KIRMIZI ET

            Besinler danaEti = new Besinler() { BesinAdi = "Dana Eti", Kalori = 2.31m, Karbonhidrat = 0, Protein = 0.3m, Yag = 0.11m, CreatedBy = "Admin" }; context.Besinlers.Add(danaEti);

            Besinler kuzuEti = new Besinler() { BesinAdi = "Kuzu Eti", Kalori = 2.71m, Karbonhidrat = 0, Protein = 0.25m, Yag = 0.18m, CreatedBy = "Admin" }; context.Besinlers.Add(kuzuEti);

            Besinler etliSebzeliPizza = new Besinler() { BesinAdi = " Etli Sebzeli Pizza", Kalori = 2.44m, Karbonhidrat = 0.25m, Protein = 0.11m, Yag = 0.11m, CreatedBy = "Admin" }; context.Besinlers.Add(etliSebzeliPizza);

            Besinler hindiEtiKızarmıs = new Besinler() { BesinAdi = " Kızarmış Hindi Eti", Kalori = 1.9m, Karbonhidrat = 0, Protein = 0.28m, Yag = 0.07m, CreatedBy = "Admin" }; context.Besinlers.Add(hindiEtiKızarmıs);

            Besinler kazEti = new Besinler() { BesinAdi = "Kaz Eti", Kalori = 3.05m, Karbonhidrat = 0, Protein = 0.25m, Yag = 0.22m, CreatedBy = "Admin" }; context.Besinlers.Add(kazEti);

            Besinler keciEti = new Besinler() { BesinAdi = " Keçi Eti", Kalori = 1.4m, Karbonhidrat = 0, Protein = 0.27m, Yag = 0.03m, CreatedBy = "Admin" }; context.Besinlers.Add(keciEti);

            Besinler kurutulmusSıgırEti = new Besinler() { BesinAdi = "Kurutulmuş Sığır Eti", Kalori = 4.1m, Karbonhidrat = 0.11m, Protein = 0.33m, Yag = 0.25m, CreatedBy = "Admin" }; context.Besinlers.Add(kurutulmusSıgırEti);

            Besinler etliNohut = new Besinler() { BesinAdi = " Etli Nohut", Kalori = 1.74m, Karbonhidrat = 0.08m, Protein = 0.012m, Yag = 0.01m, CreatedBy = "Admin" }; context.Besinlers.Add(etliNohut);

            Besinler etDoner = new Besinler() { BesinAdi = " Et Döner", Kalori = 2.52m, Karbonhidrat = 0.02m, Protein = 0.015m, Yag = 0.25m, CreatedBy = "Admin" }; context.Besinlers.Add(etDoner);

            Besinler etKavurma = new Besinler() { BesinAdi = " Et Kavurma", Kalori = 3.43m, Karbonhidrat = 0, Protein = 0.2m, Yag = 0.28m, CreatedBy = "Admin" }; context.Besinlers.Add(etKavurma);

            Besinler etSote = new Besinler() { BesinAdi = " Et Sote", Kalori = 1.43m, Karbonhidrat = 0.03m, Protein = 0.14m, Yag = 0.07m, CreatedBy = "Admin" }; context.Besinlers.Add(etSote);

            Besinler danaEtliBurrito = new Besinler() { BesinAdi = " Dana Etli Burrito", Kalori = 2.62m, Karbonhidrat = 0.29m, Protein = 0.13m, Yag = 0.1m, CreatedBy = "Admin" }; context.Besinlers.Add(danaEtliBurrito);

            Besinler etliKuruFasulye = new Besinler() { BesinAdi = " Etli Kuru Fasulye", Kalori = 1.43m, Karbonhidrat = 0.13m, Protein = 0.09m, Yag = 0.06m, CreatedBy = "Admin" }; context.Besinlers.Add(etliKuruFasulye);

            Besinler etliTurlu = new Besinler() { BesinAdi = " Etli Türlü", Kalori = 0.9m, Karbonhidrat = 0.04m, Protein = 0.054m, Yag = 0.056m, CreatedBy = "Admin" }; context.Besinlers.Add(etliTurlu);

            Besinler etliTazeFasulye = new Besinler() { BesinAdi = " Etli Taze Fasulye", Kalori = 0.88m, Karbonhidrat = 0.024m, Protein = 0.066m, Yag = 0.057m, CreatedBy = "Admin" }; context.Besinlers.Add(etliTazeFasulye);

            Besinler etliBiberDolmasi = new Besinler() { BesinAdi = " Etli Biber Dolması", Kalori = 0.79m, Karbonhidrat = 0.036m, Protein = 0.054m, Yag = 0.047m, CreatedBy = "Admin" }; context.Besinlers.Add(etliBiberDolmasi);

            Besinler etliPatates = new Besinler() { BesinAdi = " Etli Patates Yemeği", Kalori = 1.6m, Karbonhidrat = 0.04m, Protein = 0.013m, Yag = 0.01m, CreatedBy = "Admin" }; context.Besinlers.Add(etliPatates);

            Besinler suluKofte = new Besinler() { BesinAdi = "Sulu Köfte", Kalori = 2.22m, Karbonhidrat = 0.10m, Protein = 0.14m, Yag = 0.13m, CreatedBy = "Admin" }; context.Besinlers.Add(suluKofte);

            Besinler islimKebabi = new Besinler() { BesinAdi = " İslim Kebabı", Kalori = 0.87m, Karbonhidrat = 0.03m, Protein = 0.05m, Yag = 0.06m, CreatedBy = "Admin" }; context.Besinlers.Add(islimKebabi);

            Besinler izgaraKofte = new Besinler() { BesinAdi = "Izgara Köfte", Kalori = 1.67m, Karbonhidrat = 0.04m, Protein = 0.14m, Yag = 0.1m, CreatedBy = "Admin" }; context.Besinlers.Add(izgaraKofte);

            Besinler izmirKofte = new Besinler() { BesinAdi = " İzmir Köfte", Kalori = 1.65m, Karbonhidrat = 0.115m, Protein = 0.08m, Yag = 0.1m, CreatedBy = "Admin" }; context.Besinlers.Add(izmirKofte);

            Besinler icliKöfte = new Besinler() { BesinAdi = "İçli Köfte", Kalori = 2.33m, Karbonhidrat = 0.32m, Protein = 0.1m, Yag = 0.07m, CreatedBy = "Admin" }; context.Besinlers.Add(icliKöfte);

            Besinler kasapKofte = new Besinler() { BesinAdi = "Kasap Köfte", Kalori = 1.8m, Karbonhidrat = 0.10m, Protein = 0.017m, Yag = 0.076m, CreatedBy = "Admin" }; context.Besinlers.Add(kasapKofte);

            Besinler inegolKofte = new Besinler() { BesinAdi = "İnegöl Köfte", Kalori = 3, Karbonhidrat = 0.08m, Protein = 0.16m, Yag = 0.11m, CreatedBy = "Admin" }; context.Besinlers.Add(inegolKofte);

            Besinler kadınbuduKöfte = new Besinler() { BesinAdi = "Kadınbudu Köfte", Kalori = 3.52m, Karbonhidrat = 0.14m, Protein = 0.13m, Yag = 0.27m, CreatedBy = "Admin" }; context.Besinlers.Add(kadınbuduKöfte);

            Besinler adanaKebabi = new Besinler() { BesinAdi = " Adana Kebabı", Kalori = 2.29m, Karbonhidrat = 0.08m, Protein = 0.08m, Yag = 0.05m, CreatedBy = "Admin" }; context.Besinlers.Add(adanaKebabi);

            Besinler patlicanKebabi = new Besinler() { BesinAdi = " Patlıcan Kebabı", Kalori = 1.02m, Karbonhidrat = 0.048m, Protein = 0.09m, Yag = 0.045m, CreatedBy = "Admin" }; context.Besinlers.Add(patlicanKebabi);

            Besinler ormanKebabi = new Besinler() { BesinAdi = " Orman Kebabı", Kalori = 1.25m, Karbonhidrat = 0.1m, Protein = 0.048m, Yag = 0.04m, CreatedBy = "Admin" }; context.Besinlers.Add(ormanKebabi);

            Besinler kuzuSis = new Besinler() { BesinAdi = "Kuzu Şiş", Kalori = 1.67m, Karbonhidrat = 0.038m, Protein = 0.165m, Yag = 0.097m, CreatedBy = "Admin" }; context.Besinlers.Add(kuzuSis);

            Besinler tasKebabi = new Besinler() { BesinAdi = " Tas Kebabı", Kalori = 0.7m, Karbonhidrat = 0.07m, Protein = 0.05m, Yag = 0.04m, CreatedBy = "Admin" }; context.Besinlers.Add(tasKebabi);

            Besinler beytiKebabi = new Besinler() { BesinAdi = " Beyti Kebabı", Kalori = 2, Karbonhidrat = 0.13m, Protein = 0.1m, Yag = 0.12m, CreatedBy = "Admin" }; context.Besinlers.Add(beytiKebabi);

            Besinler cagKebabi = new Besinler() { BesinAdi = " Cağ Kebabı", Kalori = 1.67m, Karbonhidrat = 0.038m, Protein = 0.165m, Yag = 0.097m, CreatedBy = "Admin" }; context.Besinlers.Add(cagKebabi);

            Besinler tepsiKebabi = new Besinler() { BesinAdi = "Tepsi Kebabı", Kalori = 1.72m, Karbonhidrat = 0.04m, Protein = 0.106m, Yag = 0.123m, CreatedBy = "Admin" }; context.Besinlers.Add(tepsiKebabi);



            Besinler urfaKebabi = new Besinler() { BesinAdi = " Urfa Kebabı", Kalori = 1.77m, Karbonhidrat = 0.016m, Protein = 0.154m, Yag = 0.118m, CreatedBy = "Admin" }; context.Besinlers.Add(urfaKebabi);

            Besinler cokertmeKebabi = new Besinler() { BesinAdi = " Çökertme Kebabı", Kalori = 2.49m, Karbonhidrat = 0.12m, Protein = 0.105m, Yag = 0.28m, CreatedBy = "Admin" }; context.Besinlers.Add(cokertmeKebabi);

            Besinler kagıtKebabı = new Besinler() { BesinAdi = " Kağıt Kebabı", Kalori = 0.8m, Karbonhidrat = 0.036m, Protein = 0.103m, Yag = 0.028m, CreatedBy = "Admin" }; context.Besinlers.Add(kagıtKebabı);

            Besinler iskender = new Besinler() { BesinAdi = "İskender", Kalori = 1.93m, Karbonhidrat = 0.14m, Protein = 0.09m, Yag = 0.11m, CreatedBy = "Admin" }; context.Besinlers.Add(iskender);

            Besinler aliNazik = new Besinler() { BesinAdi = "Alinazik Kebabı", Kalori = 0.57m, Karbonhidrat = 0.03m, Protein = 0.035m, Yag = 0.034m, CreatedBy = "Admin" }; context.Besinlers.Add(aliNazik);

            Besinler manisaKebabi = new Besinler() { BesinAdi = " Manisa Kebabı", Kalori = 5.34m, Karbonhidrat = 3.35m, Protein = 2.33m, Yag = 3.36m, CreatedBy = "Admin" }; context.Besinlers.Add(manisaKebabi);

            Besinler soganKebabi = new Besinler() { BesinAdi = " Soğan Kebabı", Kalori = 2.79m, Karbonhidrat = 0.05m, Protein = 0.09m, Yag = 0.05m, CreatedBy = "Admin" }; context.Besinlers.Add(soganKebabi);

            Besinler ıslakHamburger = new Besinler() { BesinAdi = " Islak Hamburger", Kalori = 1.66m, Karbonhidrat = 0.153m, Protein = 0.07m, Yag = 0.08m, CreatedBy = "Admin" }; context.Besinlers.Add(ıslakHamburger);

            Besinler hamburger = new Besinler() { BesinAdi = "Hamburger", Kalori = 2.58m, Karbonhidrat = 0.265m, Protein = 0.147m, Yag = 0.104m, CreatedBy = "Admin" }; context.Besinlers.Add(hamburger);

            Besinler kiymaliBorek = new Besinler() { BesinAdi = " Kıymalı Börek", Kalori = 2.48m, Karbonhidrat = 0.288m, Protein = 0.092m, Yag = 0.104m, CreatedBy = "Admin" }; context.Besinlers.Add(kiymaliBorek);

            Besinler patlicanMusakka = new Besinler() { BesinAdi = " Patlıcan Musakka", Kalori = 1.42m, Karbonhidrat = 0.096m, Protein = 0.048m, Yag = 0.06m, CreatedBy = "Admin" }; context.Besinlers.Add(patlicanMusakka);

            Besinler kiymaliPide = new Besinler() { BesinAdi = " Kıymalı Pide", Kalori = 2.09m, Karbonhidrat = 0.245m, Protein = 0.082m, Yag = 0.085m, CreatedBy = "Admin" }; context.Besinlers.Add(kiymaliPide);

            Besinler kiymaliYumurta = new Besinler() { BesinAdi = " Kıymalı Yumurta", Kalori = 3.62m, Karbonhidrat = 0.074m, Protein = 0.25m, Yag = 0.074m, CreatedBy = "Admin" }; context.Besinlers.Add(kiymaliYumurta);

            Besinler kavrulmusKiyma = new Besinler() { BesinAdi = " Kavrulmuş Kıyma", Kalori = 2, Karbonhidrat = 0.007m, Protein = 0.276m, Yag = 0.122m, CreatedBy = "Admin" }; context.Besinlers.Add(kavrulmusKiyma);

            Besinler kiymaliMakarna = new Besinler() { BesinAdi = " Kıymalı Makarna", Kalori = 3.92m, Karbonhidrat = 0.539m, Protein = 0.155m, Yag = 0.121m, CreatedBy = "Admin" }; context.Besinlers.Add(kiymaliMakarna);

            Besinler kiymaliIspanak = new Besinler() { BesinAdi = " Kıymalı Ispanak", Kalori = 0.75m, Karbonhidrat = 0.105m, Protein = 0.036m, Yag = 0.023m, CreatedBy = "Admin" }; context.Besinlers.Add(kiymaliIspanak);

            Besinler kiymaliKarnabahar = new Besinler() { BesinAdi = " Kıymalı Karnabahar", Kalori = 1.12m, Karbonhidrat = 0.11m, Protein = 0.03m, Yag = 0.06m, CreatedBy = "Admin" }; context.Besinlers.Add(kiymaliKarnabahar);

            Besinler kiymaliKabak = new Besinler() { BesinAdi = " Kıymalı Kabak Yemeği", Kalori = 0.6m, Karbonhidrat = 0.105m, Protein = 0.022m, Yag = 0.016m, CreatedBy = "Admin" }; context.Besinlers.Add(kiymaliKabak);

            Besinler karniyarik = new Besinler() { BesinAdi = "Karnıyarık", Kalori = 0.55m, Karbonhidrat = 0.025m, Protein = 0.032m, Yag = 0.035m, CreatedBy = "Admin" }; context.Besinlers.Add(karniyarik);

            Besinler kiymaliBezelye = new Besinler() { BesinAdi = " Kıymalı Bezelye", Kalori = 0.96m, Karbonhidrat = 0.058m, Protein = 0.079m, Yag = 0.044m, CreatedBy = "Admin" }; context.Besinlers.Add(kiymaliBezelye);

            Besinler kiymaliBamya = new Besinler() { BesinAdi = " Kıymalı Bamya", Kalori = 0.45m, Karbonhidrat = 0.032m, Protein = 0.034m, Yag = 0.018m, CreatedBy = "Admin" }; context.Besinlers.Add(kiymaliBamya);

            Besinler kiymaliGozleme = new Besinler() { BesinAdi = " Kıymalı Gözleme", Kalori = 2.56m, Karbonhidrat = 0.445m, Protein = 0.103m, Yag = 0.06m, CreatedBy = "Admin" }; context.Besinlers.Add(kiymaliGozleme);

            Besinler kiymaliKabuska = new Besinler() { BesinAdi = " Kıymalı Kapuska", Kalori = 0.59m, Karbonhidrat = 0.049m, Protein = 0.025m, Yag = 0.032m, CreatedBy = "Admin" }; context.Besinlers.Add(kiymaliKabuska);

            Besinler kiymaliPatates = new Besinler() { BesinAdi = " Kıymalı Patates", Kalori = 0.8m, Karbonhidrat = 0.09m, Protein = 0.04m, Yag = 0.03m, CreatedBy = "Admin" }; context.Besinlers.Add(kiymaliPatates);

            Besinler kiymaliYaprakSarma = new Besinler() { BesinAdi = " Kıymalı Yaprak Sarma", Kalori = 1.06m, Karbonhidrat = 0.052m, Protein = 0.056m, Yag = 0.071m, CreatedBy = "Admin" }; context.Besinlers.Add(kiymaliYaprakSarma);

            Besinler kuzuKusleme = new Besinler() { BesinAdi = " Kuzu Küşleme", Kalori = 2.20m, Karbonhidrat = 0.025m, Protein = 0.328m, Yag = 0.09m, CreatedBy = "Admin" }; context.Besinlers.Add(kuzuKusleme);

            Besinler etliLahanaSarma = new Besinler() { BesinAdi = " Etli Lahana Sarma", Kalori = 1.25m, Karbonhidrat = 0.115m, Protein = 0.04m, Yag = 0.025m, CreatedBy = "Admin" }; context.Besinlers.Add(etliLahanaSarma);

            Besinler etliPilav = new Besinler() { BesinAdi = " Etli Pilav", Kalori = 1.42m, Karbonhidrat = 0.22m, Protein = 0.055m, Yag = 0.035m, CreatedBy = "Admin" }; context.Besinlers.Add(etliPilav);

            Besinler etliEkmek = new Besinler() { BesinAdi = " Etli Ekmek", Kalori = 3.07m, Karbonhidrat = 0.352m, Protein = 0.11m, Yag = 0.136m, CreatedBy = "Admin" }; context.Besinlers.Add(etliEkmek);


            //SEBZELER

            Besinler domates = new Besinler() { BesinAdi = "Domates", Kalori = 22, Karbonhidrat = 4.78m, Protein = 1.08m, Yag = 0.25m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(domates);

            Besinler ceriDomates = new Besinler() { BesinAdi = "Çeri Domates", Kalori = 27, Karbonhidrat = 5.8m, Protein = 1.31m, Yag = 0.30m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(ceriDomates);

            Besinler salatalik = new Besinler() { BesinAdi = "Salatalık", Kalori = 15, Karbonhidrat = 3.63m, Protein = 0.65m, Yag = 0.11m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(salatalik);

            Besinler marul = new Besinler() { BesinAdi = "Marul", Kalori = 5, Karbonhidrat = 1.03m, Protein = 0.5m, Yag = 0.05m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(marul);

            Besinler carlistonBiber = new Besinler() { BesinAdi = "Çarliston Biber", Kalori = 12, Karbonhidrat = 2.46m, Protein = 0.76m, Yag = 0.21m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(carlistonBiber);

            Besinler kirmiziBiber = new Besinler() { BesinAdi = " Kırmızı Biber", Kalori = 37, Karbonhidrat = 7.18m, Protein = 1.18m, Yag = 0.36m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kirmiziBiber);

            Besinler nane = new Besinler() { BesinAdi = "Nane", Kalori = 1, Karbonhidrat = 0.24m, Protein = 0.06m, Yag = 0.001m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(nane);

            Besinler feslegen = new Besinler() { BesinAdi = "Feslegen", Kalori = 1, Karbonhidrat = 0.23m, Protein = 0.13m, Yag = 0.03m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(feslegen);

            Besinler dereotu = new Besinler() { BesinAdi = "Dereotu", Kalori = 1, Karbonhidrat = 0.23m, Protein = 0.13m, Yag = 0.01m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(dereotu);

            Besinler kisnis = new Besinler() { BesinAdi = "Kişniş", Kalori = 5, Karbonhidrat = 0.99m, Protein = 0.22m, Yag = 0.32m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kisnis);

            Besinler biberiye = new Besinler() { BesinAdi = "Biberiye", Kalori = 4, Karbonhidrat = 0.77m, Protein = 0.06m, Yag = 0.18m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(biberiye);

            Besinler maydanoz = new Besinler() { BesinAdi = "Maydanoz", Kalori = 1, Karbonhidrat = 0.24m, Protein = 0.11m, Yag = 0.03m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(maydanoz);

            Besinler turp = new Besinler() { BesinAdi = "Turp", Kalori = 19, Karbonhidrat = 3.94m, Protein = 0.79m, Yag = 0.12m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(turp);

            Besinler karnabahar = new Besinler() { BesinAdi = "Karnabahar", Kalori = 27, Karbonhidrat = 5.32m, Protein = 2.05m, Yag = 0.3m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(karnabahar);

            Besinler brokoli = new Besinler() { BesinAdi = "Brokoli", Kalori = 31, Karbonhidrat = 6.04m, Protein = 2.57m, Yag = 0.34m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(brokoli);

            Besinler brukselLahana = new Besinler() { BesinAdi = "Brüksel Lahana", Kalori = 38, Karbonhidrat = 7.88m, Protein = 2.97m, Yag = 0.26m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(brukselLahana);

            Besinler beyazLahana = new Besinler() { BesinAdi = "Beyaz Lahana", Kalori = 22, Karbonhidrat = 5.16m, Protein = 1.14m, Yag = 0.09m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(beyazLahana);

            Besinler kirmiziLahana = new Besinler() { BesinAdi = "Kırmızı Lahana", Kalori = 28, Karbonhidrat = 6.56m, Protein = 1.27m, Yag = 0.14m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kirmiziLahana);

            Besinler havuc = new Besinler() { BesinAdi = "Havuc", Kalori = 25, Karbonhidrat = 5.84m, Protein = 0.57m, Yag = 0.15m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(havuc);

            Besinler sarimsak = new Besinler() { BesinAdi = "Sarımsak", Kalori = 4, Karbonhidrat = 0.99m, Protein = 0.19m, Yag = 0.02m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(sarimsak);

            Besinler sogan = new Besinler() { BesinAdi = "Soğan", Kalori = 44, Karbonhidrat = 10.27m, Protein = 1.21m, Yag = 0.11m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(sogan);

            Besinler yesilSogan = new Besinler() { BesinAdi = "Yeşil Soğan", Kalori = 2, Karbonhidrat = 0.44m, Protein = 0.11m, Yag = 0.01m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(yesilSogan);

            Besinler semizotu = new Besinler() { BesinAdi = "Semizotu", Kalori = 9, Karbonhidrat = 1.46m, Protein = 0.87m, Yag = 0.15m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(semizotu);

            Besinler pazi = new Besinler() { BesinAdi = "Pazı", Kalori = 7, Karbonhidrat = 1.35m, Protein = 0.65m, Yag = 0.07m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(pazi);

            Besinler kabak = new Besinler() { BesinAdi = "Kabak", Kalori = 33, Karbonhidrat = 6.10m, Protein = 2.37m, Yag = 0.63m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kabak);

            Besinler roka = new Besinler() { BesinAdi = "Roka", Kalori = 5, Karbonhidrat = 0.73m, Protein = 0.52m, Yag = 0.13m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(roka);


            //SEBZE YEMEKLERİ

            Besinler ispanakYemeği = new Besinler() { BesinAdi = "Ispanak Yemeği (Etsiz)", GramKarsiligi = 100, Kalori = 115, Karbonhidrat = 5.09m, Protein = 2.11m, Yag = 10.3m, CreatedBy = "Admin" }; context.Besinlers.Add(ispanakYemeği);

            Besinler zeytinyagliSemizotu = new Besinler() { BesinAdi = "Zeytinyağlı Semizotu", GramKarsiligi = 100, Kalori = 112, Karbonhidrat = 4.98m, Protein = 1.29m, Yag = 10.26m, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinyagliSemizotu);

            Besinler zeytinyağliPazi = new Besinler() { BesinAdi = "Zeytinyağlı Pazı", GramKarsiligi = 100, Kalori = 131, Karbonhidrat = 11.89m, Protein = 3.74m, Yag = 7.18m, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinyağliPazi);

            Besinler zeytinyağliTazeFasulye = new Besinler() { BesinAdi = "Zeytinyağlı Taze Fasülye", GramKarsiligi = 100, Kalori = 151, Karbonhidrat = 21.39m, Protein = 5.54m, Yag = 5.51m, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinyağliTazeFasulye);

            Besinler zeytinyağliPirasa = new Besinler() { BesinAdi = "Zeytinyağlı Pırasa", GramKarsiligi = 100, Kalori = 120, Karbonhidrat = 7.25m, Protein = 0.91m, Yag = 10.27m, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinyağliPirasa);

            Besinler bezelyeYemeği = new Besinler() { BesinAdi = "Bezelye Yemeği (Etsiz)", GramKarsiligi = 100, Kalori = 147, Karbonhidrat = 11.07m, Protein = 3.48m, Yag = 10.38m, CreatedBy = "Admin" }; context.Besinlers.Add(bezelyeYemeği);

            Besinler zeytinyağliBrokoli = new Besinler() { BesinAdi = "Zeytinyağlı Brokoli", GramKarsiligi = 100, Kalori = 80, Karbonhidrat = 7.14m, Protein = 2.37m, Yag = 5.41m, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinyağliBrokoli);

            Besinler karnabaharYemegi = new Besinler() { BesinAdi = "Karnabahar Yemeği(Etsiz)", GramKarsiligi = 100, Kalori = 115, Karbonhidrat = 5.29m, Protein = 1.48m, Yag = 10.41m, CreatedBy = "Admin" }; context.Besinlers.Add(karnabaharYemegi);

            Besinler bamyaYemegi = new Besinler() { BesinAdi = "Bamya Yemeği (Etsiz)", GramKarsiligi = 100, Kalori = 113, Karbonhidrat = 4.68m, Protein = 1.06m, Yag = 10.57m, CreatedBy = "Admin" }; context.Besinlers.Add(bamyaYemegi);

            Besinler zeytinyağliTurlu = new Besinler() { BesinAdi = "Zeytinyağlı Türlü", GramKarsiligi = 100, Kalori = 112, Karbonhidrat = 8.68m, Protein = 1.33m, Yag = 8.87m, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinyağliTurlu);

            Besinler zeytinyağliBakla = new Besinler() { BesinAdi = "Zeytinyağlı Bakla", GramKarsiligi = 100, Kalori = 145, Karbonhidrat = 9.76m, Protein = 3.32m, Yag = 10.69m, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinyağliBakla);

            Besinler zeytinyağliKereviz = new Besinler() { BesinAdi = "Zeytinyağlı Kereviz", GramKarsiligi = 100, Kalori = 90, Karbonhidrat = 7.14m, Protein = 1.92m, Yag = 6.37m, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinyağliKereviz);

            Besinler zeytinyağliEnginar = new Besinler() { BesinAdi = "Zeytinyağlı Enginar", GramKarsiligi = 100, Kalori = 146, Karbonhidrat = 12.09m, Protein = 2.93m, Yag = 10.71m, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinyağliEnginar);

            Besinler sebzeSote = new Besinler() { BesinAdi = "Sebze Sote", GramKarsiligi = 100, Kalori = 90, Karbonhidrat = 4.55m, Protein = 0.94m, Yag = 10.19m, CreatedBy = "Admin" }; context.Besinlers.Add(sebzeSote);

            Besinler zeytinyağliSebzeDolmasi = new Besinler() { BesinAdi = "Zeytinyağlı Sebze Dolması", GramKarsiligi = 100, Kalori = 258, Karbonhidrat = 13.59m, Protein = 5.6m, Yag = 13.6m, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinyağliSebzeDolmasi);

            Besinler zeytinyağliYaprakSarma = new Besinler() { BesinAdi = "Zeytinyağlı Yaprak Sarma", GramKarsiligi = 100, Kalori = 108, Karbonhidrat = 8.32m, Protein = 1.33m, Yag = 8.15m, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinyağliYaprakSarma);

            Besinler zeytinyağliKabak = new Besinler() { BesinAdi = "Zeytinyağlı Kabak", GramKarsiligi = 100, Kalori = 111, Karbonhidrat = 5.19m, Protein = 0.81m, Yag = 10.18m, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinyağliKabak);


            //SALATALAR           
            Besinler sadeSalata = new Besinler() { BesinAdi = "Sade Salata (Karışık Yeşillik)", GramKarsiligi = 100, Kalori = 9, Karbonhidrat = 1.76m, Protein = 0.84m, Yag = 0.13m, CreatedBy = "Admin" }; context.Besinlers.Add(sadeSalata);

            Besinler mercimekliPeynirliSalata = new Besinler() { BesinAdi = "Mercimekli Lor Peynirli Salata", GramKarsiligi = 100, Kalori = 180, Karbonhidrat = 28, Protein = 2.7m, Yag = 5.1m, CreatedBy = "Admin" }; context.Besinlers.Add(mercimekliPeynirliSalata);

            Besinler tavukluSalata = new Besinler() { BesinAdi = "Tavuklu Salata", GramKarsiligi = 100, Kalori = 225, Karbonhidrat = 5.28m, Protein = 31.38m, Yag = 8.29m, CreatedBy = "Admin" }; context.Besinlers.Add(tavukluSalata);

            Besinler etliSalata = new Besinler() { BesinAdi = "Etli Salata (bonfileli/köfteli/fümeli)", GramKarsiligi = 100, Kalori = 267, Karbonhidrat = 5.28m, Protein = 24.84m, Yag = 16.49m, CreatedBy = "Admin" }; context.Besinlers.Add(etliSalata);

            Besinler tonBalikliSalata = new Besinler() { BesinAdi = "Ton Balıklı Salata", GramKarsiligi = 100, Kalori = 215, Karbonhidrat = 5.28m, Protein = 21.96m, Yag = 6.35m, CreatedBy = "Admin" }; context.Besinlers.Add(tonBalikliSalata);

            Besinler kisir = new Besinler() { BesinAdi = "Kısır", GramKarsiligi = 100, Kalori = 108, Karbonhidrat = 15.84m, Protein = 2.71m, Yag = 4.64m, CreatedBy = "Admin" }; context.Besinlers.Add(kisir);

            Besinler mercimekKoftesi = new Besinler() { BesinAdi = "Mercimet Köftesi", GramKarsiligi = 100, Kalori = 70, Karbonhidrat = 9.95m, Protein = 2.75m, Yag = 2.41m, CreatedBy = "Admin" }; context.Besinlers.Add(mercimekKoftesi);

            Besinler tabuleSalatasi = new Besinler() { BesinAdi = "Tabule Salatası", GramKarsiligi = 100, Kalori = 588, Karbonhidrat = 51, Protein = 14.4m, Yag = 33.3m, CreatedBy = "Admin" }; context.Besinlers.Add(tabuleSalatasi);

            Besinler peynirliYumurtaliSalata = new Besinler() { BesinAdi = "Peynirli Yumurtalı Salata", GramKarsiligi = 100, Kalori = 225, Karbonhidrat = 6.7m, Protein = 16.78m, Yag = 9.81m, CreatedBy = "Admin" }; context.Besinlers.Add(peynirliYumurtaliSalata);

            Besinler cobanSalata = new Besinler() { BesinAdi = "Çoban Salata", GramKarsiligi = 100, Kalori = 115, Karbonhidrat = 16.62m, Protein = 3.19m, Yag = 3.76m, CreatedBy = "Admin" }; context.Besinlers.Add(cobanSalata);

            Besinler gavurdağiSalata = new Besinler() { BesinAdi = "Gavurdağı Salata", GramKarsiligi = 100, Kalori = 114, Karbonhidrat = 7.71m, Protein = 2.95m, Yag = 7.72m, CreatedBy = "Admin" }; context.Besinlers.Add(gavurdağiSalata);

            Besinler patatesSalatasi = new Besinler() { BesinAdi = "Patates Salatası", GramKarsiligi = 100, Kalori = 132, Karbonhidrat = 21.77m, Protein = 2.46m, Yag = 3.33m, CreatedBy = "Admin" }; context.Besinlers.Add(patatesSalatasi);

            Besinler meyveSalatasi = new Besinler() { BesinAdi = "Meyve Salatası", GramKarsiligi = 100, Kalori = 172, Karbonhidrat = 38.4m, Protein = 1.65m, Yag = 0.96m, CreatedBy = "Admin" }; context.Besinlers.Add(meyveSalatasi);

            //ATIŞTIRMALIKLAR



            Besinler patatesCipsi = new Besinler() { BesinAdi = "Patates Cipsi", GramKarsiligi = 100, Kalori = 719, Karbonhidrat = 10.46m, Protein = 1.23m, Yag = 74.78m, CreatedBy = "Admin" };
            context.Besinlers.Add(patatesCipsi);



            Besinler misirCipsi = new Besinler() { BesinAdi = "Mısır Cipsi", GramKarsiligi = 100, Kalori = 404, Karbonhidrat = 42.68m, Protein = 4.95m, Yag = 25.05m, CreatedBy = "Admin" };
            context.Besinlers.Add(misirCipsi);



            Besinler pringles = new Besinler() { BesinAdi = "Pringles Original", GramKarsiligi = 100, Kalori = 861, Karbonhidrat = 84.15m, Protein = 6.27m, Yag = 56.1m, CreatedBy = "Admin" };
            context.Besinlers.Add(pringles);



            Besinler ulkerGofret = new Besinler() { BesinAdi = "Ülker Çikolatalı Gofret", GramKarsiligi = 100, Kalori = 198, Karbonhidrat = 20.72m, Protein = 2.13m, Yag = 11.83m, CreatedBy = "Admin" };
            context.Besinlers.Add(ulkerGofret);



            Besinler jelibon = new Besinler() { BesinAdi = "Jelibon", GramKarsiligi = 100, Kalori = 302, Karbonhidrat = 68.31m, Protein = 5.85m, Yag = 0.09m, CreatedBy = "Admin" };
            context.Besinlers.Add(jelibon);



            Besinler petiborBiskuvi = new Besinler() { BesinAdi = "Petibör Bisküvi", GramKarsiligi = 100, Kalori = 765, Karbonhidrat = 139.77m, Protein = 13.53m, Yag = 16.8m, CreatedBy = "Admin" };
            context.Besinlers.Add(petiborBiskuvi);



            Besinler formKepekliBiskuvi = new Besinler() { BesinAdi = "Form Kepekli Bisküvi", GramKarsiligi = 100, Kalori = 184, Karbonhidrat = 26.69m, Protein = 5.9m, Yag = 4.86m, CreatedBy = "Admin" };
            context.Besinlers.Add(formKepekliBiskuvi);



            Besinler ciciBebeBiskuvi = new Besinler() { BesinAdi = "Cicibebe Bisküvi", GramKarsiligi = 100, Kalori = 18, Karbonhidrat = 2.96m, Protein = 0.18m, Yag = 0.6m, CreatedBy = "Admin" };
            context.Besinlers.Add(ciciBebeBiskuvi);



            Besinler cikolata = new Besinler() { BesinAdi = "Çikolata", GramKarsiligi = 100, Kalori = 26, Karbonhidrat = 2.9m, Protein = 0.22m, Yag = 1.76m, CreatedBy = "Admin" };
            context.Besinlers.Add(cikolata);



            Besinler proteinBar = new Besinler() { BesinAdi = "Protein Bar", GramKarsiligi = 100, Kalori = 76, Karbonhidrat = 6.6m, Protein = 2.21m, Yag = 4.54m, CreatedBy = "Admin" };
            context.Besinlers.Add(proteinBar);



            Besinler oreo = new Besinler() { BesinAdi = "Oreo", GramKarsiligi = 100, Kalori = 270, Karbonhidrat = 41.04m, Protein = 2, Yag = 10.83m, CreatedBy = "Admin" };
            context.Besinlers.Add(oreo);



            Besinler olips = new Besinler() { BesinAdi = "Olips Şeker", GramKarsiligi = 100, Kalori = 286, Karbonhidrat = 72.2m, Protein = 0, Yag = 0, CreatedBy = "Admin" };
            context.Besinlers.Add(olips);



            Besinler tadelle = new Besinler() { BesinAdi = "Tadelle Çikolata", GramKarsiligi = 100, Kalori = 167, Karbonhidrat = 14.31m, Protein = 2.7m, Yag = 10.98m, CreatedBy = "Admin" };
            context.Besinlers.Add(tadelle);



            Besinler dido = new Besinler() { BesinAdi = "Dido Çikolata", GramKarsiligi = 100, Kalori = 190, Karbonhidrat = 21.88m, Protein = 2.7m, Yag = 9.98m, CreatedBy = "Admin" };
            context.Besinlers.Add(dido);



            Besinler karamGurme = new Besinler() { BesinAdi = "Karam Gurme", GramKarsiligi = 100, Kalori = 259, Karbonhidrat = 29, Protein = 2.75m, Yag = 14, CreatedBy = "Admin" };
            context.Besinlers.Add(karamGurme);



            Besinler etiBrownie = new Besinler() { BesinAdi = "Eti Brownie Gold", GramKarsiligi = 100, Kalori = 154, Karbonhidrat = 22, Protein = 2.04m, Yag = 7.92m, CreatedBy = "Admin" };
            context.Besinlers.Add(etiBrownie);



            Besinler kinderSutDilimi = new Besinler() { BesinAdi = "Kinder Süt Dilimi", GramKarsiligi = 100, Kalori = 118, Karbonhidrat = 10.75m, Protein = 2.16m, Yag = 7.28m, CreatedBy = "Admin" };
            context.Besinlers.Add(kinderSutDilimi);



            Besinler kinderSurpriz = new Besinler() { BesinAdi = "Kinder Sürpriz Yumurta", GramKarsiligi = 100, Kalori = 110, Karbonhidrat = 10.4m, Protein = 1.6m, Yag = 6.8m, CreatedBy = "Admin" };
            context.Besinlers.Add(kinderSurpriz);



            Besinler etiGong = new Besinler() { BesinAdi = "Eti Gong", GramKarsiligi = 100, Kalori = 50, Karbonhidrat = 7.84m, Protein = 0.64m, Yag = 1.78m, CreatedBy = "Admin" };
            context.Besinlers.Add(etiGong);



            Besinler biskrem = new Besinler() { BesinAdi = "Biskrem", GramKarsiligi = 100, Kalori = 50, Karbonhidrat = 6.51m, Protein = 0.45m, Yag = 2.41m, CreatedBy = "Admin" };
            context.Besinlers.Add(biskrem);



            Besinler probis = new Besinler() { BesinAdi = "Ülker Probis", GramKarsiligi = 100, Kalori = 39, Karbonhidrat = 4.37m, Protein = 0.93m, Yag = 1.9m, CreatedBy = "Admin" };
            context.Besinlers.Add(probis);



            Besinler sutBurger = new Besinler() { BesinAdi = "Süt Burger", GramKarsiligi = 100, Kalori = 113, Karbonhidrat = 17.05m, Protein = 1.75m, Yag = 3.78m, CreatedBy = "Admin" };
            context.Besinlers.Add(sutBurger);



            Besinler dankek = new Besinler() { BesinAdi = "Dankek 8kek", GramKarsiligi = 100, Kalori = 90, Karbonhidrat = 12.65m, Protein = 0.88m, Yag = 4.01m, CreatedBy = "Admin" };
            context.Besinlers.Add(dankek);



            Besinler brownieIntense = new Besinler() { BesinAdi = "Brownie Intense", GramKarsiligi = 100, Kalori = 232, Karbonhidrat = 26.5m, Protein = 2.3m, Yag = 12.85m, CreatedBy = "Admin" };
            context.Besinlers.Add(brownieIntense);



            Besinler etiTopkek1 = new Besinler() { BesinAdi = "Eti Topkek Kakolu", GramKarsiligi = 100, Kalori = 167, Karbonhidrat = 22.96m, Protein = 2.12m, Yag = 7.24m, CreatedBy = "Admin" };
            context.Besinlers.Add(etiTopkek1);



            Besinler etiPopkek2 = new Besinler() { BesinAdi = "Eti Popkek Meyveli", GramKarsiligi = 100, Kalori = 264, Karbonhidrat = 34.62m, Protein = 2.82m, Yag = 12.6m, CreatedBy = "Admin" }; context.Besinlers.Add(etiPopkek2);

            Besinler etiTopKek3 = new Besinler() { BesinAdi = "Eti Topkek Portakallı", GramKarsiligi = 100, Kalori = 167, Karbonhidrat = 22.96m, Protein = 2.12m, Yag = 7.24m, CreatedBy = "Admin" }; context.Besinlers.Add(etiTopKek3);

            Besinler halley = new Besinler() { BesinAdi = "Halley", GramKarsiligi = 100, Kalori = 132, Karbonhidrat = 20.31m, Protein = 1.2m, Yag = 5.1m, CreatedBy = "Admin" }; context.Besinlers.Add(halley);

            Besinler kremaliBiskuvi = new Besinler() { BesinAdi = "Ülker Kremalı Bisküvi", GramKarsiligi = 100, Kalori = 33, Karbonhidrat = 5.16m, Protein = 0.36m, Yag = 1.27m, CreatedBy = "Admin" }; context.Besinlers.Add(kremaliBiskuvi);

            Besinler cokoprens = new Besinler() { BesinAdi = "Ülker Çokoprens", GramKarsiligi = 100, Kalori = 152, Karbonhidrat = 18.6m, Protein = 1.68m, Yag = 7.8m, CreatedBy = "Admin" }; context.Besinlers.Add(cokoprens);

            Besinler etiCin = new Besinler() { BesinAdi = "Eti Cin", GramKarsiligi = 100, Kalori = 44, Karbonhidrat = 7.43m, Protein = 0.47m, Yag = 1.38m, CreatedBy = "Admin" }; context.Besinlers.Add(etiCin);

            Besinler etiNero = new Besinler() { BesinAdi = "Eti Nero", GramKarsiligi = 100, Kalori = 584, Karbonhidrat = 69.72m, Protein = 8.28m, Yag = 29.28m, CreatedBy = "Admin" }; context.Besinlers.Add(etiNero);

            Besinler etiTutku = new Besinler() { BesinAdi = "Eti Tutku", GramKarsiligi = 100, Kalori = 51, Karbonhidrat = 6.1m, Protein = 0.5m, Yag = 2.6m, CreatedBy = "Admin" }; context.Besinlers.Add(etiTutku);

            Besinler etiBenimO = new Besinler() { BesinAdi = "Eti Benim'O", GramKarsiligi = 100, Kalori = 46, Karbonhidrat = 6.13m, Protein = 0.47m, Yag = 2.16m, CreatedBy = "Admin" }; context.Besinlers.Add(etiBenimO);

            Besinler etiBurcak = new Besinler() { BesinAdi = "Eti Burçak", GramKarsiligi = 100, Kalori = 68, Karbonhidrat = 9.87m, Protein = 0.93m, Yag = 2.54m, CreatedBy = "Admin" }; context.Besinlers.Add(etiBurcak);

            Besinler ulkerIkram = new Besinler() { BesinAdi = "Ülker İkram", GramKarsiligi = 100, Kalori = 405, Karbonhidrat = 52.92m, Protein = 6.47m, Yag = 17.64m, CreatedBy = "Admin" }; context.Besinlers.Add(ulkerIkram);

            Besinler lotus = new Besinler() { BesinAdi = "Lotus Bisküvi", GramKarsiligi = 100, Kalori = 605, Karbonhidrat = 90.75m, Protein = 6.13m, Yag = 23.75m, CreatedBy = "Admin" }; context.Besinlers.Add(lotus);

            Besinler gretaZeytinli = new Besinler() { BesinAdi = "Şölen Greta Zeytinli", GramKarsiligi = 100, Kalori = 133, Karbonhidrat = 18.1m, Protein = 2.8m, Yag = 5.4m, CreatedBy = "Admin" }; context.Besinlers.Add(gretaZeytinli);

            Besinler cokonat = new Besinler() { BesinAdi = "Ülker Çokonat", GramKarsiligi = 100, Kalori = 181, Karbonhidrat = 19.11m, Protein = 2.05m, Yag = 11.32m, CreatedBy = "Admin" }; context.Besinlers.Add(cokonat);

            Besinler kinderBueno = new Besinler() { BesinAdi = "Kinder Bueno", GramKarsiligi = 100, Kalori = 120, Karbonhidrat = 10.4m, Protein = 1.81m, Yag = 7.83m, CreatedBy = "Admin" }; context.Besinlers.Add(kinderBueno);

            Besinler etiHoşbeş = new Besinler() { BesinAdi = "Eti Hoşbeş", GramKarsiligi = 100, Kalori = 197, Karbonhidrat = 25.56m, Protein = 3.04m, Yag = 9.8m, CreatedBy = "Admin" }; context.Besinlers.Add(etiHoşbeş);

            Besinler twix = new Besinler() { BesinAdi = "Twix", GramKarsiligi = 100, Kalori = 250, Karbonhidrat = 34, Protein = 4, Yag = 12, CreatedBy = "Admin" }; context.Besinlers.Add(twix);

            Besinler snickers = new Besinler() { BesinAdi = "Snickers", GramKarsiligi = 100, Kalori = 237, Karbonhidrat = 31.31m, Protein = 3.8m, Yag = 11.35m, CreatedBy = "Admin" }; context.Besinlers.Add(snickers);

            Besinler mars = new Besinler() { BesinAdi = "Mars", GramKarsiligi = 100, Kalori = 225, Karbonhidrat = 35, Protein = 2, Yag = 8.5m, CreatedBy = "Admin" }; context.Besinlers.Add(mars);

            Besinler albeni = new Besinler() { BesinAdi = "Ülker Albeni", GramKarsiligi = 100, Kalori = 206, Karbonhidrat = 25.2m, Protein = 2.24m, Yag = 10.64m, CreatedBy = "Admin" }; context.Besinlers.Add(albeni);

            Besinler crunch = new Besinler() { BesinAdi = "Crunch Çikolata", GramKarsiligi = 100, Kalori = 169, Karbonhidrat = 20.16m, Protein = 2.05m, Yag = 8.74m, CreatedBy = "Admin" }; context.Besinlers.Add(crunch);

            Besinler metro = new Besinler() { BesinAdi = "Ülker Metro", GramKarsiligi = 100, Kalori = 184, Karbonhidrat = 27.36m, Protein = 1.96m, Yag = 7.4m, CreatedBy = "Admin" }; context.Besinlers.Add(metro);

            Besinler frigo = new Besinler() { BesinAdi = "Alaska Frigo", GramKarsiligi = 100, Kalori = 193, Karbonhidrat = 22.98m, Protein = 2.4m, Yag = 9.78m, CreatedBy = "Admin" }; context.Besinlers.Add(frigo);

            Besinler cocoStar = new Besinler() { BesinAdi = "Coco Star", GramKarsiligi = 100, Kalori = 148, Karbonhidrat = 15.48m, Protein = 1.2m, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(cocoStar);

            Besinler cubukKraker = new Besinler() { BesinAdi = "Sade Çubuk Kraker", GramKarsiligi = 100, Kalori = 200, Karbonhidrat = 40.82m, Protein = 5.51m, Yag = 2.91m, CreatedBy = "Admin" }; context.Besinlers.Add(cubukKraker);

            Besinler susamliCubukKraker = new Besinler() { BesinAdi = "Susamlı Çubuk Kraker", GramKarsiligi = 100, Kalori = 172, Karbonhidrat = 22.39m, Protein = 3.89m, Yag = 7.1m, CreatedBy = "Admin" }; context.Besinlers.Add(susamliCubukKraker);

            Besinler cizi = new Besinler() { BesinAdi = "Çizi Bisküvi", GramKarsiligi = 100, Kalori = 113, Karbonhidrat = 5.47m, Protein = 3.15m, Yag = 8.86m, CreatedBy = "Admin" }; context.Besinlers.Add(cizi);

            Besinler cornetto = new Besinler() { BesinAdi = "Cornetto", GramKarsiligi = 100, Kalori = 125, Karbonhidrat = 15, Protein = 1.56m, Yag = 6.25m, CreatedBy = "Admin" }; context.Besinlers.Add(cornetto);

            Besinler magnum = new Besinler() { BesinAdi = "Magnum", GramKarsiligi = 100, Kalori = 239, Karbonhidrat = 24.64m, Protein = 2.7m, Yag = 14.63m, CreatedBy = "Admin" }; context.Besinlers.Add(magnum);

            Besinler misirGevregi = new Besinler() { BesinAdi = "Mısır Gevreği / Cornflakes", GramKarsiligi = 100, Kalori = 179, Karbonhidrat = 42.05m, Protein = 3.75m, Yag = 0.2m, CreatedBy = "Admin" }; context.Besinlers.Add(misirGevregi);

            Besinler yulafEzmesi = new Besinler() { BesinAdi = "Yulaf Ezmesi", GramKarsiligi = 100, Kalori = 195, Karbonhidrat = 33.14m, Protein = 8.45m, Yag = 3.45m, CreatedBy = "Admin" };

            context.Besinlers.Add(yulafEzmesi);


            //ALKOLSÜZ İÇECEKLER


            Besinler madenSuyu = new Besinler() { BesinAdi = "Maden Suyu", Kalori = 0, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(madenSuyu);

            Besinler bergamotCayi = new Besinler() { BesinAdi = "Bergamot Çayı (150 ml)", Kalori = 2.6m, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(bergamotCayi);

            Besinler boza = new Besinler() { BesinAdi = "Boza", Kalori = 279, Karbonhidrat = 60, Protein = 45, Yag = 1.8m, CreatedBy = "Admin" }; context.Besinlers.Add(boza);

            Besinler salep = new Besinler() { BesinAdi = "Salep", Kalori = 188, Karbonhidrat = 27.8m, Protein = 5.6m, Yag = 6, CreatedBy = "Admin" }; context.Besinlers.Add(salep);

            Besinler sprite = new Besinler() { BesinAdi = "Kahve", Kalori = 79, Karbonhidrat = 21.4m, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(sprite);

            Besinler cocaCola = new Besinler() { BesinAdi = "CocaCola", Kalori = 90, Karbonhidrat = 22.4m, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(cocaCola);

            Besinler diyetKola = new Besinler() { BesinAdi = "CocaCola Light", Kalori = 0, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(diyetKola);

            Besinler colaZero = new Besinler() { BesinAdi = "CocaCola Zero", Kalori = 0, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(colaZero);

            Besinler fanta = new Besinler() { BesinAdi = "Fanta", Kalori = 95, Karbonhidrat = 23.4m, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(fanta);

            Besinler iceTea = new Besinler() { BesinAdi = "Bergamot Çayı", Kalori = 60, Karbonhidrat = 14, Protein = 1, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(iceTea);

            Besinler limonata = new Besinler() { BesinAdi = "Limonata", Kalori = 73, Karbonhidrat = 14.69m, Protein = 0.24m, Yag = 0.2m, CreatedBy = "Admin" }; context.Besinlers.Add(limonata);

            Besinler gazoz = new Besinler() { BesinAdi = "Gazoz", Kalori = 84, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(gazoz);

            Besinler kahve = new Besinler() { BesinAdi = "Kahve", Kalori = 2, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(kahve);

            Besinler milkshake = new Besinler() { BesinAdi = "Milkshake", Kalori = 230, Karbonhidrat = 36.8m, Protein = 7.2m, Yag = 5.6m, CreatedBy = "Admin" }; context.Besinlers.Add(milkshake);

            Besinler smoothie = new Besinler() { BesinAdi = "Smoothie", Kalori = 82, Karbonhidrat = 21, Protein = 0.1m, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(smoothie);

            Besinler meyveSuyu = new Besinler() { BesinAdi = "Meyve Suyu", Kalori = 100, Karbonhidrat = 24.2m, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(meyveSuyu);

            Besinler portakalSuyu = new Besinler() { BesinAdi = "Taze Sıkma Portakal Suyu", Kalori = 120, Karbonhidrat = 29.28m, Protein = 0.8m, Yag = 0.33m, CreatedBy = "Admin" }; context.Besinlers.Add(portakalSuyu);

            Besinler narSuyu = new Besinler() { BesinAdi = "Nar Suyu", Kalori = 2, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(narSuyu);

            Besinler salgamSuyu = new Besinler() { BesinAdi = "Şalgam Suyu", Kalori = 10, Karbonhidrat = 2.12m, Protein = 1.03m, Yag = 0.22m, CreatedBy = "Admin" }; context.Besinlers.Add(salgamSuyu);

            Besinler sicakCikolata = new Besinler() { BesinAdi = "Sıcak Çikolata", Kalori = 106, Karbonhidrat = 26.06m, Protein = 0, Yag = 0.1m, CreatedBy = "Admin" }; context.Besinlers.Add(sicakCikolata);

            Besinler powerade = new Besinler() { BesinAdi = "Powerade", Kalori = 32, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(powerade);

            Besinler redBull = new Besinler() { BesinAdi = "Red Bull", Kalori = 90, Karbonhidrat = 22, Protein = 0.6m, Yag = 0.2m, CreatedBy = "Admin" }; context.Besinlers.Add(redBull);

            Besinler zencefilliCay = new Besinler() { BesinAdi = "Zencefilli Bitki Çayı", Kalori = 0, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(zencefilliCay);

            Besinler cay = new Besinler() { BesinAdi = "Çay", Kalori = 10, Karbonhidrat = 2.35m, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(cay);

            Besinler turkKahvesi = new Besinler() { BesinAdi = "Türk Kahvesi", Kalori = 4, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(turkKahvesi);

            Besinler whiteChocolateMocha = new Besinler() { BesinAdi = "White Chocolate Mocha", Kalori = 259, Karbonhidrat = 31.86m, Protein = 7.55m, Yag = 12.04m, CreatedBy = "Admin" }; context.Besinlers.Add(whiteChocolateMocha);

            Besinler coolLime = new Besinler() { BesinAdi = "Cool Lime", Kalori = 25, Karbonhidrat = 6.99m, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(coolLime);

            Besinler berryHibiscus = new Besinler() { BesinAdi = "Starbucks Berry Hibiscus", Kalori = 60, Karbonhidrat = 20, Protein = 0, Yag = 0, CreatedBy = "Admin" }; context.Besinlers.Add(berryHibiscus);

            Besinler cappuccino = new Besinler() { BesinAdi = "Cappuccino", Kalori = 50, Karbonhidrat = 7, Protein = 4.19m, Yag = 0.005m, CreatedBy = "Admin" }; context.Besinlers.Add(cappuccino);

            Besinler latte = new Besinler() { BesinAdi = "Latte", Kalori = 60, Karbonhidrat = 8.5m, Protein = 6, Yag = 0.005m, CreatedBy = "Admin" }; context.Besinlers.Add(latte);

            Besinler filtreKahve = new Besinler() { BesinAdi = "Filtre Kahve", Kalori = 3, Karbonhidrat = 0, Protein = 0.28m, Yag = 0.07m, CreatedBy = "Admin" }; context.Besinlers.Add(filtreKahve);

            Besinler nescafeXpress = new Besinler() { BesinAdi = "Nescafe Xpress", Kalori = 100, Karbonhidrat = 16.4m, Protein = 2.8m, Yag = 2.6m, CreatedBy = "Admin" }; context.Besinlers.Add(nescafeXpress);

            Besinler nescafe3 = new Besinler() { BesinAdi = "Nescafe 3'ü 1 arada", Kalori = 81, Karbonhidrat = 15.19m, Protein = 0.5m, Yag = 1.89m, CreatedBy = "Admin" }; context.Besinlers.Add(nescafe3);


            //EV YEMEKLERİ

            Besinler pilavUstuFasulye = new Besinler() { BesinAdi = "Pilav Üstü Kuru", GramKarsiligi = 100, Kalori = 336, Karbonhidrat = 57.52m, Protein = 15.28m, Yag = 4.44m, CreatedBy = "Admin" }; context.Besinlers.Add(pilavUstuFasulye);

            Besinler hamsiliPilav = new Besinler() { BesinAdi = "Hamsili Pilav", GramKarsiligi = 100, Kalori = 334, Karbonhidrat = 30.3m, Protein = 26.52m, Yag = 12.29m, CreatedBy = "Admin" }; context.Besinlers.Add(hamsiliPilav);

            Besinler sehriyeliPilav = new Besinler() { BesinAdi = "Şehriyeli Pilav", GramKarsiligi = 100, Kalori = 462, Karbonhidrat = 82.85m, Protein = 8.53m, Yag = 10.01m, CreatedBy = "Admin" }; context.Besinlers.Add(sehriyeliPilav);

            Besinler nohutluPilav = new Besinler() { BesinAdi = "Nohutlu Pilav ", GramKarsiligi = 100, Kalori = 169, Karbonhidrat = 31.29m, Protein = 4.15m, Yag = 2.94m, CreatedBy = "Admin" }; context.Besinlers.Add(nohutluPilav);

            Besinler icPilav = new Besinler() { BesinAdi = "İç Pilav", GramKarsiligi = 100, Kalori = 139, Karbonhidrat = 25.99m, Protein = 2.59m, Yag = 2.53m, CreatedBy = "Admin" }; context.Besinlers.Add(icPilav);

            Besinler sadePilav = new Besinler() { BesinAdi = "Sade Pilav", GramKarsiligi = 100, Kalori = 118, Karbonhidrat = 22.62m, Protein = 1.99m, Yag = 1.99m, CreatedBy = "Admin" }; context.Besinlers.Add(sadePilav);

            Besinler domatesliBulgurPilavi = new Besinler() { BesinAdi = "Domatesli Bulgur Pilavı", GramKarsiligi = 100, Kalori = 169, Karbonhidrat = 31.13m, Protein = 4.56m, Yag = 2.61m, CreatedBy = "Admin" }; context.Besinlers.Add(domatesliBulgurPilavi);

            Besinler acemPilavi = new Besinler() { BesinAdi = "Acem Pilavı", GramKarsiligi = 100, Kalori = 480, Karbonhidrat = 43.69m, Protein = 22.32m, Yag = 23.76m, CreatedBy = "Admin" }; context.Besinlers.Add(acemPilavi);

            Besinler ozbekPilavi = new Besinler() { BesinAdi = "Özbek Pilavı", GramKarsiligi = 100, Kalori = 570, Karbonhidrat = 58.2m, Protein = 22.35m, Yag = 27.56m, CreatedBy = "Admin" }; context.Besinlers.Add(ozbekPilavi);

            Besinler basmatiPilavi = new Besinler() { BesinAdi = "Basmati Pilavı", GramKarsiligi = 100, Kalori = 118, Karbonhidrat = 14.05m, Protein = 1.65m, Yag = 3.1m, CreatedBy = "Admin" }; context.Besinlers.Add(basmatiPilavi);

            Besinler kuskusPilavi = new Besinler() { BesinAdi = "Kuskus Pilavı", GramKarsiligi = 100, Kalori = 380, Karbonhidrat = 72.76m, Protein = 11.79m, Yag = 3.75m, CreatedBy = "Admin" }; context.Besinlers.Add(kuskusPilavi);

            Besinler tereyaglıPrincPilavi = new Besinler() { BesinAdi = "Tereyağlı Pirinç Pilavı", GramKarsiligi = 100, Kalori = 283, Karbonhidrat = 46.47m, Protein = 4.14m, Yag = 8.65m, CreatedBy = "Admin" }; context.Besinlers.Add(tereyaglıPrincPilavi);


            Besinler bezelyeCorbasi = new Besinler() { BesinAdi = "Bezelye Çorbası", Kalori = 31, Karbonhidrat = 3.06m, Protein = 1.05m, Yag = 1.6m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(bezelyeCorbasi);

            Besinler domatesCorbasi = new Besinler() { BesinAdi = "Domates Çorbası", Kalori = 47, Karbonhidrat = 6.53m, Protein = 1.36m, Yag = 1.66m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(domatesCorbasi);

            Besinler kasarliDomatesCorbasi = new Besinler() { BesinAdi = "Kaşarlı Domates Çorbası", Kalori = 31, Karbonhidrat = 2.07m, Protein = 1.68m, Yag = 1.73m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kasarliDomatesCorbasi);

            Besinler ezogelinCorbasi = new Besinler() { BesinAdi = "Ezogelin Çorbası", Kalori = 68, Karbonhidrat = 8.92m, Protein = 2.83m, Yag = 1.76m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(ezogelinCorbasi);

            Besinler iskembeCorbasi = new Besinler() { BesinAdi = "İşkembe Çorbası", Kalori = 139, Karbonhidrat = 4.93m, Protein = 15.14m, Yag = 6.35m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(iskembeCorbasi);

            Besinler kirmiziMercimekCorbasi = new Besinler() { BesinAdi = "Kırmızı Mercimek Çorbası", Kalori = 68, Karbonhidrat = 12.42m, Protein = 3.69m, Yag = 0.29m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kirmiziMercimekCorbasi);

            Besinler yesilMercimekCorbasi = new Besinler() { BesinAdi = "Yeşil Mercimek Çorbası", Kalori = 121, Karbonhidrat = 12.04m, Protein = 4.5m, Yag = 6.03m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(yesilMercimekCorbasi);

            Besinler sebzeCorbasi = new Besinler() { BesinAdi = "Sebze Çorbası", Kalori = 44, Karbonhidrat = 6.06m, Protein = 1, Yag = 1.68m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(sebzeCorbasi);

            Besinler tarhanaCorbasi = new Besinler() { BesinAdi = "Tarhana Çorbası", Kalori = 91, Karbonhidrat = 7.48m, Protein = 3.45m, Yag = 4.93m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(tarhanaCorbasi);

            Besinler yaylaCorbasi = new Besinler() { BesinAdi = "Yayla Çorbası", Kalori = 70, Karbonhidrat = 9.71m, Protein = 12.19m, Yag = 2.41m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(yaylaCorbasi);

            Besinler tavukCorbasi = new Besinler() { BesinAdi = "Tavuk Çorbası", Kalori = 83, Karbonhidrat = 5.17m, Protein = 5.96m, Yag = 2.95m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(tavukCorbasi);

            Besinler balkabagiCorbasi = new Besinler() { BesinAdi = "Balkabaği Çorbası", Kalori = 29, Karbonhidrat = 2.41m, Protein = 1.87m, Yag = 1.19m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(balkabagiCorbasi);

            Besinler mantarCorbasi = new Besinler() { BesinAdi = "Mantar Çorbası", Kalori = 99, Karbonhidrat = 7.36m, Protein = 3.06m, Yag = 6.37m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(mantarCorbasi);

            Besinler kremaliMantarCorbasi = new Besinler() { BesinAdi = "Kremalı Mantar Çorbası", Kalori = 120, Karbonhidrat = 5.21m, Protein = 1.92m, Yag = 11.27m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kremaliMantarCorbasi);

            Besinler brokoliCorbasi = new Besinler() { BesinAdi = "Brokoli Çorbası", Kalori = 39, Karbonhidrat = 5.06m, Protein = 1.37m, Yag = 1.47m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(brokoliCorbasi);

            Besinler pacaCorbasi = new Besinler() { BesinAdi = "Paça Çorbası", Kalori = 117, Karbonhidrat = 0.86m, Protein = 18.81m, Yag = 4.29m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(pacaCorbasi);

            Besinler balikCorbasi = new Besinler() { BesinAdi = "Balik Çorbası", Kalori = 49, Karbonhidrat = 4.43m, Protein = 4.51m, Yag = 1.27m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(balikCorbasi);

            Besinler tutmacCorbasi = new Besinler() { BesinAdi = "Tutmac Çorbası", Kalori = 72, Karbonhidrat = 7.2m, Protein = 3.01m, Yag = 3.07m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(tutmacCorbasi);

            Besinler kerevizCorbasi = new Besinler() { BesinAdi = "Kereviz Çorbası", Kalori = 67, Karbonhidrat = 6.51m, Protein = 0.87m, Yag = 4.16m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kerevizCorbasi);

            
// ekmek ve tahıllar

            Besinler beyazEkmek = new Besinler() { BesinAdi = "Beyaz Ekmek", Kalori = 71, Karbonhidrat = 13.17m, Protein = 3.2m, Yag = 0.65m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(beyazEkmek);

            Besinler tamBugdayekmeği = new Besinler() { BesinAdi = "Tam Buğday Ekmeği", Kalori = 63, Karbonhidrat = 10.68m, Protein = 3.11m, Yag = 0.88m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(tamBugdayekmeği);

            Besinler cavdarEkmegi = new Besinler() { BesinAdi = "Cavdar Ekmeği", Kalori = 63, Karbonhidrat = 13.15m, Protein = 1.81m, Yag = 0.27m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(cavdarEkmegi);

            Besinler kepekliEkmegi = new Besinler() { BesinAdi = "Kepekli Ekmek", Kalori = 54, Karbonhidrat = 11.14m, Protein = 1.51m, Yag = 0.38m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kepekliEkmegi);

            Besinler grisini = new Besinler() { BesinAdi = "Grissini", Kalori = 20, Karbonhidrat = 3.53m, Protein = 0.51m, Yag = 0.36m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(grisini);

            Besinler beyaztostEkmeği = new Besinler() { BesinAdi = "Beyaz Tost Ekmeği", Kalori = 76, Karbonhidrat = 14.31m, Protein = 2.21m, Yag = 1, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(beyaztostEkmeği);

            Besinler cokTahilliTostEkmegi = new Besinler() { BesinAdi = "Çok Tahıllı Tost Ekmeği", Kalori = 67, Karbonhidrat = 11.65m, Protein = 3.33m, Yag = 0.79m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(cokTahilliTostEkmegi);

            Besinler sandvicEkmegi = new Besinler() { BesinAdi = "Sandviç Ekmeği", Kalori = 178, Karbonhidrat = 37.21m, Protein = 5.07m, Yag = 1.61m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(sandvicEkmegi);

            Besinler kepekliSandvicEkmegi = new Besinler() { BesinAdi = "Kepekli Sandviç Ekmeği", Kalori = 171, Karbonhidrat = 31.08m, Protein = 6.72m, Yag = 1.5m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kepekliSandvicEkmegi);

            Besinler hamburgerEkmeği = new Besinler() { BesinAdi = "Hamburger Ekmeği", Kalori = 142, Karbonhidrat = 29.64m, Protein = 3.64m, Yag = 1.04m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(hamburgerEkmeği);

            Besinler yufka = new Besinler() { BesinAdi = "Yufka", Kalori = 387, Karbonhidrat = 80.18m, Protein = 10.94m, Yag = 1.41m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(yufka);

            Besinler irmik = new Besinler() { BesinAdi = "İrmik", Kalori = 36, Karbonhidrat = 7.28m, Protein = 1.27m, Yag = 0.11m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(irmik);

            Besinler misirNisastasi = new Besinler() { BesinAdi = "Mısır Nişastası", Kalori = 37, Karbonhidrat = 9.06m, Protein = 0.02m, Yag = 0.08m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(misirNisastasi);

            Besinler galetaUnu = new Besinler() { BesinAdi = "Galeta Unu", Kalori = 40, Karbonhidrat = 7.2m, Protein = 1.34m, Yag = 0.53m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(galetaUnu);

            Besinler un = new Besinler() { BesinAdi = "Beyaz Un", Kalori = 40, Karbonhidrat = 8.54m, Protein = 0.04m, Yag = 0.01m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(galetaUnu);

            //Hamur işleri

            Besinler peynirliBorek = new Besinler() { BesinAdi = "Peynirli Börek", Kalori = 194, Karbonhidrat = 25.11m, Protein = 7.58m, Yag = 6.85m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(peynirliBorek);

            Besinler patatesliBorek = new Besinler() { BesinAdi = "Patatesli Börek", Kalori = 204, Karbonhidrat = 26.87m, Protein = 4.27m, Yag = 8.67m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(patatesliBorek);

            Besinler ispanakliBorek = new Besinler() { BesinAdi = "Ispanaklı Börek", Kalori = 116, Karbonhidrat = 21.39m, Protein = 4.29m, Yag = 2.35m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(ispanakliBorek);

            Besinler suBoregi = new Besinler() { BesinAdi = "Su Böreği", Kalori = 172, Karbonhidrat = 18.77m, Protein = 5.39m, Yag = 8.24m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(suBoregi);

            Besinler cigBorek = new Besinler() { BesinAdi = "Çiğ Börek", Kalori = 264, Karbonhidrat = 32.76m, Protein = 3.18m, Yag = 13.28m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(cigBorek);

            Besinler patlicanliBorek = new Besinler() { BesinAdi = "Patlıcanlı Börek", Kalori = 107, Karbonhidrat = 18.43m, Protein = 4.05m, Yag = 1.08m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(patlicanliBorek);

            Besinler biskuviliPasta = new Besinler() { BesinAdi = "Bisküvili Pasta", Kalori = 361, Karbonhidrat = 57.1m, Protein = 11.22m, Yag = 7.97m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(biskuviliPasta);

            Besinler cikolataliPasta = new Besinler() { BesinAdi = "Çikolatalı Pasta", Kalori = 577, Karbonhidrat = 39.56m, Protein = 7.44m, Yag = 42.85m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(cikolataliPasta);

            Besinler meyveliPasta = new Besinler() { BesinAdi = "Meyveli Pasta", Kalori = 257, Karbonhidrat = 41.5m, Protein = 6.38m, Yag = 6.09m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(meyveliPasta);

            Besinler muzluRuloiPasta = new Besinler() { BesinAdi = "Muzlu Rulo Pasta", Kalori = 286, Karbonhidrat = 43.49m, Protein = 10.27m, Yag = 6.8m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(muzluRuloiPasta);

            Besinler sadeKek = new Besinler() { BesinAdi = "Sade Kek", Kalori = 241, Karbonhidrat = 32.95m, Protein = 4.45m, Yag = 9.15m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(sadeKek);

            Besinler kakaoluKek = new Besinler() { BesinAdi = "Kakaolu Kek", Kalori = 268, Karbonhidrat = 31.2m, Protein = 3.94m, Yag = 13.11m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kakaoluKek);

            Besinler havucluKek = new Besinler() { BesinAdi = "Havuclu Kek", Kalori = 249, Karbonhidrat = 26.91m, Protein = 3.84m, Yag = 13.36m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(havucluKek);

            Besinler portakalliKek = new Besinler() { BesinAdi = "Portakallı Kek", Kalori = 188, Karbonhidrat = 28.92m, Protein = 3.55m, Yag = 5.7m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(portakalliKek);

            Besinler elmaliKurabiye = new Besinler() { BesinAdi = "Elmalı Kurabiye", Kalori = 153, Karbonhidrat = 18.08m, Protein = 2.49m, Yag = 7.66m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(elmaliKurabiye);

            Besinler findikliKurabiye = new Besinler() { BesinAdi = "Fındıklı Kurabiye", Kalori = 238, Karbonhidrat = 22.22m, Protein = 3.86m, Yag = 14.84m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(findikliKurabiye);

            Besinler cevizliKurabiye = new Besinler() { BesinAdi = "Cevizli Kurabiye", Kalori = 203, Karbonhidrat = 21.61m, Protein = 3.69m, Yag = 11.38m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(cevizliKurabiye);

            Besinler cikolataliKurabiye = new Besinler() { BesinAdi = "Çikolatalı Kurabiye", Kalori = 210, Karbonhidrat = 21.95m, Protein = 2.97m, Yag = 12.20m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(cikolataliKurabiye);

            Besinler yulafliFitKurabiye = new Besinler() { BesinAdi = "Yulafli Fit Kurabiye", Kalori = 161, Karbonhidrat = 17.65m, Protein = 5.48m, Yag = 8.68m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(yulafliFitKurabiye);

            Besinler kuruUzumluDiyetKurabiye = new Besinler() { BesinAdi = "Kuru Uzumlu Diyet Kurabiye", Kalori = 102, Karbonhidrat = 19.39m, Protein = 3.46m, Yag = 1.54m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kuruUzumluDiyetKurabiye);

            Besinler tuzluPastaneKurabiyesi = new Besinler() { BesinAdi = "Tuzlu Pastane Kurabiyesi", Kalori = 184, Karbonhidrat = 19.31m, Protein = 3.82m, Yag = 10.22m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(tuzluPastaneKurabiyesi);

            Besinler unKurabiyesi = new Besinler() { BesinAdi = "Tuzlu Pastane Kurabiyesi", Kalori = 128, Karbonhidrat = 21.06m, Protein = 0.18m, Yag = 4.67m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(unKurabiyesi);

            Besinler kandilSimidi = new Besinler() { BesinAdi = "Kandil Simidi", Kalori = 167, Karbonhidrat = 14.97m, Protein = 2.93m, Yag = 60.67m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kandilSimidi);

            Besinler simit = new Besinler() { BesinAdi = "Simit", Kalori = 275, Karbonhidrat = 57.14m, Protein = 10.71m, Yag = 3.57m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(simit);

            Besinler pogaca = new Besinler() { BesinAdi = "Poğaça", Kalori = 243, Karbonhidrat = 22.33m, Protein = 4.91m, Yag = 14.74m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(pogaca);

            Besinler peynirliPogaca = new Besinler() { BesinAdi = "Peynirli Poğaça", Kalori = 274, Karbonhidrat = 21.4m, Protein = 6.1m, Yag = 18.29m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(peynirliPogaca);

            Besinler DereotluPogaca = new Besinler() { BesinAdi = "Dereotlu Poğaça", Kalori = 234, Karbonhidrat = 25.2m, Protein = 5.09m, Yag = 20.44m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(DereotluPogaca);

            Besinler ZeytinliPogaca = new Besinler() { BesinAdi = "Zeytinli Poğaça", Kalori = 267, Karbonhidrat = 23.97m, Protein = 5.06m, Yag = 17.27m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(ZeytinliPogaca);

            Besinler patatesliPogaca = new Besinler() { BesinAdi = "Patatesli Poğaça", Kalori = 230, Karbonhidrat = 20.01m, Protein = 3.48m, Yag = 14.96m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(patatesliPogaca);

            Besinler acma = new Besinler() { BesinAdi = "Acma", Kalori = 341, Karbonhidrat = 35.22m, Protein = 5.91m, Yag = 23.89m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(acma);

            Besinler cikolataliAcma = new Besinler() { BesinAdi = "Cikolatalı Acma", Kalori = 268, Karbonhidrat = 36.71m, Protein = 5.32m, Yag = 10.83m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(cikolataliAcma);

            Besinler zeytinliAcma = new Besinler() { BesinAdi = "Zeytinli Acma", Kalori = 354, Karbonhidrat = 31.25m, Protein = 5.27m, Yag = 22.95m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinliAcma);


            //kurubaklagiller

            Besinler kurufasulyeEtsiz = new Besinler() { BesinAdi = "Etsiz Kuru Fasulye", Kalori = 250, Karbonhidrat = 45.16m, Protein = 17.51m, Yag = 0.63m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kurufasulyeEtsiz);

            Besinler nohutYemegiEtsiz = new Besinler() { BesinAdi = "Etsiz Kuru Fasulye", Kalori = 322, Karbonhidrat = 41.16m, Protein = 11.80m, Yag = 0.63m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(nohutYemegiEtsiz);

            Besinler bezelyeYemegi = new Besinler() { BesinAdi = "Bezelye Yemegi    ", Kalori = 132, Karbonhidrat = 22.42m, Protein = 6.15m, Yag = 2.39m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(bezelyeYemegi);

            Besinler mercimekYemegi = new Besinler() { BesinAdi = "Mercimnek Yemegi ", Kalori = 164, Karbonhidrat = 17.04m, Protein = 8.97m, Yag = 4.52m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(mercimekYemegi);

            Besinler zeytinyaglıBarbunya = new Besinler() { BesinAdi = "Zeytinyaglı Barbunya ", Kalori = 140, Karbonhidrat = 42.83m, Protein = 15.99m, Yag = 14.14m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinyaglıBarbunya);

            Besinler haslanmisMisir = new Besinler() { BesinAdi = "zeytinyaglıBarbunya ", Kalori = 140, Karbonhidrat = 42.83m, Protein = 15.99m, Yag = 14.14m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(haslanmisMisir);

            Besinler meksikaFasulyesi = new Besinler() { BesinAdi = "Meksika Fasulyesi ", Kalori = 607, Karbonhidrat = 110.32m, Protein = 40.55m, Yag = 1.91m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(meksikaFasulyesi);

            Besinler soyaFasulyesi = new Besinler() { BesinAdi = "Soya Fasulyesi ", Kalori = 274, Karbonhidrat = 0.31m, Protein = 28.31m, Yag = 17.79m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(soyaFasulyesi);


            //hayvansal yaglar

            Besinler balikYagi = new Besinler() { BesinAdi = "Balik Yagi ", Kalori = 44, Karbonhidrat = 0, Protein = 0, Yag = 4.99m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(balikYagi);

            Besinler icYagi = new Besinler() { BesinAdi = "İç Yagi ", Kalori = 135, Karbonhidrat = 0, Protein = 0, Yag = 15m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(icYagi);

            Besinler kuyrukYagi = new Besinler() { BesinAdi = "Kuyruk Yagi ", Kalori = 79, Karbonhidrat = 0.01m, Protein = 0.29m, Yag = 8.61m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(kuyrukYagi);

            //bitkisel yağlar 

            Besinler aycicekYagi = new Besinler() { BesinAdi = "Aycicek Yagi ", Kalori = 44, Karbonhidrat = 0, Protein = 0, Yag = 5, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(aycicekYagi);

            Besinler fındıkYagı = new Besinler() { BesinAdi = "Fındık Yagi ", Kalori = 35, Karbonhidrat = 0, Protein = 0, Yag = 4, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(fındıkYagı);

            Besinler zeytinYagı = new Besinler() { BesinAdi = "Zeytin Yagi ", Kalori = 40, Karbonhidrat = 0.01m, Protein = 0, Yag = 4.5m, GramKarsiligi = 100, CreatedBy = "Admin" }; context.Besinlers.Add(zeytinYagı);



        }
    }
}
