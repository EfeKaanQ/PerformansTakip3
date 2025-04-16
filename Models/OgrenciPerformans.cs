using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PerformansTakip.Models
{
    public class OgrenciPerformans
    {
        public int Id { get; set; }

        [Required]
        public int OgrenciId { get; set; }

        [ForeignKey("OgrenciId")]
        public Ogrenci Ogrenci { get; set; }

        [Required]
        public DateTime Tarih { get; set; }

        [Display(Name = "Forma Durumu")]
        [Range(0, 100, ErrorMessage = "Forma durumu 0-100 arasında olmalıdır.")]
        public int FormaGiydi { get; set; }

        [Display(Name = "Ödev Durumu")]
        [Range(0, 100, ErrorMessage = "Ödev durumu 0-100 arasında olmalıdır.")]
        public int OdevYapti { get; set; }

        [Display(Name = "Sınav Notu")]
        [Range(0, 100, ErrorMessage = "Sınav notu 0-100 arasında olmalıdır.")]
        public int? SinavNotu { get; set; }

        [Display(Name = "Günlük Not")]
        public string? GunlukNot { get; set; }
    }
} 