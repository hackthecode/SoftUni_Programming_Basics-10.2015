using System;

namespace SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            // input - 3 real numbers from user 
            Console.Write("Enter the first real number: ");
            double firtNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the second real number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the third real number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            // calculate sum of 3 real numbers
            double sum = firtNumber + secondNumber + thirdNumber;
            Console.WriteLine("sum = " + sum );
        }
    }
}
