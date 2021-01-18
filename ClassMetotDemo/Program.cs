using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusterininAdi = "Adil";
            musteri1.MusteriSoyismi = "Keskin";
            musteri1.Tc = 1236547;
            musteri1.Yas = 28;

            Musteri musteri2 = new Musteri();
            musteri2.MusterininAdi = "Ahmet";
            musteri2.MusteriSoyismi = "Kartal";
            musteri2.Tc = 3216549;
            musteri2.Yas = 57;

            Musteri musteri3 = new Musteri();
            musteri3.MusterininAdi = "Enes";
            musteri3.MusteriSoyismi = "Tekin";
            musteri3.Tc = 1236547;
            musteri3.Yas = 28;


            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3};

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusterininAdi);
                Console.WriteLine(musteri.MusteriSoyismi);
                Console.WriteLine(musteri.Tc);
                Console.WriteLine(musteri.Yas);
                Console.WriteLine("-----------------------");

            }

            Console.WriteLine("---------Metotlar----------");
            Console.WriteLine("                   ");

            Console.WriteLine("********MUSTERI EKLEME*****");
            Console.WriteLine("                   ");

            

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("                   ");
            Console.WriteLine("*****MUSTERI LISTELEME******");
            Console.WriteLine("                   ");



            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            Console.WriteLine("                   ");
            Console.WriteLine("****MUSTERİ CIKARMA*********");
            Console.WriteLine("                   ");


            musteriManager.cıkar(musteri1);
            musteriManager.cıkar(musteri2);
            musteriManager.cıkar(musteri3);



        }
    }
}
