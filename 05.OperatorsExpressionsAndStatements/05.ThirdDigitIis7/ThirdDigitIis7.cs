using System;

namespace _05.ThirdDigitIis7
{
    class ThirdDigitIis7
    {
        static void Main()
        {
            Console.WriteLine("Enter integer number to check if the third digit is 7: ");
            //first variant
            int number = int.Parse(Console.ReadLine());
            int pathToDigit = number / 100;
            int thirdDigit = pathToDigit % 10;
            bool isSeven = thirdDigit == 7;
            Console.WriteLine(isSeven);

            //second variant
            //string number = Console.ReadLine();
            //{
            //    int index = number.Length - 3;
            //    if (number[index] == '7')
            //    {
            //        Console.WriteLine(true);
            //    }
            //    else
            //    {
            //        Console.WriteLine(false);
            //    }
            //}
        }
    }
}
