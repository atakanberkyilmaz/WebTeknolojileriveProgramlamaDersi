using WebTeknolojileriveProgramlama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using WebTeknolojileriveProgramlama.Extensions;
using WebTeknolojileriveProgramlama.Services;
using WebTeknolojileriveProgramlama.IOCIcin;

namespace WebTeknolojileriveProgramlama.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        //private readonly OtomobilContext context;
        private readonly IMarkaService _markaService;
        private readonly IModelService _modelService;

        private readonly ILogger<HomeController> _logger;

        private readonly IDeneme _deneme;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            _markaService = new MarkaService();
            _modelService = new ModelService();
            _deneme = new Deneme();

            //context = new OtomobilContxt();
        }

        public IActionResult Index()


        {
            // var markalar = context.Markalar.ToList();
            var markalar = _markaService.GetTumAktifMarkalar();
            
            var modeller = _modelService.GetModeller(markalar.First().Id);

            return View();
            //var ad = "";
            //var sonuc = MyHtmlExtensions.IsNullOrEmpty(ad);

            //if (ad.IsNullOrEmpty())
            // {
            //    //boş bırakamazsın
            //}



            //var personel = new Personel()
            //{
            //    Id = 1,
            //    Ad = "Ali",
            //    Soyad = "Soyad",
            //    Maas = 40000,
            //    Departman = "Backend"
            //};

            //ViewData["Personel"] = personel;

            //ViewBag.Personel2 = personel;

            //TempData["Personel3"] = personel;





            //ViewData["PersonelSayisi"] = personel;

            //ViewBag.PersonelSayisi2 = personel;

            //TempData["PersonelSayisi3"] = 1000;


            //var jsonPersonel = JsonSerializer.Serialize(personel);
            //TempData["Personel3"] = jsonPersonel;

            //return RedirectToAction("Privacy");

            //return View();
        }

        public IActionResult Privacy()
        {
            //if (TempData["Personel3"] is null)
            //{
            //    ////
            //}
            //else
            //{

            //}

            //var personel =
            //    JsonSerializer.Deserialize<Personel>(TempData["Personel3"].ToString());

            //ViewBag.Personel = personel;
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
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