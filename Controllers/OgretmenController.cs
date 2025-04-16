using Microsoft.AspNetCore.Mvc;
using PerformansTakip.Data;
using PerformansTakip.Models;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

namespace PerformansTakip.Controllers
{
    public class OgretmenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OgretmenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Giriş Sayfası
        [HttpGet]
        public IActionResult Giris()
        {
            return View();
        }

        // Giriş İşlemi
        [HttpPost]
        public IActionResult Giris(string tc, string sifre)
        {
            var ogretmen = _context.Ogretmenler
                .FirstOrDefault(o => o.TC == tc);

            if (ogretmen != null)
            {
                try
                {
                    if (BCrypt.Net.BCrypt.Verify(sifre, ogretmen.Sifre))
                    {
                        // Giriş başarılı, session oluştur
                        HttpContext.Session.SetInt32("OgretmenId", ogretmen.Id);
                        HttpContext.Session.SetString("OgretmenAdSoyad", ogretmen.AdSoyad); // Öğretmen adını session'a ekle
                        return RedirectToAction("Index", "Ogretmen");
                    }
                }
                catch (BCrypt.Net.SaltParseException)
                {
                    // Şifre hash'i geçersiz, kullanıcıyı kayıt sayfasına yönlendir
                    return RedirectToAction("Kayit");
                }
            }

            // Hatalı giriş
            ViewBag.Hata = "Kullanıcı adı veya şifre hatalı.";
            return View();
        }

        // Kayıt Sayfası
        [HttpGet]
        public IActionResult Kayit()
        {
            return View();
        }

        // Kayıt İşlemi
        [HttpPost]
        public IActionResult Kayit(Ogretmen ogretmen)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Şifreyi hashle
                    string salt = BCrypt.Net.BCrypt.GenerateSalt();
                    ogretmen.Sifre = BCrypt.Net.BCrypt.HashPassword(ogretmen.Sifre, salt);

                    _context.Ogretmenler.Add(ogretmen);
                    _context.SaveChanges();

