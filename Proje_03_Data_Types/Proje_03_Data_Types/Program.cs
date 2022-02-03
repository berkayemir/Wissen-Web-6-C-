using System;

namespace Proje_03_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------VERİ TİPLERİ---------");
            Console.WriteLine("A) Tamsayilar");
            Console.WriteLine("a) İşaretsiz Tamsayılar");

            Console.WriteLine("1) byte:");
            Console.WriteLine($"Minimum Değer: {Byte.MinValue}");
            Console.WriteLine($"Maximum Değer: {Byte.MaxValue}");
            Console.WriteLine($"Belekteki Boyutu: {sizeof(Byte)} byte");

            //Console.ReadLine();

            Console.WriteLine("2) ushort:");
            Console.WriteLine($"Miniumum Değer: {ushort.MinValue}");
            Console.WriteLine($"Maximum Değer: {ushort.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(ushort)} byte");

            //Console.ReadLine();

            Console.WriteLine("3) uint:");
            Console.WriteLine($"Miniumum Değer: {uint.MinValue}");
            Console.WriteLine($"Maximum Değer: {uint.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(uint)} byte");

            //Console.ReadLine();

            Console.WriteLine("4) ulong:");
            Console.WriteLine($"Miniumum Değer: {ulong.MinValue}");
            Console.WriteLine($"Maximum Değer: {ulong.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(ulong)} byte");

            //Console.ReadLine();

            Console.WriteLine("b) İşaretli Tamsayılar");
            Console.WriteLine("1) sbyte:");
            Console.WriteLine($"Miniumum Değer: {sbyte.MinValue}");
            Console.WriteLine($"Maximum Değer: {sbyte.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(sbyte)} byte");

            //Console.ReadLine();

            Console.WriteLine("2) short:");
            Console.WriteLine($"Miniumum Değer: {short.MinValue:0,00}");
            Console.WriteLine($"Maximum Değer: {short.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(short)} byte");

            //Console.ReadLine();

            Console.WriteLine("3) int:");
            Console.WriteLine($"Miniumum Değer: {int.MinValue:0,00}");
            Console.WriteLine($"Maximum Değer: {int.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(int)} byte");

            //Console.ReadLine();

            Console.WriteLine("4) long:");
            Console.WriteLine($"Miniumum Değer: {long.MinValue:0,00}");
            Console.WriteLine($"Maximum Değer: {long.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(long)} byte");

            //Console.ReadLine();

            Console.WriteLine("B) Ondalıklı sayılar(Decimal)");

            Console.WriteLine("1) float");
            Console.WriteLine($"Minimum Değer: {float.MinValue}");
            Console.WriteLine($"Maximum Değer: {float.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(float)} byte" );

            //Console.ReadLine();

            Console.WriteLine("2) double");
            Console.WriteLine($"Minimum Değer: {double.MinValue}");
            Console.WriteLine($"Maximum Değer: {double.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(double)} byte");

            //Console.ReadLine();

            Console.WriteLine("3) decimal");
            Console.WriteLine($"Minimum Değer: {decimal.MinValue:0,00}");
            Console.WriteLine($"Maximum Değer: {decimal.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(decimal)} byte");

            //Console.ReadLine();

            Console.WriteLine("C) Karakter(Char) Veri Tipi");

            Console.WriteLine("1) char");
            Console.WriteLine($"Minimum Değer: {(int)char.MinValue}");
            Console.WriteLine($"Maximum Değer: {(int)char.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(char)} byte");
            char cevap = 'B';

            //Console.ReadLine();

            Console.WriteLine("D) Mantıksal Veri Tipi");
            Console.WriteLine("1) bool");
            Console.WriteLine($"Minimum Değer : {true}");
            Console.WriteLine($"Maximum Değer : {false}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(bool)} byte");

            Console.ReadLine();

            Console.WriteLine("E) Tarih Veri Tipi");
            Console.WriteLine("1) DateTime ");
            Console.WriteLine($"Minimum Değer : {DateTime.MinValue}");
            Console.WriteLine($"Maximum Değer : {DateTime.MaxValue}");

            unsafe { 
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(DateTime)} byte");
                }

            Console.ReadLine();




        }
    }
}
