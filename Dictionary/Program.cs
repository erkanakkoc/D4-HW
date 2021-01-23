using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> ogrenci = new MyDictionary<int, string>();
            ogrenci.Add(1, "Erkan");
            ogrenci.Add(2, "Mert");
            ogrenci.Add(3, "Deneme");

            ogrenci.Show();

            MyDictionary<int, string> yOgrenci = new MyDictionary<int, string>();
            Console.WriteLine("Kaç Öğrenci Eklenecek?");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Eklenecek öğrenci isimleri nelerdir?");
                string yAd = Console.ReadLine();
                ogrenci.Add(ogrenci.Count + 1, yAd);
                
            }
            
            ogrenci.Show();


        }
    }
}
