using System;

namespace List
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();

            Console.Write("Въведете дължина на списъка: ");

            int length;

            int attempts = 4;

            while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
            {
                attempts--;

                if (attempts >= 2)
                {
                    Console.WriteLine($"Имате оставащи {attempts} опита!");
                }
                else if (attempts == 1)
                {
                    Console.WriteLine($"Имате оставащи {attempts} опит!");
                }
                else
                {
                    Console.WriteLine("Нямате повече опити!");

                    return;
                }

                Console.Write("Моля, въведете число: ");
            }

            Console.WriteLine();

            AddNumbers(numbers, length);
        }
        static void AddNumbers(List<int> numbers, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведете число: ");

                int attempts = 4;

                int number;

                while (!int.TryParse(Console.ReadLine(), out number) || numbers.Contains(number))
                {
                    attempts--;

                    if (attempts >= 2)
                    {
                        Console.WriteLine($"Имате оставащи {attempts} опита!");
                    }
                    else if (attempts == 1)
                    {
                        Console.WriteLine($"Имате оставащи {attempts} опит!");
                    }
                    else
                    {
                        Console.WriteLine("Нямате повече опити!");

                        return;
                    }

                    Console.Write("Моля, въведете число: ");
                }

                numbers.Add(number);
            }

            Console.WriteLine("Числата, записани в списъка: " + string.Join(", ", numbers));
        }
    }
}
