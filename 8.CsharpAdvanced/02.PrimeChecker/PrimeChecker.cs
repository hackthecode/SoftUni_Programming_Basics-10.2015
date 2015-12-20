using System;

namespace _02.PrimeChecker
{
    class PrimeChecker
    {
        static void Main()
        {
            Console.Write("Enter a integer number > 1 to check if it's prime: ");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }
        static bool IsPrime(long n)
        {
            if (n < 2)
            {
                return false;
            }
            // Eratosthenes Algorithm  https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
            for (int i = 2; i <= Math.Sqrt(n); i++) 
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
