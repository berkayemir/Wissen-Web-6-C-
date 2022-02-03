using System;

namespace Proje_09_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] firstArray = { 10, 20, 30 };

            //for (int i = 0; i <firstArray.Length ; i++)
            //{
            //    Console.WriteLine(firstArray[i]);   
            //}


            //Random Sayi Üretme

            //Random rnd = new Random();
            // int rastgele = rnd.Next(1,100);
            //Random rnd = new Random(); ;
            //int[] sayilar = new int[5];
            //for (int i = 0; i < 5; i++)
            //{

            //    sayilar[i] = rnd.Next(1, 100);

            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(sayilar[i]*2);
            //}
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi*2);
            //}

            /*Programımız 1-100 arasında rastgele sayı üretsin
              Kullanicidan bu sayiyi tahmin etmesii isteyelim
            Bilirse tebrik edelim bilemesse kaybettin diyelim ve programı bitirelim
             */
            //Random rnd = new Random();
            //int sayi = rnd.Next(1, 100);
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"({sayi})Bir tahmin gir:  ");
            //    int tahmin = int.Parse(Console.ReadLine());
            //    if (sayi!=tahmin)
            //    {
            //        Console.WriteLine($"{tahmin} sayisi doğru değil tekrar deneyiniz!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{tahmin} sayisi doğru tebrikler!");
            //        break;

            //    }
            //}

            //Random rnd = new Random();
            //int sayi = rnd.Next(1, 100);
            //int sayac = 1;

            //while (sayac<6)
            //{
            //    Console.Write($"({sayi})Sayi Giriniz:       ");
            //    int tahmin = int.Parse(Console.ReadLine());
            //    if (tahmin!=sayi)
            //    {
            //        Console.WriteLine($"{sayac}.tahmini yanlış girdiniz, tekrar sayi giriniz");
            //        sayac++;
            //        if (sayac==6)
            //        {

            //            Console.WriteLine("Hakkın bitti!");
            //        }

            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Dogru tahmin");
            //        Console.ReadLine();
            //        Environment.Exit(0);
            //    }

            //}


            //Random rnd = new Random();
            //int sayi = rnd.Next(1, 100);
            //int sayac = 1;
            //int tahmin = 0;

            //do
            //{

            //    Console.WriteLine($"{sayac}.Tahmininizi giriniz");
            //    tahmin = int.Parse(Console.ReadLine());
            //    if (sayac != tahmin)
            //    {
            //        Console.WriteLine("Yanlış tahmin");
            //    }
            //    sayac++;
            //} while (sayac<=5 && sayi!=tahmin);
            //if (sayi==tahmin)
            //{
            //    Console.WriteLine("Tebrikler");
            //}
            //else
            //{
            //    Console.WriteLine("Oyun bitti.");
            //}

            /*
             1.tahminde 50 puan
            2.tahminde 40 puan
            3.tahminde 30 puan
            4.tahminde 20 puan
            5.tahmin   10
            */

            Random rnd = new Random();
            int rndSayi = rnd.Next(1, 100);
           
            for (int i = 5; i>=1 ; i--)
            {
                Console.WriteLine($"{rndSayi} {6-i}.tahmini giriniz:    ");
                int tahmin = int.Parse(Console.ReadLine());
                if (tahmin==rndSayi)
                {
                    Console.WriteLine($"{i*10} puan kazandınız");
                    Console.WriteLine("Tebrikler!!");
                    break;
                }
                else
                {
                    Console.WriteLine($"{6 - i}.tahmini yanlış girdiniz");
                    if (i==1)
                    {
                        Console.WriteLine("Hakkiniz bitti!");
                        Console.ReadLine();
                        break;
                    }
                }

                

               
            }



            Console.ReadLine(); ;

        }
    }
}
