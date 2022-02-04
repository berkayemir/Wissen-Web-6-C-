using System;

namespace Proje_11_Method_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            int rndSayi;
            int tahminSayi;
            int Puan;

            int SayiUret()
            {
                Random rnd = new Random();
                int rastgeleSayi = rnd.Next(1, 100);
                return rastgeleSayi;
            }

            void Acıklama()
            {
                Console.WriteLine($"{rndSayi}    Lütfen tahmin ettiğiniz sayiyi giriniz");
            }

            int Tahmin()
            {
                int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
                return tahminEdilenSayi;
            }



            void YanlisTahmin()
            {
                Console.WriteLine("Yanlış tahmin!Tekrar Sayi Giriniz");
            }


            void Karsılastırma()
            {
                if (tahminSayi != rndSayi)
                {
                    YanlisTahmin();

                }
                else if (tahminSayi == rndSayi)
                {
                    Console.WriteLine($"Tebrikler Doğru Tahmin!! Puanınız:{Puan}   ");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        a1:
            rndSayi = SayiUret();
            Acıklama();
             Puan = 50;


            for (int i = 1; i <= 5; i++)
            {
                tahminSayi = Tahmin();
                Karsılastırma();
                Puan = Puan - 10;


                if (i == 5)
                {
                    
                    Console.WriteLine($"Hakkiniz Doldu!! Puanınız:  {i*0}");
                    
                    Console.WriteLine("Devam etmek istiyor musunuz? (Y/N)");
                    string secim = Console.ReadLine();
                    if (secim == "Y")
                    {
                        Console.Clear();
                        Puan = 0;
                        goto a1;
                    }
                    else if (secim == "N")
                    {
                        Console.Clear();
                        Console.WriteLine("Hoşçakalın!!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                }
            }













            Console.ReadLine();






        }
    }
}
