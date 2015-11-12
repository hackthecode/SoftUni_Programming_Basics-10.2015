using System;

namespace _08.NumbersFrom1toN
{
    class NumbersFrom1toN
    {
        static void Main()
        {
            Console.Write("Enter integer number n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
