using System;

namespace _03.MinMaxSumAverageNumbers
{
    class MinMaxSumAverageNumbers
    {
        static void Main()
        {
            Console.WriteLine("How many numbers to be compared?");
            int n = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            double sumNumber = 0;
            double avgNumber = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the number: ");
                int number = int.Parse(Console.ReadLine());
                //min
                minNumber = Math.Min(minNumber, number);
                //max
                maxNumber = Math.Max(maxNumber, number);
                //sum
                sumNumber += number;
                //avg
                avgNumber = sumNumber / n;
            }
            Console.WriteLine("Min = {0}", minNumber);
            Console.WriteLine("Max = {0}", maxNumber);
            Console.WriteLine("Sum = {0}", sumNumber);
            Console.WriteLine("Avg = {0:F2}", avgNumber);
        }
    }
}
