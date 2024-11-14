namespace _04_polymorphism_Ornek2
{
    public class Ders
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string DersAdi { get; set; }

        private double _gecmeNotu = 50;
        public double GecmeNotu
        {
            get { return _gecmeNotu; }
            set { _gecmeNotu = value; }
        }
        public virtual double GecmeNotuHesapla()
        {
            return GecmeNotu;
        }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }




    }
}

/*
 Ders adında temel sınıfınızda ogrenci adı-soyadı, ders adı, double gecme notu propları, ve gecme hesapla adında double sonuc donduren bir metot olmalı.

fizik dersi icin gecme notu 1.1 ile carpılarak,
kimya dersi icin gecme notu 0.8 ile carpılarak ve 
matematik icin gecme notu 1.2 katsayısıyla hesaplanmaktadır.

Ders sınıfınsa gecme notu 50'dir. Farklı derslere gore gecme notunu hesaplayan metotları sınıflar icinde olusturunuz. 

ve tabiki nesneleri olusturup cıktılarını veriniz.

 */
