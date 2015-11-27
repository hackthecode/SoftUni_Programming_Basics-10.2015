using System;
using System.Runtime.InteropServices;

namespace _13.ComparingFloats
{
    internal class ComparingFloats
    {
        private static void Main()
        {
            decimal eps = 0.000001m;
            Console.WriteLine("Compare two floating-point numbers with precision 0.000001\n");
            Console.Write("Enter the first floating-point number :");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the second floating-point number :");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal diff = Math.Abs((decimal)a - (decimal)b);
            if (diff < eps)
            {
                Console.WriteLine("\ntrue");
                Console.WriteLine("The difference {0} < eps", diff);
            }

            if (diff == eps)
            {
                Console.WriteLine("\nfalse");
                Console.WriteLine("Border case. The difference {0} == eps.\nWe consider the numbers are different.", diff);
            }
            if (diff > eps)
            {
                Console.WriteLine("\nfalse");
                Console.WriteLine("The difference of {0} is too big (> eps)", diff);
            }
        }
    }
}
