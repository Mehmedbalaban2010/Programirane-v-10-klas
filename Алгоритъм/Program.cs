using System;
using System.Diagnostics;
using System.Linq;

namespace Алгоритъм
{
    class Program
    {
        static void Main()
        {
            const int size = 5_000_000;

            int[] numbers = new int[size];

            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(1, 100);
            }

            Stopwatch stopwatch = Stopwatch.StartNew();

            long sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average1 = (double)sum / numbers.Length;

            stopwatch.Stop();
            long timeLoop = stopwatch.ElapsedTicks;

            stopwatch.Restart();

            double average2 = numbers.Average();

            stopwatch.Stop();

            long timeAverage = stopwatch.ElapsedTicks;
          
            Console.WriteLine($"Средно със собствен цикъл: {average1}");

            Console.WriteLine($"Време със собствен цикъл: {timeLoop} ticks");

            Console.WriteLine();

            Console.WriteLine($"Средно с Average(): {average2}");
            Console.WriteLine($"Време с Average(): {timeAverage} ticks");
        }
    }
}
