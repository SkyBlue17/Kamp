using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array = diziler

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kursu" , "Programlamaya başlangıç kursu" , "Java" ,"Pyhton","C++"};

            
            
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti.");
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
