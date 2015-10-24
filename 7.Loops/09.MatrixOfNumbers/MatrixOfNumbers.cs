using System;

namespace _09.MatrixOfNumbers
{
    internal class MatrixOfNumbers
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = row + 1; col <= n + row; col++)
                {
                    Console.Write("{0} ", col);
                }
                Console.WriteLine();
            }
        }
    }
}
