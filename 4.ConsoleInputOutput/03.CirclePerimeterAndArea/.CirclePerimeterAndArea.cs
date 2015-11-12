using System;

namespace _03.CirclePerimeterAndArea
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter radius:");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("perimeter {0:F2}", 2 * Math.PI * radius);
            Console.WriteLine("area {0:F2}", Math.PI * Math.Pow(radius, 2));
        }
    }
}
