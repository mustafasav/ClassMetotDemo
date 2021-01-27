using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TcKimlikNo = "123456789";
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "Sav";
            musteri1.Meslegi = "Öğretmenlik";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TcKimlikNo = "1234567800";
            musteri2.Adi = "Gökhan";
            musteri2.Soyadi = "Birbağ";
            musteri2.Meslegi = "Askeriye";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.TcKimlikNo = "100000000";
            musteri3.Adi = "Engin";
            musteri3.Soyadi = "Demiroğ";
            musteri3.Meslegi = "Yazılım Geliştirici";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteri3);

        }
    }
}
