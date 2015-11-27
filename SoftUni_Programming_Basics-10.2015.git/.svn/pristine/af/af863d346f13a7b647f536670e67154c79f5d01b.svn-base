using System;

namespace _06.CalculateFactorials
{
    class CalculateFactorials
    {
        static void Main()
        {
            Console.Write("n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k:");
            int k = int.Parse(Console.ReadLine());

            int result = 1;
            if (k >= n || n <= 1 || k <= 1 || n > 100)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("n!/k! = {0}", result);

        }
    }
}
