using System;

namespace _3.DivideBy7and5
{
    class DivideBy7and5
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            // we use the least common multiple to get the correct result for zero.
            bool isDivisible = number % 35 == 0 && number != 0;
            Console.WriteLine(isDivisible);
        }
    }
}
