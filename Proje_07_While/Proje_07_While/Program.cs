using System;

namespace Proje_07_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 1;
            //int toplam = 0;
            //while (sayi <= 5)
            //{

            //    Console.WriteLine(sayi);
            //    toplam = toplam + sayi;
            //    sayi++;


            //}
            //Console.WriteLine($"Toplamları      :{toplam}");


            //string girilecek = null;
            //while (girilecek!="exit")
            //{
            //    Console.WriteLine("Hello World");
            //    girilecek = Console.ReadLine();

            //}

            //string girilecek = "";
            //do
            //{
            //    Console.WriteLine("Hello World");
            //    girilecek = Console.ReadLine();
            //} while (girilecek!="exit");

            //string kullaniciAdi ="";
            //int KullaniciSifre;
            //do
            //{
            //    Console.WriteLine("Kullanici Adi Giriniz");
            //     kullaniciAdi= Console.ReadLine();
            //    Console.WriteLine("Sifre giriniz");
            //     KullaniciSifre = int.Parse(Console.ReadLine());
            //    if (kullaniciAdi != "admin" || KullaniciSifre != 123)
            //    {
            //        Console.WriteLine("Hatali Giris!!");
            //    }
            //    Console.ReadLine();
            //    Console.Clear();
            //} while (kullaniciAdi!="admin" || KullaniciSifre!=123);;
            //Console.WriteLine("Hosgeldiniz");

            //string userName = "admin";
            //string pass = "123";
            //string gUserName;
            //string gPass;
            //bool durum = false;

            //do
            //{
            //    if (durum)
            //    {
            //        Console.WriteLine("Hatali Kullanici Girisi");
            //        Console.ReadLine();
            //        Console.Clear();
            //    }
            //    Console.WriteLine("Kullanici Adi: ");
            //    gUserName = Console.ReadLine();
            //    Console.WriteLine("Sifre:         ");
            //    gPass = Console.ReadLine();
            //    durum = true;

            //} while (gUserName!=userName || gPass!=pass);
            //Console.WriteLine("Basarılı Giris");


            //klaveyeden ard arda sayı girişi yapılmasını sağlayan ve girilen sayıların toplamı
            //1000 i geçene kadar yada 10 adet sayı girilene kadar girilmesine devam eden ve sonunda toplamı ekrana
            //yazan program
            int sayi = 0;
            int sayac = 0;
            int toplam = 0;
            do
            {
                sayac++;
                Console.WriteLine($"{sayac}. sayiyi giriniz");
                sayi = int.Parse(Console.ReadLine());
                toplam += sayi;


            } while (sayac<=10 && toplam <=1000);

            Console.WriteLine($"Toplam: {toplam}");
            Console.WriteLine($"Sayi adedi: {sayac}");
            Console.ReadLine();
            
           



            Console.ReadLine();
        }

    }
}
