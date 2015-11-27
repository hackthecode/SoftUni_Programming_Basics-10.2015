using System;

namespace _7.PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("y: ");
            double y = double.Parse(Console.ReadLine());
            int radiusCircle = 2;

            double pointDistance = Math.Sqrt((x * x) + (y * y));

            bool checkPoint = (pointDistance <= radiusCircle);
            if (checkPoint)
            {
                Console.WriteLine("inside: {0}", checkPoint);
            }
            else
            {
                Console.WriteLine("inside: {0}", checkPoint);
            }
        }
    }
}
