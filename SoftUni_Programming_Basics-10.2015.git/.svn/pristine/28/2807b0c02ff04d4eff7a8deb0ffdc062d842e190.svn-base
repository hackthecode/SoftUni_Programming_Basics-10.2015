using System;

namespace _10.PointInsideCircleOutsideRectangle
{
    internal class PointInsideCircleOutsideRectangle
    {
        private static void Main()
        {
            Console.Write("x=");
            decimal pointX = Decimal.Parse(Console.ReadLine());
            Console.Write("y=");
            decimal pointY = Decimal.Parse(Console.ReadLine());
            decimal radius = 1.5m;

            bool isInCircle = (pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1) <= radius * radius;

            if (isInCircle && pointY > 1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}