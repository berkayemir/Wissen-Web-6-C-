using System;

namespace Proje_04_Reference_Types
{
    class Program
    {
        class Kisi
        {
            public string Ad { get; set; }
            public int Yas { get; set; }

        }
        static void Main(string[] args)
        {
            Kisi person1 = new Kisi();
            Kisi person2 = new Kisi();
            person1.Ad = "Berkay";
            person1.Yas = 29;

            Console.WriteLine($"{person1.Ad}, sen {person1.Yas} yasındasın.");


            person2.Ad = "Umay";
            person2.Yas = 15;

            Console.WriteLine($"{person2.Ad}, sen {person2.Yas} yasındasın.");

            person2 = person1;
            Console.WriteLine($"{person1.Ad}, sen {person1.Yas} yasındasın.");
            Console.WriteLine($"{person2.Ad}, sen {person2.Yas} yasındasın.");






            Console.ReadLine();
        }
    }
}
