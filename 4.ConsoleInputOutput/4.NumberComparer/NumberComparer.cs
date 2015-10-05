using System;

namespace _4.NumberComparer
{
    internal class NumberComparer
    {
        private static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            // Math.Max Method  
            // https://msdn.microsoft.com/en-us/library/system.math.max(v=vs.110).aspx
            // Returns the larger of two specified numbers.
            double greater = Math.Max(a, b);
            Console.WriteLine("greater = {0}", greater);
        }
    }
}