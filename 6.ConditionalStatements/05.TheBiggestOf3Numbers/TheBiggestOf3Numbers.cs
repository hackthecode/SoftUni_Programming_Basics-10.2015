using System;

namespace _05.TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            if (c > a && c > b)
            {
                Console.WriteLine(c);
            }

            // short variant
            // Console.WriteLine(Math.Max(Math.Max(a, b),c));
        }
    }
}
