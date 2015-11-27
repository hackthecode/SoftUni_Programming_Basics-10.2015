using System;

namespace _01.NumberFrom1ToN
{
    class NumberFrom1ToN
    {
        static void Main()
        {
            Console.Write("Enter positive integer n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;


            while (i <= n && n > 0)
            {
                Console.Write("{0} ", i);
                i++;
            }
            Console.WriteLine();
            if (n < 1)
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
