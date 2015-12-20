using System;

namespace _07.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            for (int hight = 0; hight < row; hight++)
            {
                for (int width = 0; width < col; width++)
                {
                    Console.Write("{0}{1}{0} ", (char)('a' + hight), (char)('a' + hight + width));
                }
                Console.WriteLine();
            }

        }
    }
}
