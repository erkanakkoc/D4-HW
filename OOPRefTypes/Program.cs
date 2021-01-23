using System;

namespace DegerVeRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi();
            Kisi kisi2 = new Kisi();
            kisi1.Ad = "Erkan";


            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Öğrenci1";

            //Kisi kisi3 = ogrenci;
            //ogrenci.Ad = "Kişi 3";
            //Console.WriteLine(((Ogrenci)kisi3).Ad);

            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Ad = "Ogretmen1";

            OkulManager okulManager = new OkulManager();
            okulManager.Add(ogrenci);

        }
    }
    class Kisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

    }

    class Ogretmen : Kisi
    {
        public int OgretmenId { get; set; }
    }

    class Ogrenci : Kisi
    {
        public int OgrenciId { get; set; }
    }

    class OkulManager
    {
        public void Add(Kisi kisi)
        {
            Console.WriteLine(kisi.Ad);
        }
    }
}
