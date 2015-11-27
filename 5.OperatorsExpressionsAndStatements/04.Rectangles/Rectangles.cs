using System;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Calculates rectangle’s perimeter and area by given width and height.");
            Console.Write("Width: "); //w
            double width = Double.Parse(Console.ReadLine());
            Console.Write("Height: "); //h
            double height = Double.Parse(Console.ReadLine());

            Console.WriteLine("Perimeter: {0}", 2 * (width + height)); // Perimeter = 2 * (w + h)
            Console.WriteLine("Area: {0}", width * height); // Area = w * h
        }
    }
}
