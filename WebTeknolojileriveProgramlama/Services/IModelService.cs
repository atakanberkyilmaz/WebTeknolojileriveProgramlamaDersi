using WebTeknolojileriveProgramlama.Dtos;

namespace WebTeknolojileriveProgramlama.Services
{
    public interface IModelService
    {
        List<ModelDto> GetModeller(int markaId);
    }
}
