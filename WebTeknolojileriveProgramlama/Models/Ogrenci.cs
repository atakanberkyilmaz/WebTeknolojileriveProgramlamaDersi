namespace WebTeknolojileriveProgramlama.Models
{
    public class Ogrenci
    {
        public string OgrenciNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Id { get; internal set; }

        public void Test()
        {

            //A a = new A();
            B b = new B();
            C c = new C();

            A a1 = new B();
            A a2 = new C();

        }
    }

    public abstract class A
    {

    }

    public class B:A
    {

    }

    public class C : A
    {

    }

}
