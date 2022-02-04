using System;

namespace Proje_10_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Void Parametre döndürmez,Default olarak Private olur
            void Topla()
            {

                int a = 8;
                int b = 10;
                Console.WriteLine(a + b);
            }
            void Yaz()
            {

                Console.WriteLine("Merhaba Wissen");
            }

            void Topla2(int sayi1, int sayi2)
            {
                Console.WriteLine(sayi1 + sayi2);

            }


            void Yaz2(string ad)
            {

                Console.WriteLine($"Merhaba {ad}");
            }
            //iki sayıpgrip toplayacak ekrana yazdıracak



            void IslemYap(string secim)
            {
                int sonuc = 0;
                if (secim == "+" || secim == "-" || secim == "*" || secim == "/")
                {
                    Console.Write("1. sayiyi giriniz");
                    int sayi1 = int.Parse(Console.ReadLine());
                    Console.Write("2. sayiyi giriniz");
                    int sayi2 = int.Parse(Console.ReadLine());

                    if (secim == "+")
                    {
                        sonuc = sayi1 + sayi2;
                    }
                    else if (secim == "-")
                    {
                        sonuc = sayi1 - sayi2;
                    }
                    else if (secim == "*")
                    {
                        sonuc = sayi1 * sayi2;
                    }
                    else if (secim == "/")
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    Console.WriteLine($"Sonuc: { sonuc}");


                }
                else
                {
                    Console.WriteLine("Lütfen doğru bir işlem türü gir!!");
                    Console.ReadLine();
                }


            }

            Console.ReadLine();



            //Sırayla Yapar
            /* Yaz();
             Topla();
             Topla2(60, 70);
             Yaz2("Berkay");
             Yaz2("Engin");
             Yaz2("Bugün günlerden Cuma");
            IslemYap("/");
            
             */



        }
    }

}
