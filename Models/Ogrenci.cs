using System.ComponentModel.DataAnnotations;

namespace PerformansTakip.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Öğrenci adı zorunludur.")]
        [Display(Name = "Ad")]
        public string Ad { get; set; }
        
        [Required(ErrorMessage = "Öğrenci soyadı zorunludur.")]
        [Display(Name = "Soyad")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Sınıf seçimi zorunludur.")]
        [Display(Name = "Sınıf")]
        public int SinifId { get; set; }
        
        public Sinif Sinif { get; set; }
    }
}