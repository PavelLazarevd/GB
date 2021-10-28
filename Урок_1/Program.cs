using System;

namespace Урок_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Напиши мне своё имя");
                String Name = Console.ReadLine();
                Console.WriteLine(String.Format("«Привет, {0}, сегодня {1:d}»", Name, DateTime.Now)); //
            }
        }
    }
}
