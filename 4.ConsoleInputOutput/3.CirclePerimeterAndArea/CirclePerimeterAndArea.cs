using System;

namespace _3.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Enter the radius off the circle: ");
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double area = 2 * pi * radius;
            double perimeter = pi * radius * radius;
            Console.WriteLine("Perimeter = {0:F2}", area);
            Console.WriteLine("Area = {0:F2}", perimeter);
        }
    }
}