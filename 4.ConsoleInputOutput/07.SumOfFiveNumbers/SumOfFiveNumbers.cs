using System;

namespace _07.SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main()
        {
            Console.Write("Please enter 5 numbers divided by space:");
            string[] input = Console.ReadLine().Split(' ');
            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                double n = double.Parse(input[i]);
                sum += n;
            }
            Console.WriteLine("sum: {0}",sum);
        }
    }
}
