namespace _04_Polymorphism
{
    internal class Televizyon : BaseClass
    {
        public override void EkranaYaz(string data)
        {
            Console.WriteLine($"Televizyon : {data}");
        }
    }
}
