using System;

namespace Proje_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var message2 = "Berkay";
            var message3 = "Emir";
            Console.Write(message2);
            Console.WriteLine(" " + message3);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            var message = "Web-6 Grubu";
            Console.WriteLine(message);
            Console.Title="Bu bizim ilk konsol uygulamamız!";
            Console.ReadLine();
        }
    }
}
