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
                        return RedirectToAction("Index", "Sinif");
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
        public IActionResult SinifEkle(Sinif sinif)
        {
            int? ogretmenId = HttpContext.Session.GetInt32("OgretmenId");
            if (ogretmenId == null)
            {
                return RedirectToAction("Giris");
            }

            if (ModelState.IsValid)
            {
                sinif.OgretmenId = ogretmenId.Value;
                _context.Siniflar.Add(sinif);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sinif);
        }

        // Öğrenci Ekleme Sayfası
        [HttpGet]
        public IActionResult OgrenciEkle()
        {
            int? ogretmenId = HttpContext.Session.GetInt32("OgretmenId");
            if (ogretmenId == null)
            {
                return RedirectToAction("Giris");
            }

            ViewBag.Siniflar = _context.Siniflar
                .Where(s => s.OgretmenId == ogretmenId)
                .ToList();
            return View();
        }

        // Öğrenci Ekleme İşlemi
        [HttpPost]
        public IActionResult OgrenciEkle(Ogrenci ogrenci)
        {
            int? ogretmenId = HttpContext.Session.GetInt32("OgretmenId");
            if (ogretmenId == null)
            {
                return RedirectToAction("Giris");
            }

            if (ModelState.IsValid)
            {
                _context.Ogrenciler.Add(ogrenci);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Siniflar = _context.Siniflar
                .Where(s => s.OgretmenId == ogretmenId)
                .ToList();
            return View(ogrenci);
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