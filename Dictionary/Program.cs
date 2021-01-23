using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> student = new MyDictionary<int, string>();
            student.Add(1, "Erkan");
            student.Add(2, "Mert");
            student.Add(3, "Deneme");

            student.Show();

            MyDictionary<int, string> yOgrenci = new MyDictionary<int, string>();
            Console.WriteLine("How many student will add?");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine((i+1)+". student's name?");
                string yName = Console.ReadLine();
                student.Add(student.Count + 1, yName);
                Console.WriteLine("------------------------------------");
                
            }
            
            student.Show();


        }
    }
}
