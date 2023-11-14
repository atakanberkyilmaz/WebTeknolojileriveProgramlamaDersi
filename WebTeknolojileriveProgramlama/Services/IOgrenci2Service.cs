using WebTeknolojileriveProgramlama.Dtos;
using WebTeknolojileriveProgramlama.Models;

namespace WebTeknolojileriveProgramlama.Services
{
    public interface IOgrenciService2
    {
        List<OgrenciDto> OgrenciListe();

        OgrenciGuncellemeDto GetOgrenciForEdit(int id);

        List<DropDownListForOgrenciTur> GetOgrenciTurleri();
        void OgrenciKaydet(OgrenciEklemeDto input);
        void OgrenciDuzenle(OgrenciGuncellemeDto input);
    }

    public class OgrenciService : IOgrenciService2
    {
        private static List<Ogrenci2> _ogrenciListe = new List<Ogrenci2>
        {
            new Ogrenci2()
            {
                Id = 1,
                Ad = "Ali",
                Soyad = "Soyad",
                EPosta = "ali@gmail.com",
                OgrenciNo = "2312345678",
                OlusturulmaTarihi = DateTime.Now.AddDays(-10),
                UserId = 1
            }
        };

        public OgrenciGuncellemeDto GetOgrenciForEdit(int id)
        {
            var ogrenci2 = _ogrenciListe.Where(x => x.Id == id)
                .FirstOrDefault();

            if (ogrenci2 is null)
                throw new Exception("Öğrenci Bulunamadı");

            return new OgrenciGuncellemeDto
            {
                Id = ogrenci2.Id,
                Ad = ogrenci2.Ad,
                Soyad = ogrenci2.Soyad,
                EPosta = ogrenci2.EPosta,
                OgrenciNo = ogrenci2.OgrenciNo,
                OgrenciTuru = (int)ogrenci2.OgrenciTuru,
            };
        }

        public List<DropDownListForOgrenciTur> GetOgrenciTurleri()
        {
            return new List<DropDownListForOgrenciTur>
            {
                new DropDownListForOgrenciTur()
                {
                    Id = (int)Ogrenci2Tur.OnLisans,
                    Ad = "Ön lisans"
                },
                new DropDownListForOgrenciTur()
                {
                    Id = (int)Ogrenci2Tur.Lisans,
                    Ad = "Lisans"
                },
                new DropDownListForOgrenciTur()
                {
                    Id = (int)Ogrenci2Tur.YuksekLisans,
                    Ad = "Yüksek Lisans"
                },
                new DropDownListForOgrenciTur()
                {
                    Id = (int)Ogrenci2Tur.Doktora,
                    Ad = "Doktora"
                }
            };
        }

        public void Ogrenci2Duzenle(OgrenciGuncellemeDto input)
        {
            var ogrenci2 = _ogrenciListe.Where(x => x.Id == input.Id)
               .FirstOrDefault();

            if (ogrenci2 is null)
                throw new Exception("Öğrenci Bulunamadı");

            ogrenci2.Ad = input.Ad;
            ogrenci2.Soyad = input.Soyad;
            ogrenci2.OgrenciNo = input.OgrenciNo;
            ogrenci2.OgrenciTuru = (Ogrenci2Tur)input.OgrenciTuru;
            ogrenci2.EPosta = input.EPosta;
            ogrenci2.GuncellenmeTarihi = DateTime.Now;
            ogrenci2.GuncelleyenUserId = 2;

        }

        public void OgrenciDuzenle(OgrenciGuncellemeDto input)
        {
            throw new NotImplementedException();
        }

        public void OgrenciKaydet(OgrenciEklemeDto input)
        {
            var id = _ogrenciListe.Max(x => x.Id);

            id++;

            _ogrenciListe.Add(new Ogrenci2
            {
                Id = id,
                Ad = input.Ad,
                Soyad = input.Soyad,
                EPosta = input.EPosta,
                OgrenciNo = input.OgrenciNo,
                OgrenciTuru = (Ogrenci2Tur)input.OgrenciTuru,
                UserId = 1,
                OlusturulmaTarihi = DateTime.Now
            });

        }

        public List<OgrenciDto> OgrenciListe()
        {
            var sonuc = _ogrenciListe.Select(x => new OgrenciDto
            {
                Id = x.Id,
                Ad = x.Ad,
                Soyad = x.Soyad,
                Eposta = x.EPosta,
                OgrenciNo = x.OgrenciNo
            }).ToList();

            return sonuc;
        }
    }
}
