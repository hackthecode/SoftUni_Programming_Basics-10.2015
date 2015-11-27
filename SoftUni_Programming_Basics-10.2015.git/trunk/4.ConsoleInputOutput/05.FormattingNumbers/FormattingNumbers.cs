using System;

namespace _05.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("Enter first (integer) number - (values 0 ≤ number ≤ 500): ");
            int intNumber = int.Parse(Console.ReadLine());
            while (intNumber < 0 || intNumber > 500) //Check number is valid
            {
                Console.WriteLine("Invalid input! Try again!");
                Console.Write("Enter first (integer) number - (values 0 ≤ number ≤ 500): ");
                intNumber = int.Parse(Console.ReadLine());
            };
            Console.Write("Enter second (floating-point) number: ");
            double floatingPointA = double.Parse(Console.ReadLine());
            Console.Write("Enter third (floating-point) number ");
            double floatingPointB = double.Parse(Console.ReadLine());

            Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10:F2}|{3, -10:F3}|",
                intNumber, Convert.ToString(intNumber, 2).PadLeft(10, '0'), floatingPointA, floatingPointB);
        }
    }
}
