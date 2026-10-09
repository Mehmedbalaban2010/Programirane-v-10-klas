using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Трябва да въведете число в десетичен вид, за да го конвертирате в двоична, осмична или шестнадесетична система.");

            Console.WriteLine("Моля, въведете число в десетичен вид (например: 10, 255, 1024):");

            Console.Write("Въведете вашето число: ");

            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Програмата спря...");

                return;
            }
         
            Console.WriteLine("Добре дошли в менюто за конвертиране на число!");

            Console.WriteLine("1. Десетично към двоично");

            Console.WriteLine("2. Десетично към осмично");

            Console.WriteLine("3. Десетично към шестнадесетично");

            Console.Write("Изберете опция (1-3): ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine($"Двоично представяне на {number}: {Convert.ToString(number, 2)}");
                    break;
                case 2:
                    Console.WriteLine($"Осмично представяне на {number}: {Convert.ToString(number, 8)}");
                    break;
                case 3:
                    Console.WriteLine($"Шестнадесетично представяне на {number}: {Convert.ToString(number, 16).ToUpper()}");
                    break;
                default:
                    Console.WriteLine("Невалидна опция. Моля, изберете между 1 и 3.");
                    break;
            }
        }
    }
}
