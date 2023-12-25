using WebTeknolojileriveProgramlama.DomainEntities;
using WebTeknolojileriveProgramlama.EfCore;
using WebTeknolojileriveProgramlama.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hafta10.Controllers
{
    public class OgrenciController3 : Controller
    {
        private readonly OgrenciBilgiSistemiContext _context;

        public OgrenciController3(OgrenciBilgiSistemiContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var ogrenciler = _context.Ogrenciler.ToList();

            var ogrencilerAsenkron = await _context.Ogrenciler.ToListAsync();
            

            return View(ogrencilerAsenkron);
        }

        public IActionResult Ekle()
        {
            var duyurular = new List<Duyuru>()
            {
                new Duyuru()
                {
                    Id = 1,
                    Baslik = "Projelerinizle ilgilenmeyi unutlamayın",
                    Icerik = "Unutma!!!!",
                    YayinlanmaTarihi = new DateTime(2023,12,14)

                },
                new Duyuru()
                {
                    Id = 2,
                    Baslik = "Biraz da gez",
                    Icerik = "Unutma!!!!",
                    YayinlanmaTarihi = new DateTime(2023,12,01)

                },
                new Duyuru()
                {
                    Id = 2,
                    Baslik = "Biraz da gez 2222",
                    Icerik = "Unutma 22!!!!",
                    YayinlanmaTarihi = new DateTime(2023,12,01)

                },
            };
            ViewBag.Duyurular = duyurular;

            List<Bolum> bolumler = new List<Bolum>();
            for (int i = 0; i < 10; i++)
            {
                bolumler.Add(new Bolum
                {
                    Id = (i+1),
                    Ad = $"Bolum {i}"
                });
            }

            ViewBag.Bolumler = bolumler;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle(Ogrenci ogrenci)
        {
            //OgrenciBilgileriniDogrula(ogrenci);

            //List<Bolum> bolumler = new List<Bolum>();
            //for (int i = 0; i < 10; i++)
            //{
            //    bolumler.Add(new Bolum
            //    {
            //        Id = (i + 1),
            //        Ad = $"Bolum {i}"
            //    });
            //}

            //ViewBag.Bolumler = bolumler;



            ogrenci.Id = Guid.NewGuid();
            _context.Ogrenciler.Add(ogrenci);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        //private void OgrenciBilgileriniDogrula(Ogrenci ogrenci)
        //{
        //    if (string.IsNullOrEmpty(ogrenci.Ad))
        //    {
        //        //
        //    }

        //    if (string.IsNullOrEmpty(ogrenci.Soyad))
        //    {

        //    }

        //    if (string.IsNullOrEmpty(ogrenci.OgrenciNo) || ogrenci.OgrenciNo.Length != 10)
        //    {

        //    }
        //}

        public async Task<IActionResult> Duzenle(Guid id)
        {
            var duzenlenecekOgrenci =  await _context.Ogrenciler
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();


            return View(duzenlenecekOgrenci);
        }
    }
}
