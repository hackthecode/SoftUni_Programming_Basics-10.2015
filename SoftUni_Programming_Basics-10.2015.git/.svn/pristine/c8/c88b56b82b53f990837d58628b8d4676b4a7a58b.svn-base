using System;

namespace _10.FibonaciNumbers
{
    class FibonaciNumbers
    {
        static void Main()
        {
            Console.Write("Enter integer number n (from 0 to 100): ");
            decimal n = decimal.Parse(Console.ReadLine());

            decimal previous = -1;
            decimal next = 1;

            for (decimal i = 0; i < n; i++)
            {
                decimal sum = next + previous;
                previous = next;
                next = sum;
                Console.Write(next + " ");
            }

            Console.WriteLine();
        }
    }
}
