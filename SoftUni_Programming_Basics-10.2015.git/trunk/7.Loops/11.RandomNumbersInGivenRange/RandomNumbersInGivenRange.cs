using System;

namespace _11.RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.Write("Please enter n : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter min border : ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Please enter max border : ");
            int max = int.Parse(Console.ReadLine());
            if (max == min)
            {
                Console.WriteLine("Please enter new max value != min : ");
                max = int.Parse(Console.ReadLine());
            }

            Random num = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", num.Next(min, max + 1));
            }
        }
    }
}
