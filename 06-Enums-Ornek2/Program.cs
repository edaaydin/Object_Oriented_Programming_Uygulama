using _06_Enums_Ornek2;

Customer customer = new Customer()
{
    Id = 1,
    CustomerId = "a12",
    Email = "ali@gmail.com",
    Name = "Ali",
    Lastname = "Yilmaz",
};
MusteriDonusTipi sonuc1 = SanalDatabase.CustomerAdd(customer);
Console.WriteLine(sonuc1 + " " + (int)sonuc1);
