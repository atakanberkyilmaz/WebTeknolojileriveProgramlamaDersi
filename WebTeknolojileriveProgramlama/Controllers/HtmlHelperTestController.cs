using Microsoft.AspNetCore.Mvc;
using WebTeknolojileriveProgramlama.Models;

namespace WebTeknolojileriveProgramlama.Controllers
{
    public class HtmlHelperTestController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] //Eğer sunucuyu izleyen biri varsa senin işlemlerini görebilirler 
        // 
        public IActionResult UrunKaydet(UrunKaydetDto input) 
        
        {
            var SSS = Request.Form; // input kullanarak vakitten kazanabilirsin
            return View();
        }
    }
    
}
