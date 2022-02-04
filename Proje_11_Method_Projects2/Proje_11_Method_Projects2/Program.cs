using System;

namespace Proje_11_Method_Projects2
{
    class Program
    {

        //dairenin yarıçapına girgidinde alan bulacak ama pi sayısı 3 veya 3.14 de alınabilecek
        static int BuyukBul(int [] sayilar)
        {
            int enb = 0;
            for (int i = 0; i <sayilar.Length ; i++)
            {
                if (sayilar[i]>enb)
                {
                    enb = sayilar[i];
                }
            }
            return enb;
            
        }
        static void Main(string[] args)
        {
            int[] sayilar = { 15, 76,8989,898988,98979789,78979,78978978 };
            int buyuk = BuyukBul(sayilar);
            Console.WriteLine(buyuk);
            Console.ReadLine();
            
        }
    }
}
