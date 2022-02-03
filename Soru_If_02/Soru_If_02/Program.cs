using System;

namespace Soru_If_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan 2 adet sayi isteyip
             * bunların;
             * toplamını,fakını,çarpımını ve bölümünü
             * alt alta gösteren Programı yazınız
            */

            //Console.Write("Lütfen ilk sayıyı giriniz        :");
            //double sayi1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı giriniz     :");
            //double sayi2 = double.Parse(Console.ReadLine());
            //double toplam = sayi1 + sayi2;
            //double fark = sayi1 - sayi2;
            //double carpım = sayi1 * sayi2;
            //double bolum = sayi1 / sayi2;
            //Console.WriteLine($"{sayi1} + {sayi2} ={toplam}");
            //Console.WriteLine($"{sayi1} * {sayi2} ={carpım}");
            //Console.WriteLine($"{sayi1} - {sayi2} ={fark}");
            //Console.WriteLine($"{sayi1} / {sayi2} ={bolum}");


            Console.WriteLine("Lütfen yapmak istediginiz islemi seçiniz:");
            Console.WriteLine("1)Toplama");
            Console.WriteLine("2)Cıkarma");
            Console.WriteLine("3)Carpma");
            Console.WriteLine("4)Bolme");
            int islemSecimi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen ilk sayiyi giriniz        :");
            double sayi1 = double.Parse(Console.ReadLine());
            Console.Write("Lütfen ikinci sayiyi giriniz        :");
            double sayi2 = double.Parse(Console.ReadLine());
            double islem = 0;
            string islemAdi = " ";
            string islemKarakteri = null;
            string islemKarakteri1="+";
            string islemKarakteri2 = "-";
            string islemKarakteri3 = "*";
            string islemKarakteri4 = "/";

            if (islemSecimi==1)
            {
                islem = sayi1+sayi2;
                islemKarakteri = islemKarakteri1;
                islemAdi = "Toplama";
            }
            else if (islemSecimi==2)
            {
                islem = sayi1-sayi2;
                islemKarakteri = islemKarakteri2;
                islemAdi = "Cıkarma";

            }
            else if (islemSecimi==3)
            {
                islem = sayi1* sayi2;
                islemKarakteri = islemKarakteri3;
                islemAdi = "Carpma";

            }
            else if (islemSecimi==4)
            {
                islem = sayi1/ sayi2;
                islemKarakteri = islemKarakteri4;
                islemAdi = "Bolme";

            }

            Console.WriteLine($"{islemAdi} islemeniz >>>>>>  {sayi1} {islemKarakteri} {sayi2}={islem}");


            Console.ReadLine();



        }
    }
}
