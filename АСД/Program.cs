namespace АСД
{
    class Program
    {
        static void Main()
        {
            DynamicArray array = new DynamicArray();

            array.Add(10);
            array.Add(20);
            array.Add(30);
            array.Add(40);
            array.Add(50);

            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
