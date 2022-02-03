using System;

namespace Proje_05_Convert_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Lütfen adınızı giriniz: ");
            //string ad = Console.ReadLine();
            //Console.WriteLine($"Merhaba {ad}!!, hosgeldin.");

            //Console.Write("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(sayi*sayi
            //

            //          Console.Write("Lutfen birinci sayıyı giriniz: ");
            //          int sayi1 = Convert.ToInt32(Console.ReadLine());
            //          Console.Write("Lutfen ikinci sayiyi giriniz: ");
            //          int sayi2 = Convert.ToInt32(Console.ReadLine());
            //          int top = sayi1 + sayi2;
            //          Console.WriteLine($"Toplam: {top}");


            //          byte b = 15;
            //;          short s = b;

            //          short s1 = 258;
            //          byte b1 = (byte)s1;

            //          Console.WriteLine($"s1-short: {s1}===> b1-byte: {b1}");



            Console.WriteLine("1.Kenarın uzunluğunu giriniz: ");
            int kenar1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.Kenarın uzunluğunu giriniz: ");
            int kenar2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Girdiğiniz değerlere göre alan: {kenar1*kenar2}");







            
            


            Console.ReadLine();
        }
    }
}
