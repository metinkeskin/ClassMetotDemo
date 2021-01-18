using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        // namin convation
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Musteri Eklendi: " + musteri.MusterininAdi + " " + musteri.MusteriSoyismi);

        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Tebrikler musteriler listelendi; musteri adi soyadi: "+ musteri.MusterininAdi + " "+ musteri.MusteriSoyismi +" Tc: "+ musteri.Tc + " yasi: "+ musteri.Yas);

        }
        public void cıkar(Musteri musteri)
        {
            Console.WriteLine("Tebrikler musteri cikarildi: " + musteri.MusterininAdi + " " + musteri.MusteriSoyismi);
        }
    }
}
