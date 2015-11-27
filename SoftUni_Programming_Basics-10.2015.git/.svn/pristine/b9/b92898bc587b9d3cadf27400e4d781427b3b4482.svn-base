using System;

namespace _8.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Please enter your number(from 0 to 100):");
            int a = int.Parse(Console.ReadLine());
            bool isItPrime = false;
            if (a > 1 && a <= 100)
            {
                if (a == 2 || a == 3 || a == 5 || a == 7)
                {
                    isItPrime = true;
                }
                else if (a % 2 != 0 && a % 3 != 0 && a % 5 != 0 && a % 7 != 0)
                {
                    isItPrime = true;
                }
            }
            Console.WriteLine("Prime? : {0}", isItPrime);
        }
    }
}