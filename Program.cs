namespace Programa
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
