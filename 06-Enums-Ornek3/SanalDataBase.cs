using System.Collections;

namespace _06_Enums_Ornek3
{
    public static class SanalDataBase
    {
        public static ArrayList db = new ArrayList();

        public static Sonuc YeniUrunEkle(BaseClass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.Barkod))
            {
                // null yada empty oldugunda true donuyor, ben false tarafınndayım.
                db.Add(data.Barkod);
                return Sonuc.Basarili;
            }
            else
                return Sonuc.Basarisiz;
        }
        public static bool DbBarkodKontrol(string barkod)
        {
            bool kontrol = false;

            if (db.Count > 0)
            {
                foreach (BaseClass item in db)
                {
                    if (item.Barkod == barkod)
                    {
                        kontrol = true;
                        break;
                    }
                }
            }
            return kontrol;
        }
    }
}
