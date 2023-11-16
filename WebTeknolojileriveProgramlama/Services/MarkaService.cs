using WebTeknolojileriveProgramlama.Dtos;

namespace WebTeknolojileriveProgramlama.Services
{
    public class MarkaService : IMarkaService
    {
        private readonly OtomobilContext context;

        public MarkaService()
        {
            context = new OtomobilContext();
        }
        public List<MarkaDto> GetTumAktifMarkalar()
        {
            var sonuc = context.Markalar
                .Where(x=> x.AktifMi)
                .OrderBy(x=> x.Adi)
                .Select(x=> new MarkaDto
                {
                    Id = x.Id,
                    Adi = x.Adi,
                })
                .ToList();
           return sonuc;
        }

        public void MarkaEkle()
        {
            throw new NotImplementedException();
        }
    }
}
