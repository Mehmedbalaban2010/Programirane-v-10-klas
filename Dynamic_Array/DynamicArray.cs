using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class DynamicArray
    {
        private int[] data = new int[4];

        public int Count { get; private set; }

        public int Capacity { get => data.Length; }

        public void Add(int element)
        {
            if (Count == data.Length)
            {
                Resize(data.Length * 2);
            }

            data[Count++] = element;
        }

        private void Resize(int newCapacity)
        {
            int[] bigger = new int[newCapacity];

            for (int i = 0; i < Count; i++)
            {
                bigger[i] = data[i];
            }

            data = bigger;
        }
    }
}
