using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DİJİTAL_YOKLAMA_SİSTEMİ.Models
{ 
    [Table("Ogrenciler")]
    public class Ogrenci
    {
        public int Id { get; set; }

        public string AdSoyad { get; set; }

        public int Numara { get; set; }

        public virtual ICollection<YoklamaKayit> YoklamaKayitlari { get; set; }
    }
}
