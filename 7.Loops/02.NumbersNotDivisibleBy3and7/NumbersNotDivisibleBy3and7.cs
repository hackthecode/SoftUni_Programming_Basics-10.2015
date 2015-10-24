using System;

namespace _02.NumbersNotDivisibleBy3and7
{
    class NumbersNotDivisibleBy3and7
    {
        static void Main()
        {
            Console.WriteLine("Please enter you number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if ((i % 3 == 0) || (i % 7 == 0))
                {

                }
                else
                {
                    Console.Write("{0} ", i);
                }


            }
            Console.WriteLine();
        }
    }
}
