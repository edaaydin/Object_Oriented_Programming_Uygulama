/*
 Ders adında temel sınıfınızda ogrenci adı-soyadı, ders adı, double gecme notu, propları, ve gecme hesapla adında double sonuc donduren bir metot olmalı.

fizik dersi icin gecme notu 1.1 ile carpılarak,
kimya dersi icin gecme notu 0.8 ile carpılarak ve 
matematik icin gecme notu 1.2 katsayısıyla hesaplanmaktadır.

Ders sınıfınsa gecme notu 50'dir. Farklı derslere gore gecme notunu hesaplayan metotları sınıflar icinde olusturunuz. 

ve tabiki nesneleri olusturup cıktılarını veriniz.
 */

using _04_polymorphism_Ornek2;

Ders ders = new Ders();

Matematik matematik = new Matematik();

Fizik fizik = new Fizik();

Kimya kimya = new Kimya();

Console.WriteLine($"Fizik Gecme Notu : {fizik.GecmeNotuHesapla()} ");
Console.WriteLine($"Kimya Gecme Notu : {kimya.GecmeNotuHesapla()} ");
Console.WriteLine($"Matematik Gecme Notu : {matematik.GecmeNotuHesapla()} ");
Console.WriteLine($"Gecme Notu : {ders.GecmeNotuHesapla()} ");

ders.Ad = "Eda";
ders.Soyad = "Aydin";
Console.WriteLine($"Adi ve Soyadi : {ders.ToString()} ");

