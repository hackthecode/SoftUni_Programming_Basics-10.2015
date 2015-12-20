using System;

namespace _05.SortingNumbers
{
    class SortingNumbers
    {
        static void Main()
        {
            Console.Write("How many numbers to be compared?: ");
            int range = int.Parse(Console.ReadLine());
            int[] values = new int[range];

            for (int i = 0; i < range; i++)
            {
                Console.Write("number[{0}]: ", i + 1);
                values[i] = int.Parse(Console.ReadLine());
            }

            Array array = values;
            Array.Sort(array);
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
        }
    }
}