
using Microsoft.AspNetCore.Mvc;
using PerformansTakip.Models;
using System.Collections.Generic;
using System.Linq;

namespace PerformansTakip.Controllers
{
    public class SinifController : Controller
    {
      
                   private static List<Sinif> Siniflar = new List<Sinif>
{
 
   new Sinif
{
    Id = 1,
    Ad = "9-A",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 1, Ad = "Ahmet", Soyad = "Öztürk" },
        new Ogrenci { Id = 2, Ad = "Zeynep", Soyad = "Can" },
        new Ogrenci { Id = 3, Ad = "Kemal", Soyad = "Güven" },
        new Ogrenci { Id = 4, Ad = "Emine", Soyad = "Sarı" },
        new Ogrenci { Id = 5, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 6, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 7, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 8, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 9, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 10, Ad = "Melis", Soyad = "Gök" },
        new Ogrenci { Id = 11, Ad = "Ali", Soyad = "Yılmaz" },
        new Ogrenci { Id = 12, Ad = "Ayşe", Soyad = "Kara" },
        new Ogrenci { Id = 13, Ad = "Mehmet", Soyad = "Demir" },
        new Ogrenci { Id = 14, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 15, Ad = "Serkan", Soyad = "Kara" }
    }
},
new Sinif
{
    Id = 2,
    Ad = "9-B",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 16, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 17, Ad = "Ali", Soyad = "Demir" },
        new Ogrenci { Id = 18, Ad = "Serkan", Soyad = "Güzel" },
        new Ogrenci { Id = 19, Ad = "Murat", Soyad = "Yıldız" },
        new Ogrenci { Id = 20, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 21, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 22, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 23, Ad = "Zeynep", Soyad = "Demir" },
        new Ogrenci { Id = 24, Ad = "Büşra", Soyad = "Sarı" },
        new Ogrenci { Id = 25, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 26, Ad = "Ahmet", Soyad = "Öztürk" },
        new Ogrenci { Id = 27, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 28, Ad = "Ayşe", Soyad = "Sarı" },
        new Ogrenci { Id = 29, Ad = "Kemal", Soyad = "Güven" },
        new Ogrenci { Id = 30, Ad = "Melis", Soyad = "Gök" }
    }
},
new Sinif
{
    Id = 3,
    Ad = "9-C",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 31, Ad = "Mehmet", Soyad = "Demir" },
        new Ogrenci { Id = 32, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 33, Ad = "Zeynep", Soyad = "Kara" },
        new Ogrenci { Id = 34, Ad = "Ali", Soyad = "Yılmaz" },
        new Ogrenci { Id = 35, Ad = "Serkan", Soyad = "Güzel" },
        new Ogrenci { Id = 36, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 37, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 38, Ad = "Ayşe", Soyad = "Kara" },
        new Ogrenci { Id = 39, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 40, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 41, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 42, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 43, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 44, Ad = "Ahmet", Soyad = "Öztürk" },
        new Ogrenci { Id = 45, Ad = "Murat", Soyad = "Güzel" }
    }
},
new Sinif
{
    Id = 4,
    Ad = "9-D",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 46, Ad = "Ali", Soyad = "Demir" },
        new Ogrenci { Id = 47, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 48, Ad = "Kemal", Soyad = "Güven" },
        new Ogrenci { Id = 49, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 50, Ad = "Zeynep", Soyad = "Demir" },
        new Ogrenci { Id = 51, Ad = "Serkan", Soyad = "Kara" },
        new Ogrenci { Id = 52, Ad = "Melis", Soyad = "Gök" },
        new Ogrenci { Id = 53, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 54, Ad = "Murat", Soyad = "Yıldız" },
        new Ogrenci { Id = 55, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 56, Ad = "Ali", Soyad = "Öztürk" },
        new Ogrenci { Id = 57, Ad = "Ahmet", Soyad = "Öztürk" },
        new Ogrenci { Id = 58, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 59, Ad = "Ayşe", Soyad = "Sarı" },
        new Ogrenci { Id = 60, Ad = "Furkan", Soyad = "Aydın" }
    }
},
new Sinif
{
    Id = 5,
    Ad = "9-E",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 61, Ad = "Serkan", Soyad = "Kara" },
        new Ogrenci { Id = 62, Ad = "Zeynep", Soyad = "Demir" },
        new Ogrenci { Id = 63, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 64, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 65, Ad = "Murat", Soyad = "Güzel" },
        new Ogrenci { Id = 66, Ad = "Ali", Soyad = "Demir" },
        new Ogrenci { Id = 67, Ad = "Ahmet", Soyad = "Öztürk" },
        new Ogrenci { Id = 68, Ad = "Kemal", Soyad = "Güven" },
        new Ogrenci { Id = 69, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 70, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 71, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 72, Ad = "Serkan", Soyad = "Güzel" },
        new Ogrenci { Id = 73, Ad = "Zeynep", Soyad = "Sarı" },
        new Ogrenci { Id = 74, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 75, Ad = "Duru", Soyad = "Koç" }
    }
},
new Sinif
{
    Id = 6,
    Ad = "10-A",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 76, Ad = "Ali", Soyad = "Yılmaz" },
        new Ogrenci { Id = 77, Ad = "Ayşe", Soyad = "Kara" },
        new Ogrenci { Id = 78, Ad = "Mehmet", Soyad = "Demir" },
        new Ogrenci { Id = 79, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 80, Ad = "Serkan", Soyad = "Kara" },
        new Ogrenci { Id = 81, Ad = "Zeynep", Soyad = "Demir" },
        new Ogrenci { Id = 82, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 83, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 84, Ad = "Murat", Soyad = "Güzel" },
        new Ogrenci { Id = 85, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 86, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 87, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 88, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 89, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 90, Ad = "Melis", Soyad = "Sarı" }
    }
},
new Sinif
{
    Id = 7,
    Ad = "10-B",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 91, Ad = "Mehmet", Soyad = "Demir" },
        new Ogrenci { Id = 92, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 93, Ad = "Zeynep", Soyad = "Kara" },
        new Ogrenci { Id = 94, Ad = "Ali", Soyad = "Yılmaz" },
        new Ogrenci { Id = 95, Ad = "Serkan", Soyad = "Güzel" },
        new Ogrenci { Id = 96, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 97, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 98, Ad = "Ayşe", Soyad = "Kara" },
        new Ogrenci { Id = 99, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 100, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 101, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 102, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 103, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 104, Ad = "Murat", Soyad = "Güzel" },
        new Ogrenci { Id = 105, Ad = "Fatma", Soyad = "Çelik" }
    }
},
new Sinif
{
    Id = 8,
    Ad = "10-C",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 106, Ad = "Serkan", Soyad = "Kara" },
        new Ogrenci { Id = 107, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 108, Ad = "Zeynep", Soyad = "Sarı" },
        new Ogrenci { Id = 109, Ad = "Melis", Soyad = "Gök" },
        new Ogrenci { Id = 110, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 111, Ad = "Murat", Soyad = "Güzel" },
        new Ogrenci { Id = 112, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 113, Ad = "Serkan", Soyad = "Kara" },
        new Ogrenci { Id = 114, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 115, Ad = "Ali", Soyad = "Öztürk" },
        new Ogrenci { Id = 116, Ad = "Ayşe", Soyad = "Kara" },
        new Ogrenci { Id = 117, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 118, Ad = "Zeynep", Soyad = "Kara" },
        new Ogrenci { Id = 119, Ad = "Murat", Soyad = "Yıldız" },
        new Ogrenci { Id = 120, Ad = "Baran", Soyad = "Kılıç" }
    }
},


    
   new Sinif
{
    Id = 9,
    Ad = "10-D",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 121, Ad = "Ali", Soyad = "Yılmaz" },
        new Ogrenci { Id = 122, Ad = "Ayşe", Soyad = "Sarı" },
        new Ogrenci { Id = 123, Ad = "Mehmet", Soyad = "Demir" },
        new Ogrenci { Id = 124, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 125, Ad = "Zeynep", Soyad = "Aydın" },
        new Ogrenci { Id = 126, Ad = "Serkan", Soyad = "Kara" },
        new Ogrenci { Id = 127, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 128, Ad = "Murat", Soyad = "Güzel" },
        new Ogrenci { Id = 129, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 130, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 131, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 132, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 133, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 134, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 135, Ad = "Melis", Soyad = "Sarı" }
    }
},
new Sinif
{
    Id = 10,
    Ad = "10-E",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 136, Ad = "Serkan", Soyad = "Güzel" },
        new Ogrenci { Id = 137, Ad = "Zeynep", Soyad = "Demir" },
        new Ogrenci { Id = 138, Ad = "Ali", Soyad = "Öztürk" },
        new Ogrenci { Id = 139, Ad = "Murat", Soyad = "Yıldız" },
        new Ogrenci { Id = 140, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 141, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 142, Ad = "Büşra", Soyad = "Sarı" },
        new Ogrenci { Id = 143, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 144, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 145, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 146, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 147, Ad = "Ayşe", Soyad = "Kara" },
        new Ogrenci { Id = 148, Ad = "Mehmet", Soyad = "Demir" },
        new Ogrenci { Id = 149, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 150, Ad = "Kemal", Soyad = "Güven" }
    }
},
new Sinif
{
    Id = 11,
    Ad = "11-A",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 151, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 152, Ad = "Serkan", Soyad = "Kara" },
        new Ogrenci { Id = 153, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 154, Ad = "Murat", Soyad = "Yıldız" },
        new Ogrenci { Id = 155, Ad = "Ayşe", Soyad = "Sarı" },
        new Ogrenci { Id = 156, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 157, Ad = "Kemal", Soyad = "Güven" },
        new Ogrenci { Id = 158, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 159, Ad = "Ali", Soyad = "Öztürk" },
        new Ogrenci { Id = 160, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 161, Ad = "Zeynep", Soyad = "Demir" },
        new Ogrenci { Id = 162, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 163, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 164, Ad = "Melis", Soyad = "Sarı" },
        new Ogrenci { Id = 165, Ad = "Selim", Soyad = "Yıldız" }
    }
},
new Sinif
{
    Id = 12,
    Ad = "11-B",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 166, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 167, Ad = "Ali", Soyad = "Yılmaz" },
        new Ogrenci { Id = 168, Ad = "Murat", Soyad = "Güzel" },
        new Ogrenci { Id = 169, Ad = "Ayşe", Soyad = "Kara" },
        new Ogrenci { Id = 170, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 171, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 172, Ad = "Serkan", Soyad = "Kara" },
        new Ogrenci { Id = 173, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 174, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 175, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 176, Ad = "Zeynep", Soyad = "Aydın" },
        new Ogrenci { Id = 177, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 178, Ad = "Mehmet", Soyad = "Demir" },
        new Ogrenci { Id = 179, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 180, Ad = "Furkan", Soyad = "Aydın" }
    }
},
new Sinif
{
    Id = 13,
    Ad = "11-C",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 181, Ad = "Zeynep", Soyad = "Demir" },
        new Ogrenci { Id = 182, Ad = "Serkan", Soyad = "Kara" },
        new Ogrenci { Id = 183, Ad = "Kemal", Soyad = "Güven" },
        new Ogrenci { Id = 184, Ad = "Ayşe", Soyad = "Sarı" },
        new Ogrenci { Id = 185, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 186, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 187, Ad = "Murat", Soyad = "Yıldız" },
        new Ogrenci { Id = 188, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 189, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 190, Ad = "Ali", Soyad = "Öztürk" },
        new Ogrenci { Id = 191, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 192, Ad = "Melis", Soyad = "Sarı" },
        new Ogrenci { Id = 193, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 194, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 195, Ad = "Büşra", Soyad = "Demir" }
    }
},
new Sinif
{
    Id = 14,
    Ad = "11-D",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 196, Ad = "Murat", Soyad = "Güzel" },
        new Ogrenci { Id = 197, Ad = "Serkan", Soyad = "Güzel" },
        new Ogrenci { Id = 198, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 199, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 200, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 201, Ad = "Zeynep", Soyad = "Sarı" },
        new Ogrenci { Id = 202, Ad = "Ayşe", Soyad = "Kara" },
        new Ogrenci { Id = 203, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 204, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 205, Ad = "Ali", Soyad = "Yılmaz" },
        new Ogrenci { Id = 206, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 207, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 208, Ad = "Melis", Soyad = "Sarı" },
        new Ogrenci { Id = 209, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 210, Ad = "Fatma", Soyad = "Çelik" }
    }
},
new Sinif
{
    Id = 15,
    Ad = "11-E",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 211, Ad = "Serkan", Soyad = "Kara" },
        new Ogrenci { Id = 212, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 213, Ad = "Zeynep", Soyad = "Demir" },
        new Ogrenci { Id = 214, Ad = "Ayşe", Soyad = "Sarı" },
        new Ogrenci { Id = 215, Ad = "Murat", Soyad = "Güzel" },
        new Ogrenci { Id = 216, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 217, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 218, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 219, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 220, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 221, Ad = "Kemal", Soyad = "Güven" },
        new Ogrenci { Id = 222, Ad = "Ali", Soyad = "Yılmaz" },
        new Ogrenci { Id = 223, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 224, Ad = "Melis", Soyad = "Sarı" },
        new Ogrenci { Id = 225, Ad = "Ahmet", Soyad = "Öztürk" }
    }
},
    new Sinif
{
    Id = 16,
    Ad = "12-A",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 226, Ad = "Ali", Soyad = "Yılmaz" },
        new Ogrenci { Id = 227, Ad = "Ayşe", Soyad = "Kara" },
        new Ogrenci { Id = 228, Ad = "Murat", Soyad = "Güzel" },
        new Ogrenci { Id = 229, Ad = "Zeynep", Soyad = "Aydın" },
        new Ogrenci { Id = 230, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 231, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 232, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 233, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 234, Ad = "Serkan", Soyad = "Kara" },
        new Ogrenci { Id = 235, Ad = "Melis", Soyad = "Sarı" },
        new Ogrenci { Id = 236, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 237, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 238, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 239, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 240, Ad = "Mehmet", Soyad = "Demir" }
    }
},
new Sinif
{
    Id = 17,
    Ad = "12-B",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 241, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 242, Ad = "Serkan", Soyad = "Kara" },
        new Ogrenci { Id = 243, Ad = "Ali", Soyad = "Yılmaz" },
        new Ogrenci { Id = 244, Ad = "Murat", Soyad = "Güzel" },
        new Ogrenci { Id = 245, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 246, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 247, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 248, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 249, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 250, Ad = "Zeynep", Soyad = "Aydın" },
        new Ogrenci { Id = 251, Ad = "Ayşe", Soyad = "Sarı" },
        new Ogrenci { Id = 252, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 253, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 254, Ad = "Mehmet", Soyad = "Demir" },
        new Ogrenci { Id = 255, Ad = "Kemal", Soyad = "Güven" }
    }
},
new Sinif
{
    Id = 18,
    Ad = "12-C",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 256, Ad = "Serkan", Soyad = "Kara" },
        new Ogrenci { Id = 257, Ad = "Ali", Soyad = "Öztürk" },
        new Ogrenci { Id = 258, Ad = "Zeynep", Soyad = "Aydın" },
        new Ogrenci { Id = 259, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 260, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 261, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 262, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 263, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 264, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 265, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 266, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 267, Ad = "Ayşe", Soyad = "Sarı" },
        new Ogrenci { Id = 268, Ad = "Mehmet", Soyad = "Demir" },
        new Ogrenci { Id = 269, Ad = "Murat", Soyad = "Güzel" },
        new Ogrenci { Id = 270, Ad = "Melis", Soyad = "Sarı" }
    }
},
new Sinif
{
    Id = 19,
    Ad = "12-D",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 271, Ad = "Serkan", Soyad = "Güzel" },
        new Ogrenci { Id = 272, Ad = "Ali", Soyad = "Yılmaz" },
        new Ogrenci { Id = 273, Ad = "Zeynep", Soyad = "Aydın" },
        new Ogrenci { Id = 274, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 275, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 276, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 277, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 278, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 279, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 280, Ad = "Ayşe", Soyad = "Sarı" },
        new Ogrenci { Id = 281, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 282, Ad = "Murat", Soyad = "Güzel" },
        new Ogrenci { Id = 283, Ad = "Mehmet", Soyad = "Demir" },
        new Ogrenci { Id = 284, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 285, Ad = "Melis", Soyad = "Sarı" }
    }
},
new Sinif
{
    Id = 20,
    Ad = "12-E",
    Ogrenciler = new List<Ogrenci>
    {
        new Ogrenci { Id = 286, Ad = "Ela", Soyad = "Aydın" },
        new Ogrenci { Id = 287, Ad = "Zeynep", Soyad = "Aydın" },
        new Ogrenci { Id = 288, Ad = "Murat", Soyad = "Güzel" },
        new Ogrenci { Id = 289, Ad = "Serkan", Soyad = "Kara" },
        new Ogrenci { Id = 290, Ad = "Ayşe", Soyad = "Sarı" },
        new Ogrenci { Id = 291, Ad = "Fatma", Soyad = "Çelik" },
        new Ogrenci { Id = 292, Ad = "Büşra", Soyad = "Demir" },
        new Ogrenci { Id = 293, Ad = "Furkan", Soyad = "Aydın" },
        new Ogrenci { Id = 294, Ad = "Baran", Soyad = "Kılıç" },
        new Ogrenci { Id = 295, Ad = "Cem", Soyad = "Kurt" },
        new Ogrenci { Id = 296, Ad = "Duru", Soyad = "Koç" },
        new Ogrenci { Id = 297, Ad = "Selim", Soyad = "Yıldız" },
        new Ogrenci { Id = 298, Ad = "Ali", Soyad = "Yılmaz" },
        new Ogrenci { Id = 299, Ad = "Melis", Soyad = "Sarı" },
        new Ogrenci { Id = 300, Ad = "Mehmet", Soyad = "Demir" }
    }
}
        };
    


    // Anasayfa
   public IActionResult Index()
{
    var ogretmenAdSoyad = HttpContext.Session.GetString("OgretmenAdSoyad");
    ViewBag.OgretmenAdSoyad = ogretmenAdSoyad;
    // ... diğer işlemler ...
    return View(Siniflar);
}

    // Detay sayfası (Seçilen sınıfın öğrencilerini gösterir)
    public IActionResult Detay(int id)
    {
        // Seçilen sınıfı bul
        var sinif = Siniflar.FirstOrDefault(s => s.Id == id);
        if (sinif == null) return NotFound();

        // Sınıf bilgisi ve öğrenci listesiyle birlikte gönder
        return View(sinif);
    }
}
}
