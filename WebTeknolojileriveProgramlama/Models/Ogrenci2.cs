namespace WebTeknolojileriveProgramlama.Models
{
    public class Ogrenci2
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string OgrenciNo { get; set; }
        public string EPosta { get; set; }

        public Ogrenci2Tur OgrenciTuru { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public int UserId { get; set; }


        public DateTime? GuncellenmeTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }

    }
}
