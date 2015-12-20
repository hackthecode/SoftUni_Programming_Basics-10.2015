using System;

namespace _04.DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main()
        {
            Console.Write("First date (in format dd.MM.yyyy): ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Second date (in format dd.MM.yyyy): ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            
            double diffrent = ((secondDate.Date - firstDate.Date).TotalDays);

            Console.WriteLine("Days between: {0}",diffrent);


        }
    }
}