                    // Kayıt başarılı, giriş sayfasına yönlendir
                    return RedirectToAction("Giris");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Kayıt sırasında bir hata oluştu: " + ex.Message);
                }
            }

            // ModelState'deki tüm hata mesajlarını al
            var errorMessages = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage)
                .ToList();

            ViewBag.HataMesajlari = errorMessages;
            return View(ogretmen);
        }

        // Sınıf Seçimi
        public IActionResult SinifSec()
        {
            int? ogretmenId = HttpContext.Session.GetInt32("OgretmenId");
            if (ogretmenId == null)
            {
                return RedirectToAction("Giris");
            }

            var siniflar = _context.Siniflar
                .Where(s => s.OgretmenId == ogretmenId)
                .ToList();

            return View(siniflar);
        }

        // Sınıf Ekleme Sayfası
        [HttpGet]
        public IActionResult SinifEkle()
        {
            int? ogretmenId = HttpContext.Session.GetInt32("OgretmenId");
            if (ogretmenId == null)
            {
                return RedirectToAction("Giris");
            }
            return View();
        }

        // Sınıf Ekleme İşlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SinifEkle([FromForm] string ad)
        {
            // Öğretmen ID'sini session'dan al   
            int? ogretmenId = HttpContext.Session.GetInt32("OgretmenId");
            if (ogretmenId == null)
            {
                return RedirectToAction("Giris");
            }

            if (string.IsNullOrEmpty(ad))
            {
                ModelState.AddModelError("Ad", "Sınıf adı zorunludur.");
                return View(new Sinif { Ad = ad });
            }

            try
            {
                var sinif = new Sinif
                {
                    Ad = ad,
                    OgretmenId = ogretmenId.Value,
                    Ogrenciler = new List<Ogrenci>()
                };

                // Veritabanına ekle
                _context.Siniflar.Add(sinif);
                _context.SaveChanges();
                
                // Başarılı mesajı
                TempData["Mesaj"] = $"{ad} sınıfı başarıyla eklendi.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Sınıf eklenirken bir hata oluştu: " + ex.Message);
                return View(new Sinif { Ad = ad });
            }
        }

        // Öğrenci Ekleme Sayfası
        [HttpGet]
        public IActionResult OgrenciEkle(int? sinifId = null)
        {
            int? ogretmenId = HttpContext.Session.GetInt32("OgretmenId");
            if (ogretmenId == null)
            {
                return RedirectToAction("Giris");
            }

            ViewBag.Siniflar = _context.Siniflar
                .Where(s => s.OgretmenId == ogretmenId)
                .ToList();

            if (sinifId.HasValue)
            {
                var sinif = _context.Siniflar
                    .FirstOrDefault(s => s.Id == sinifId && s.OgretmenId == ogretmenId);
                if (sinif != null)
                {
                    ViewBag.SecilenSinif = sinif;
                }
            }

            return View();
        }

        // Öğrenci Ekleme İşlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OgrenciEkle([FromForm] string ad, [FromForm] string soyad, [FromForm] int sinifId)
        {
            int? ogretmenId = HttpContext.Session.GetInt32("OgretmenId");
            if (ogretmenId == null)
            {
                return RedirectToAction("Giris");
            }

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad))
            {
                ModelState.AddModelError("", "Ad ve soyad alanları zorunludur.");
                ViewBag.Siniflar = _context.Siniflar.Where(s => s.OgretmenId == ogretmenId).ToList();
                return View();
            }

            try
            {
                // Önce sınıfın var olduğunu ve öğretmene ait olduğunu kontrol et
                var sinif = _context.Siniflar
                    .FirstOrDefault(s => s.Id == sinifId && s.OgretmenId == ogretmenId);

                if (sinif == null)
                {
                    ModelState.AddModelError("", "Geçersiz sınıf seçimi.");
                    ViewBag.Siniflar = _context.Siniflar.Where(s => s.OgretmenId == ogretmenId).ToList();
                    return View();
                }

                // Öğrenciyi oluştur
                var ogrenci = new Ogrenci
                {
                    Ad = ad,
                    Soyad = soyad,
                    SinifId = sinifId,
                    FormaGiydi = false,
                    OdevYapti = false
                };

                // Öğrenciyi veritabanına ekle
                _context.Ogrenciler.Add(ogrenci);
                _context.SaveChanges();

                TempData["Mesaj"] = $"{ad} {soyad} öğrencisi başarıyla eklendi.";
                return RedirectToAction("SinifDetay", new { id = sinifId });
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException != null ? ex.InnerException.Message : "No inner exception";
                ModelState.AddModelError("", $"Öğrenci eklenirken bir hata oluştu. Detay: {innerException}");
                ViewBag.Siniflar = _context.Siniflar.Where(s => s.OgretmenId == ogretmenId).ToList();
                return View();
            }
        }

        // Öğrenci Silme İşlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OgrenciSil(int id)
        {
            int? ogretmenId = HttpContext.Session.GetInt32("OgretmenId");
            if (ogretmenId == null)
            {
                return RedirectToAction("Giris");
            }

            try
            {
                // Öğrenciyi bul
                var ogrenci = _context.Ogrenciler.FirstOrDefault(o => o.Id == id);
                
                if (ogrenci == null)
                {
                    TempData["Hata"] = "Öğrenci bulunamadı.";
                    return RedirectToAction("Index");
                }

                // Öğrencinin sınıfını bul
                var sinif = _context.Siniflar.FirstOrDefault(s => s.Id == ogrenci.SinifId && s.OgretmenId == ogretmenId);
                
                if (sinif == null)
                {
                    TempData["Hata"] = "Bu öğrenciyi silme yetkiniz yok.";
                    return RedirectToAction("Index");
                }

                // Öğrenciyi sınıftan kaldır
                if (sinif.Ogrenciler != null)
                {
                    sinif.Ogrenciler.Remove(ogrenci);
                }

                // Öğrenciyi veritabanından sil
                _context.Ogrenciler.Remove(ogrenci);
                _context.SaveChanges();

                TempData["Mesaj"] = $"{ogrenci.Ad} {ogrenci.Soyad} öğrencisi başarıyla silindi.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Hata"] = "Öğrenci silinirken bir hata oluştu: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        // Öğrenci Güncelleme İşlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OgrenciGuncelle(int id, bool? formaGiydi, bool? odevYapti, int? sinavNotu, string? gunlukNot)
        {
            int? ogretmenId = HttpContext.Session.GetInt32("OgretmenId");
            if (ogretmenId == null)
            {
                return Json(new { success = false, message = "Oturum süresi dolmuş." });
            }

            try
            {
                var ogrenci = _context.Ogrenciler
                    .Include(o => o.Sinif)
                    .FirstOrDefault(o => o.Id == id && o.Sinif.OgretmenId == ogretmenId);

                if (ogrenci == null)
                {
                    return Json(new { success = false, message = "Öğrenci bulunamadı veya güncelleme yetkiniz yok." });
                }

                // Sadece gönderilen alanları güncelle
                if (formaGiydi.HasValue)
                    ogrenci.FormaGiydi = formaGiydi.Value;
                
                if (odevYapti.HasValue)
                    ogrenci.OdevYapti = odevYapti.Value;
                
                if (sinavNotu.HasValue)
                    ogrenci.SinavNotu = sinavNotu;
                
                if (gunlukNot != null)
                    ogrenci.GunlukNot = gunlukNot;

                _context.SaveChanges();

                return Json(new { success = true, message = $"{ogrenci.Ad} {ogrenci.Soyad} öğrencisinin bilgileri güncellendi." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Güncelleme sırasında bir hata oluştu: " + ex.Message });
            }
        }

        // Ana Sayfa - Sınıf Listesi
        public IActionResult Index()
        {
            int? ogretmenId = HttpContext.Session.GetInt32("OgretmenId");
            if (ogretmenId == null)
            {
                return RedirectToAction("Giris");
            }

            var siniflar = _context.Siniflar
                .Include(s => s.Ogrenciler)
                .Where(s => s.OgretmenId == ogretmenId)
                .ToList();

            ViewBag.OgretmenAdSoyad = HttpContext.Session.GetString("OgretmenAdSoyad");
            return View(siniflar);
        }

        // Sınıf Detay Sayfası
        public IActionResult SinifDetay(int id)
        {
            int? ogretmenId = HttpContext.Session.GetInt32("OgretmenId");
            if (ogretmenId == null)
            {
                return RedirectToAction("Giris");
            }

            var sinif = _context.Siniflar
                .Include(s => s.Ogrenciler)
                .FirstOrDefault(s => s.Id == id && s.OgretmenId == ogretmenId);

            if (sinif == null)
            {
                return NotFound();
            }

            return View(sinif);
        }
    }
}