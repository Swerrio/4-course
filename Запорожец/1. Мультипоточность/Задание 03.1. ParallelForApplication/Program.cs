using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelForApplication
{
    class Program
    {
        static int Max = 1;

        static void Maxnumber(int c)
        {
            Random rnd = new Random();
            int v = rnd.Next(0, c);

            if (Max < v)
            {
                Max = v;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- Последовательный цикл for ---");

            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 1; i <= 10000000; i++)
            {
                Maxnumber(i);
            }

            long elapsed = sw.ElapsedMilliseconds;
            sw.Stop();
            Console.WriteLine("Время выполнения алгоритма в миллисекундах: {0}", elapsed);
            Console.WriteLine("Максимальное число: {0} ", Max);

            Console.WriteLine("============================");
            Console.WriteLine("--- Параллельный цикл Parallel.For ---");

            Max = 1;
            sw.Restart();

            Parallel.For(1, 10000000, i =>
            {
                Maxnumber(i);
            });

            elapsed = sw.ElapsedMilliseconds;
            sw.Stop();
            Console.WriteLine("Время выполнения алгоритма в миллисекундах: {0}", elapsed);
            Console.WriteLine("Максимальное число: {0} ", Max);

            Console.ReadLine();
        }
    }
}
