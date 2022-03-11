using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWebSite.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Başlık")]
        public string Baslik { get; set; }
        [Display(Name = "Tarih")]
        public DateTime Tarih { get; set; }
        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }
        [Display(Name = "Resim")]
        public string BlogImage { get; set; }

        public ICollection<Yorumlar> Yorumlars { get; set; }
        // bire çok ilişki. bir blogun birden fazla yorumu olabilir.
    }
}