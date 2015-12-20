using System;

namespace _01.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Enter number \"n\" to get the Nth fibonacci number: ");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Fib(n) = {0}", Fib(n));
        }
        static ulong Fib(ulong n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}   