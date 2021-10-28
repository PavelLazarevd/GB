using System;
using System.Threading;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            DoFizzBuzz();
        }
        static void DoFizzBuzz()
        {
            int time = DateTime.Now.Millisecond;
            String OutPut = "";
            String Full = "{0}\n{1}\nFizz\n{2}\nBuzz\nFizz\n{3}\n{4}\nFizz\nBuzz\n{5}\nFizz\n{6}\n{7}\nFizz Buzz\n";
            String Half = "{0}\n{1}\nFizz\n{2}\nBuzz\nFizz\n{3}\n{4}\nFizz\nBuzz\n";

            for (int i = 1; i <= 100; i += 15)
                OutPut += String.Format(i < 90 ? Full : Half, i, i + 1, i + 3, i + 6, i + 7, i + 10, i + 12, i + 13);
            Console.WriteLine(OutPut);
            Console.WriteLine(String.Format("Сделано за : {0} Милисикунды",DateTime.Now.Millisecond - time));

        }
    }
}
