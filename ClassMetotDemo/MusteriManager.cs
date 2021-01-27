using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " isimli müşteri eklendi.");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("-------Listenen Müşteri-------");
            Console.WriteLine("Id\t\t:\t" + musteri.Id);
            Console.WriteLine("TC Kimlik No\t:\t" + musteri.TcKimlikNo);
            Console.WriteLine("Adı\t\t:\t" + musteri.Adi);
            Console.WriteLine("Soyadı\t\t:\t" + musteri.Soyadi);
            Console.WriteLine("Mesleği\t\t:\t" + musteri.Meslegi);


        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " isimli müşteri silindi.");
        }
    }
}
