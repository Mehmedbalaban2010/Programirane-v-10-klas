using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("zad1");

            LinkedList<string> tasks = new LinkedList<string>();

            tasks.AddFirst("Написване на домашно");

            tasks.AddLast("Подготовка за контролно");

            tasks.AddLast("Проект по програмиране");

            tasks.AddLast("Прочитане на урока");

            foreach (var item in tasks)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            string search = Console.ReadLine();

            bool found = false;

            foreach (var item in tasks)
            {
                if (search == item)
                {
                    Console.WriteLine("The task is found");

                    found = true;

                    break;
                }
            }

            if (found == false)
            {
                Console.WriteLine("Not found!");
            }

            Console.WriteLine();

            Console.Write("Enter the dask to delete: ");

            string deleteTask = Console.ReadLine();

            tasks.Remove(deleteTask);

            Console.WriteLine();

            Console.WriteLine("Tasks after deleted task");

            foreach (var item in tasks)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("First task: " + tasks.First());

            Console.WriteLine("Last task: " + tasks.Last());

            Console.WriteLine();

            Console.WriteLine("zad2");

            LinkedListNode<string> myNode1 = tasks.Find("Написване на домашно");

            tasks.AddAfter(myNode1, "Домашно");

            foreach (var item in tasks)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            LinkedListNode<string> myNode2 = tasks.Find("Домашно");

            tasks.AddAfter(myNode2, "Упражнение");

            foreach (var item in tasks)
            {
                Console.WriteLine(item);
            }
        }
    }
}