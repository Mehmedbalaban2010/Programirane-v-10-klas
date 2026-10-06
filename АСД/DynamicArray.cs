using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АСД
{
    class DynamicArray
    {
        private int[] data = new int[4];

        public int Count { get; private set; }

        public void Add(int value)
        {

            if (Count == data.Length) Resize(data.Length * 2);

            data[Count++] = value;

        }

        private void Resize(int newCapacity)
        {

            int[] bigger = new int[newCapacity];

            for (int i = 0; i < Count; i++) bigger[i] = data[i];

            data = bigger;

        }

        public int this[int i] => data[i]; // достъп по индекс
    }
}
