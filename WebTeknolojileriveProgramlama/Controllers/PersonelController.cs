using WebTeknolojileriveProgramlama.Servisler;
using Microsoft.AspNetCore.Mvc;

namespace Hafta4.Controllers
{
    public class PersonelController : Controller
    {
        private readonly IPersonelService _personelService;

        public PersonelController()
        {
            _personelService = new PersonelService();
        }

        public IActionResult Index()
        {
            var personelListesi = _personelService.GetTumPersoneller();

            return View(personelListesi);
        }

        public IActionResult Detay(int id)
        {
            var pesonel = _personelService.GetPersonelById(id);

            return View(pesonel);
        }

        public IActionResult Detay2(int personelId)
        {
            var pesonel = _personelService.GetPersonelById(personelId);

            return View("Detay", pesonel);
        }
    }
}
