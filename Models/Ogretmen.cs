
namespace PerformansTakip.Models

{
   public class Ogretmen
{
    public int Id { get; set; }
    public string TC { get; set; }
    public string? KullaniciAdi { get; set; }
    public string Sifre { get; set; }
    public string AdSoyad { get; set; }

    // Öğretmenin birden fazla sınıfı olabilir
    public ICollection<Sinif>? Siniflar{ get; set; }
}


}
