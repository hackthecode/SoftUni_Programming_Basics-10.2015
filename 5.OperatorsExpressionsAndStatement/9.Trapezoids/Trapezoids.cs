using System;

namespace _9.Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.Write("a=");
            double aSide = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double bSide = double.Parse(Console.ReadLine());
            Console.Write("h=");
            double hHeight = double.Parse(Console.ReadLine());
            //Calculate Area
            double areaTrapezoid = ((aSide + bSide) / 2) * hHeight;
            Console.WriteLine("area: {0}", areaTrapezoid);
        }
    }
}
