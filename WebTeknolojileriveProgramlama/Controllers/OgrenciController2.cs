using Microsoft.AspNetCore.Mvc;
using WebTeknolojileriveProgramlama.Dtos;
using WebTeknolojileriveProgramlama.Models.OgrenciViewModels;
using WebTeknolojileriveProgramlama.Services;

namespace WebTeknolojileriveProgramlama.Controllers
{
    public class OgrenciController2 : Controller
    {
        private readonly OgrenciService _ogrenci2Service;

        public OgrenciController2()
        {
            _ogrenci2Service = new OgrenciService();
        }
        public IActionResult Index()
        {
            var ogrenciListesi = _ogrenci2Service.OgrenciListe();

            var model = new IndexViewModel
            {
               OgrenciListesi = ogrenciListesi,
                Sayi = 1
            };
            return View();
        }
        [HttpGet]
        public IActionResult OgrenciEkle()
        {
            var ogrenciTurleri = _ogrenci2Service.GetOgrenciTurleri();
            ViewBag.OgrenciTurleri = ogrenciTurleri;

            return View();
        }

        [HttpPost]
        public IActionResult OgrenciEkle(OgrenciEklemeDto input)
        {
            //Request.Form
            _ogrenci2Service.OgrenciKaydet(input);

            return RedirectToAction("Index");
        }


        public IActionResult OgrenciDuzenle(int id)
        {
            var ogrenciTurleri = _ogrenci2Service.GetOgrenciTurleri();
            ViewBag.OgrenciTurleri = ogrenciTurleri;

            var ogrenci = _ogrenci2Service.GetOgrenciForEdit(id);

            return View(ogrenci);
        }

        [HttpPost]
        public IActionResult OgrenciDuzenle(OgrenciGuncellemeDto input)
        {
            _ogrenci2Service.Ogrenci2Duzenle(input);

            return RedirectToAction("Index");
        }
    }
}
