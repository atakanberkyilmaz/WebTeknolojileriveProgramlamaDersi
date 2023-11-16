using WebTeknolojileriveProgramlama.Dtos;

namespace WebTeknolojileriveProgramlama.Services
{
    public interface IMarkaService
    {
        void MarkaEkle();
        List<MarkaDto> GetTumAktifMarkalar();
    }
}
