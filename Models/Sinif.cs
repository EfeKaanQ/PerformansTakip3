
using System.Collections.Generic;

namespace PerformansTakip.Models
{
    public class Sinif
    {
        public int Id { get; set; }
        public string Ad { get; set; }
         public int OgretmenId { get; set; } 
          public Ogretmen Ogretmen { get; set; }
        
        public List<Ogrenci> Ogrenciler { get; set; }= new List<Ogrenci>();
    }
}
