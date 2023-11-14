using System.ComponentModel.DataAnnotations;

namespace WebTeknolojileriveProgramlama.Dtos
{
    public class OgrenciEklemeDto
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string EPosta { get; set; }
        
        [Display(Name = "Öğrenci Numarası")]
        public string OgrenciNo { get; set; }
        
        [Display(Name = "Öğrenci Türü")]
        public int OgrenciTuru { get; set; }
    }

    public class OgrenciGuncellemeDto : OgrenciEklemeDto
    {
        public int Id { get; set; }
    }

    
}
