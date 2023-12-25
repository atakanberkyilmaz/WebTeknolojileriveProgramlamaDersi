using System.ComponentModel.DataAnnotations.Schema;

namespace WebTeknolojileriveProgramlama.DomainEntities
{
    [Table("Ogrenci")]
    public class Ogrenci
    {
        public Guid Id { get; set; }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string OgrenciNo { get; set; }
        public string EPosta { get; set; }
        public string Telefon { get; set; }
        public string Sifre { get; set; }
        
    }
}
