using System;
using System.Collections.Generic;

namespace Linked_List
{
    class Program
    {
        static void Main()
        {
            LinkedList<string> playlist = new LinkedList<string>();

            playlist.AddFirst("Родопска песен");
            playlist.AddLast("Полегнала е Тодора");
            playlist.AddLast("Моя страна, моя България");
            playlist.AddLast("Девойко мари");

            Console.WriteLine("--- Плейлистът съдържа следните песни: ---");

            foreach (var item in playlist)
            {
                Console.WriteLine(item);
            }

            AddingElement(playlist);
        }

        static void AddingElement(LinkedList<string> playlist)
        {
            LinkedListNode<string> node = playlist.Find("Полегнала е Тодора");

            playlist.AddAfter(node, "Хубава си, моя горо");

            Console.WriteLine();

            Console.WriteLine("--- Плейлистът след добавянето на песента 'Хубава си, моя горо': ---");

            foreach (var item in playlist)
            {
                Console.WriteLine(item);
            }

            DeletingElement(playlist);
        }

        static void DeletingElement(LinkedList<string> playlist)
        {
            Console.WriteLine();

            Console.Write("Въведете името на песента, която искате да изтриете: ");

            string songToDelete = Console.ReadLine().Trim();

            LinkedListNode<string> node = playlist.Find(songToDelete);

            if (node != null)
            {
                playlist.Remove(node);

                Console.WriteLine($"--- Плейлистът след изтриването на песента '{songToDelete}': ---");

                foreach (var item in playlist)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine($"Песента '{songToDelete}' не беше намерена в плейлиста.");
            }
        }
    }
}