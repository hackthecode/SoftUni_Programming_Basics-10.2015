using System;

namespace _04.NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Compare two numbers.\n");
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            double greater = Math.Max(a, b);
            Console.WriteLine("Greater is: {0}", greater);
        }
    }
}
