using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DİJİTAL_YOKLAMA_SİSTEMİ.Models
{
   [Table("YoklamaOturumlari")]
    public class YoklamaOturum
    {
        [Key]
        public int OturumId { get; set; }

        public int DersId { get; set; }

        public DateTime BaslangicZamani { get; set; }

        public string YoklamaKodu { get; set; }

        public bool AktifMi { get; set; }

        public double Enlem { get; set; }

        public double Boylam { get; set; }

        public int KonumYaricapi { get; set; }

        public virtual Ders Ders { get; set; }

        public virtual ICollection<YoklamaKayit> YoklamaKayitlari { get; set; }
    }
}
