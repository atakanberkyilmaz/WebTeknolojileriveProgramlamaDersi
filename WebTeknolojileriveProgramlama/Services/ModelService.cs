using WebTeknolojileriveProgramlama.Dtos;

namespace WebTeknolojileriveProgramlama.Services
{
    public class ModelService : IModelService
    {
        private readonly OtomobilContext context;
        

        public ModelService(OtomobilContext context)
        {
            //_context = new OtomobilContext();

            _context = context;
        }
        public List<ModelDto> GetModeller(int markaId)
        {
            var modeller =_context.Modeller
                .Include(x=> x.MarkaFk)
                .Where(x => x.MarkaId == markaId)
                .Select(x => new ModelDto
                {
                   Id= x.Id,
                   Adi = x.Adi,
                   MarkaAdi = x.MarkaFk.Adi
                }).ToList();
        }
    }
}
