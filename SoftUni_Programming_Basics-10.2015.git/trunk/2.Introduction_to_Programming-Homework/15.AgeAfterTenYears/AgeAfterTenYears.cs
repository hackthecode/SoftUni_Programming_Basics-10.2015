using System;

namespace _15.AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main()
        {
            Console.WriteLine("Enter your birthday in format dd.mm.yyyy");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            // 1 year = 365.242199 days
            int age = (int)((DateTime.Now - birthDay).TotalDays / 365.242199);
            Console.WriteLine("Now: " + age);
            Console.WriteLine("After 10 years: " + (age + 10));
        }
    }
}
