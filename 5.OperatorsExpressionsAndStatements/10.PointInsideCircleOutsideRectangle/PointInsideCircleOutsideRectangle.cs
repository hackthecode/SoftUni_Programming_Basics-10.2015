﻿using System;

namespace _10.PointInsideCircleOutsideRectangle
{
    class PointInsideCircleOutsideRectangle
    {
        static void Main()
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());

            if ((Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow(1.5, 2))
                && (x <= 2.5 && x >= -0.5) && (y <= 2.5 && y > 1))
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
