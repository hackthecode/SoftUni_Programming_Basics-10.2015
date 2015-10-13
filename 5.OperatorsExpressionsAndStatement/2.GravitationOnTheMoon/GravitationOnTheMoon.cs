using System;

namespace _2.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.WriteLine("Enter weight of a man:");
            double weightMan = double.Parse(Console.ReadLine());
            Console.WriteLine("Weight of a man on the moon is: {0}", 17 * weightMan / 100);
        }
    }
}
