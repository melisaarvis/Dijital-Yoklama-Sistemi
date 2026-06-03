using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DİJİTAL_YOKLAMA_SİSTEMİ.Models
{
    [Table("Dersler")]
    public class Ders
    {
        public int Id { get; set; }

        public string DersAdi { get; set; }    

        public string DersKodu { get; set; }

        public virtual ICollection<YoklamaOturum> YoklamaOturumlari { get; set; }
        

    }
}
