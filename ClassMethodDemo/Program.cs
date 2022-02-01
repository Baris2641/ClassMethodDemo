using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.Adi = "Barış";
            musteri1.Soyadi = "IŞIK";
            musteri1.TcNo = "123456789";


            Musteri musteri2 = new Musteri();

            musteri2.Id = 2;
            musteri2.Adi = "Ahmet";
            musteri2.Soyadi = "Mehmetoğlu";
            musteri2.TcNo = "321654987";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);

            Console.WriteLine("---------------------");
            
            musteriManager.Sil(musteri2);
            
            Console.WriteLine("---------------------");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            Console.WriteLine("---------------------");

        }
    }
}
