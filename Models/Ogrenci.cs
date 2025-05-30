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

        [Display(Name = "Forma Durumu")]
        [Range(0, 100, ErrorMessage = "Forma durumu 0 veya 100 olmalıdır.")]
        public int FormaGiydi { get; set; }

        [Display(Name = "Ödev Durumu")]
        [Range(0, 100, ErrorMessage = "Ödev durumu 0 veya 100 olmalıdır.")]
        public int OdevYapti { get; set; }

        [Display(Name = "Sınav Notu")]
        [Range(0, 100, ErrorMessage = "Sınav notu 0-100 arasında olmalıdır.")]
        public int? SinavNotu { get; set; }

        [Display(Name = "Günlük Not")]
        public string? GunlukNot { get; set; }
    }
}