using System;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.Write("Enter positive integer number n (n <= 100): ");
            int number = int.Parse(Console.ReadLine());
            bool isItPrime = false;
            if (number > 1 && number <= 100)
            {
                if (number == 2 || number == 3 || number == 5 || number == 7)
                {
                    isItPrime = true;
                }
                else if (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
                {
                    isItPrime = true;
                }
            }
            Console.WriteLine(isItPrime);
        }
    }
}
