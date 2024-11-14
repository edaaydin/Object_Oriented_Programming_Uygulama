namespace _04_Polymorphism
{
    public class BaseClass
    {
        public virtual void EkranaYaz(string data) // geri donussuz ama miras verebilen metot.
        {
            Console.WriteLine(data);
        }
    }
}
