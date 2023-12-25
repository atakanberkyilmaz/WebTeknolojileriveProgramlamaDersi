using WebTeknolojileriveProgramlama.DomainEntities;
using WebTeknolojileriveProgramlama.EfCore;
using WebTeknolojileriveProgramlama.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hafta10.Controllers
{
    public class OgrenciValidationController : Controller
    {
        private readonly OgrenciBilgiSistemiContext _context;

        public OgrenciValidationController(OgrenciBilgiSistemiContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle(OgrenciOlusturGuncelleDto ogrenci)
        {

            if (!ModelState.IsValid)
            {
                return View();

            }


            var ogrenciEntity = new Ogrenci();
            ogrenci.Id = Guid.NewGuid();
            _context.Ogrenciler.Add(ogrenciEntity);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


    }
}
