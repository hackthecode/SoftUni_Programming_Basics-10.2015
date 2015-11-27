using System;

namespace _03.DivideBy7and5
{
    class DivideBy7and5
    {
        static void Main()
        {
            Console.WriteLine("Checks for given integer if it can be divided (without remainder) by 7 and 5 ");
            Console.Write("Enter integer number: ");
            int number = int.Parse(Console.ReadLine());
            // Least Common Multiple of 7 and 5 = 35
            bool boolNumber = (number % 35 == 0 && number != 0);
            Console.WriteLine(boolNumber);
        }
    }
}
