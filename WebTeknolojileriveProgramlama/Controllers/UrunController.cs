using Microsoft.AspNetCore.Mvc;

namespace WebTeknolojileriveProgramlama.Controllers
{
    public class UrunController : Controller
    {
        public dynamic KategoriId { get; private set; }

        //asdasd


        /*
         * asdasdasd
         * 
         */
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UrunListesi()
        {
            return View();
        }

        public IActionResult UrunDetay(int id)
        {
            ViewBag.id = id;
            ViewBag.KategoriId = KategoriId;
            return View();
        }
    }
}
