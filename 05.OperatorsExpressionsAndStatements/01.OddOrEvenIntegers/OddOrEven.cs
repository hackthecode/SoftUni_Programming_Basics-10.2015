using System;

namespace _01.OddOrEvenIntegers
{
    class OddOrEven
    {
        static void Main()
        {
            Console.Write("Enter integer number and check whether it is odd or even: ");
            int number = int.Parse(Console.ReadLine());
            bool isOdd = number % 2 != 0;
            Console.WriteLine(isOdd);
        }
    }
}
