using System;

namespace _5.ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer number:");
            int number = int.Parse(Console.ReadLine());
            int pathToDigit = number / 100;
            int thirdDigit = pathToDigit % 10;
            bool isSeven = thirdDigit == 7;
            Console.WriteLine(isSeven);
        }
    }
}
