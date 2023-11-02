using WebTeknolojileriveProgramlama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using WebTeknolojileriveProgramlama.Extensions;

namespace WebTeknolojileriveProgramlama.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var ad = "";
            var sonuc = MyHtmlExtensions.IsNullOrEmpty(ad);

            if (ad.IsNullOrEmpty())
             {
                //boş bırakamazsın
            }



            var personel = new Personel()
            {
                Id = 1,
                Ad = "Ali",
                Soyad = "Soyad",
                Maas = 40000,
                Departman = "Backend"
            };

            ViewData["Personel"] = personel;

            ViewBag.Personel2 = personel;

            //TempData["Personel3"] = personel;





            //ViewData["PersonelSayisi"] = personel;

            //ViewBag.PersonelSayisi2 = personel;

            //TempData["PersonelSayisi3"] = 1000;


            var jsonPersonel = JsonSerializer.Serialize(personel);
            TempData["Personel3"] = jsonPersonel;

            return RedirectToAction("Privacy");

            //return View();
        }

        public IActionResult Privacy()
        {
            if (TempData["Personel3"] is null)
            {
                ////
            }
            else
            {

            }

            var personel =
                JsonSerializer.Deserialize<Personel>(TempData["Personel3"].ToString());

            ViewBag.Personel = personel;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    //public class HomeController : Controller
    //{
    //    private readonly ILogger<HomeController> _logger;

    //    public HomeController(ILogger<HomeController> logger)
    //    {
    //        _logger = logger;
    //    }

    //    public IActionResult Index()
    //    {
    //        return View();
    //    }

    //    public IActionResult Privacy()
    //    {
    //        return View();
    //    }

    //    public IActionResult Hakkinda()
    //    {
    //        return View();
    //    }

    //}
}