namespace _06_Enums_Ornek2
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public MusteriDonusTipi MusteriDonusTipi { get; set; }

        // Sanal/Fake Database olusturalım, musterileri ekleyelim. Basarili yada basarisizlik durumlarini enumlarla yapalim.
    }
}
