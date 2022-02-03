using System;

namespace Proje_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string adSoyad;
            adSoyad = "berkay emir";
            Console.WriteLine(adSoyad);

            int age = 29;
            Console.WriteLine(age);

            int hour = DateTime.Now.Hour;
            int year = DateTime.Today.Year;

            Console.WriteLine( year + " " + hour );

            Console.WriteLine("Merhaba " + adSoyad + ", günün güzel geçsin");
            Console.WriteLine($"Merhaba {adSoyad}, günün güzel geçsin");


            Console.ReadLine();
           
        }
    }
}
