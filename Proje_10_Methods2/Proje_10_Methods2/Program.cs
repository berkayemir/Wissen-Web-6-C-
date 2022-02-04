using System;

namespace Proje_10_Methods2
{
    class Program
    {
        static int Topla(int number1, int number2, int number3)
        {
            int sonuc = number1 + number2 + number3;
            return sonuc;
        }
        static int Topla(int number1, int number2)
        {
            int sonuc = number1 + number2;
            return sonuc;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(Topla(56,112));
            Console.WriteLine(Topla(452,69,110));

        }
    }
}
