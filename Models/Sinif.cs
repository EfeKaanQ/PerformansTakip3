using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PerformansTakip.Models
{
    public class Sinif
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Sınıf adı zorunludur.")]
        [Display(Name = "Sınıf Adı")]
        public string Ad { get; set; }
        
        public int OgretmenId { get; set; }
        public Ogretmen Ogretmen { get; set; }
        
        public virtual ICollection<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();
    }
}