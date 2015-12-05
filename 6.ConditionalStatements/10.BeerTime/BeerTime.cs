using System;
using System.Globalization;

namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            Console.WriteLine("A beer time is after 1:00 PM and before 3:00 AM.");
            Console.WriteLine("Enter a time in format \"hh:mm tt\" (example: \"10:57 PM\" or \"02:59 AM\")");
            Console.Write("Time: ");
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime time;
            DateTime startTime = DateTime.Parse("12:59 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");
            string dateString = Console.ReadLine();
            if (DateTime.TryParseExact(dateString, "h:mm tt", enUS, DateTimeStyles.None, out time))
            {
                if (time > startTime || time < endTime)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        }
    }
}