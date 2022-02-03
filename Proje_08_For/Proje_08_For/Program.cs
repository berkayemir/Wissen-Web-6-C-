using System;

namespace Proje_08_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Hello - {i+1}");
            //}

            //1-10 arasındaki sayıları ekranda yazdırsın altında da toplam
            //int toplam = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i%2==0)
            //    {
            //        Console.WriteLine(i);
            //        toplam = toplam + i;
            //    }
            //}
            //Console.WriteLine($"Toplam:     { toplam}");

            //1-100 arasındaki asal sayıları bulup sırasıyla ekrana yazdırın

            //

            //1-100 arasında 5 ve 7 ye bölünemeyenler

            //for (int i = 1; i < 100; i++)
            //{
            //    if (i%5!=0 && i%7!=0)
            //    {
            //        Console.WriteLine($"5 ve 7 ye bölünemeyenler:   {i}");
            //    }

            //}



            //5-5 matris

            //for (int i = 1; i <= 5; i++)
            //{

            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //Çarpım tablosu

            //for (int satir  = 1; satir <=10; satir++)
            //{
            //    for (int sütun = 1; sütun <=10; sütun++)
            //    {
            //        Console.Write($"{satir*sütun}\t");
            //    }
            //    Console.WriteLine();
            //}

            //Klavyeden girilecek 3 adet sayıdan en büyük olanını bulup ekrana yazdırın

            //1.Yol

            //Console.WriteLine("ilk sayıyı giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("ikinci sayiyi giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("üçüncü sayiyiy giriniz");
            //int sayi3 = int.Parse(Console.ReadLine());
            //int enBuyukSayi = 0;
            //if (sayi1 > sayi2 && sayi2>sayi3)
            //{
            //    enBuyukSayi = sayi1;
            //}
            //else if (sayi2>sayi1 && sayi2>sayi3)
            //{
            //    enBuyukSayi = sayi2;

            //}
            //else if (sayi3>sayi1 && sayi3>sayi2)
            //{
            //    enBuyukSayi = sayi3;
            //}
            //Console.WriteLine(enBuyukSayi);

            //2.Yol
            int enByk = 0;         
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Sayi giriniz");
                int girilenSayi = int.Parse(Console.ReadLine());
                if (girilenSayi>enByk)
                {
                    enByk = girilenSayi;
                }
            }
            Console.WriteLine($"En büyük:   { enByk}");



            Console.ReadLine();
        }
    }
}
