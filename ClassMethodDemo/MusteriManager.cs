using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Bankamıza Hoş Geldiniz Sayın : " + musteri.Adi +" " + musteri.Soyadi );
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Sizi Tanımak Çok güzeldi " + musteri.Adi + " Bey");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" " + musteri.Adi+ " " + musteri.Soyadi +" " + musteri.TcNo );
        }

    }
}
