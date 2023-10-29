using WebTeknolojileriveProgramlama.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebTeknolojileriveProgramlama.Controllers
{
    public class VeriTasimaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["OgrenciSayisi"] = 1000;
            
            ViewData["Ogrenci"] = new Ogrenci
            {
                Ad = "Ali",
                Soyad = "Veli",
                OgrenciNo = "1234567891"
            };

            ViewBag.Ogrenci2 = new Ogrenci
            {
                Ad = "Mehmet",
                Soyad = "KÖSE",
                OgrenciNo = "78945612344"
            };


            return View();
        }

        public IActionResult ModelleTasi()
        {
             var ogrenci = new Ogrenci
             {
                 Ad = "Muzaffer",
                 Soyad = "SOBACI",
                 OgrenciNo = "19874561264"
             };

            return View(ogrenci);
            //return View();
        }
    }
}
