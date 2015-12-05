using System;

namespace _06.TheBiggestOf5Numbers
{
    class TheBiggestOf5Numbers
    {
        private static void Main()
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("e: ");
            double e = double.Parse(Console.ReadLine());

            if ((a > b && a > c) && (a > d && a > e)) //checks a
            {
                Console.WriteLine(a);
            }
            if ((b > a && b > c) && (b > d && b > e)) //checks b
            {
                Console.WriteLine(b);
            }
            if ((c > a && c > b) && (c > d && c > e)) //checks c
            {
                Console.WriteLine(c);
            }
            if ((d > a && d > b) && (d > c && d >= e)) //checks c
            {
                Console.WriteLine(d);
            }
            if ((e > a && e > b) && (e > c && e > d)) //checks e
            {
                Console.WriteLine(e);
            }
        }
    }
}