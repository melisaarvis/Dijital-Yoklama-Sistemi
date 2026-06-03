using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace DİJİTAL_YOKLAMA_SİSTEMİ.Models
{
    [Table("YoklamaKayitleri")]
    public class YoklamaKayit
    {
        [Key]
        public int KayitId { get; set; }

        public int OgrenciId { get; set; }

        public int OturumId { get; set; }

        public string Durum { get; set; }

        public double OgrenciEnlem { get; set; }

        public double OgrenciBoylam { get; set; }

        public virtual Ogrenci Ogrenci { get; set; }

        public virtual YoklamaOturum YoklamaOturum { get; set; }

    }

}