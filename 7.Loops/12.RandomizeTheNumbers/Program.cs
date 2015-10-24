using System;

namespace _12.RandomizeTheNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            int temp, index;
            for (int i = 0; i < n; i++)
            {
                index = rnd.Next(n);
                temp = numbers[i];
                numbers[i] = numbers[index];
                numbers[index] = temp;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
