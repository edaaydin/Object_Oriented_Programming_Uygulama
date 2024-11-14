namespace _06_Enums_Ornek2
{
    public static class SanalDatabase
    {
        // Musterilerimi ekleyebilecegim collaction yapisina ihtiyacim var.

        static List<Customer> musterilerim = new List<Customer>();

        public static MusteriDonusTipi CustomerAdd(Customer customer)
        {
            if (musterilerim.Count != 0)
            {
                foreach (Customer item in musterilerim)
                {
                    if (item.Email == customer.Email)
                        return MusteriDonusTipi.AyniMaileSahipMusteri;

                    if (item.CustomerId == customer.CustomerId)
                        return MusteriDonusTipi.AyniNumarayaSahipMusteri;
                }
            }
            musterilerim.Add(customer);
            return MusteriDonusTipi.EklemeBasarili;
        }
    }
}
