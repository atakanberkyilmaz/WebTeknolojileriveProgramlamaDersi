namespace WebTeknolojileriveProgramlama.IOCIcin
{
    public interface IDeneme
    {
        void Test();

    }

    public class Deneme : IDeneme
    {
        public Guid Id { get; set; }

        public DateTime OlusuturmaTarihi { get; set; }

        public Deneme() 
        { 
              Id = Guid.NewGuid();
             OlusuturmaTarihi = DateTime.Now;
            
        }
        public void Test() { }
    }
    public interface IDeneme2
    {
        void Test();

    }
    public class Deneme2 : IDeneme2
    {
        public Guid Id { get; set; }

        public DateTime OlusuturmaTarihi { get; set; }

        public Deneme2()
        {
            Id = Guid.NewGuid();
            OlusuturmaTarihi = DateTime.Now;

        }
        public void Test() { }
    }
}
