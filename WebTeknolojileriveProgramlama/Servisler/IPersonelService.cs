using WebTeknolojileriveProgramlama.Models;

namespace WebTeknolojileriveProgramlama.Servisler
{
    public interface IPersonelService
    {
        List<Personel> GetTumPersoneller();

        Personel GetPersonelById(int id);

    }


    public class PersonelService : IPersonelService
    {
        public Personel GetPersonelById(int id)
        {
            var personel = GetPersoneller().Where(x => x.Id == id)
                .FirstOrDefault();

            return personel;
        }

        public List<Personel> GetTumPersoneller()
        {
            return GetPersoneller();
        }

        private List<Personel> GetPersoneller()
        {
            List<string> departmanlar = new List<string>()
            {
                "Backend",
                "Frontend",
                "Test",
                "DBAdmin",
                "Mimar"
            };
            
            return new List<Personel>()
            {
                new Personel()
                {
                    Id = 1,
                    Ad = "Ali",
                    Soyad = "Soyad",
                    Departman = departmanlar[Random.Shared.Next(0,departmanlar.Count-1)],
                    Maas = Random.Shared.Next(25000,90000)
                },
                 new Personel()
                {
                    Id = 2,
                    Ad = "Ali2",
                    Soyad = "Soyad2",
                    Departman = departmanlar[Random.Shared.Next(0,departmanlar.Count-1)],
                    Maas = Random.Shared.Next(25000,90000)
                },
                  new Personel()
                {
                    Id = 3,
                    Ad = "Ali3",
                    Soyad = "Soyad3",
                    Departman = departmanlar[Random.Shared.Next(0,departmanlar.Count-1)],
                    Maas = Random.Shared.Next(25000,90000)
                },
            };
        }
    }
}
