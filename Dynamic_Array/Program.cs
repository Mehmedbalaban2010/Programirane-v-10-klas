using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main()
        {
            DynamicArray dynamic = new DynamicArray();

            Console.WriteLine($"Динамичният има {dynamic.Count} елемента и готовност за {dynamic.Capacity} елемента общо.");
        }
    }
}