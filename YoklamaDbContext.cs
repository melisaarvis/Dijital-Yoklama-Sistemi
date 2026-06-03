using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DİJİTAL_YOKLAMA_SİSTEMİ.Models;

namespace DİJİTAL_YOKLAMA_SİSTEMİ
{
    public class YoklamaDbContext:DbContext
    {
        public YoklamaDbContext():base (@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog=YoklamaDB;Integrated Security=True")
        {
            Database.SetInitializer<YoklamaDbContext>(null);
        }
        
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders> Dersler { get; set; }

        public DbSet<YoklamaOturum> YoklamaOturumlari { get; set; }

        public DbSet<YoklamaKayit> YoklamaKayitleri { get; set; }


    }
}
