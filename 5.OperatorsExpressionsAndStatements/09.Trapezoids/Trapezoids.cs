using System;

namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Trapezoid's sides: ");
            Console.Write("   a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("   b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("   height = ");
            double height = double.Parse(Console.ReadLine());
            //useful info https://www.mathsisfun.com/geometry/trapezoid.html
            Console.WriteLine("\nTrapezoid area is: {0}", (a + b) / 2 * height);
        }
    }
}
