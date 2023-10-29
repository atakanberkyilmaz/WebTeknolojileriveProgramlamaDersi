using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace WebTeknolojileriveProgramlama.Controllers
{
    public class HakkindaController : Controller
    {
        public IActionResult About()
        {
            return View("Index");
        }
    }
}
