using System;

namespace _13.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine();
            string binaryNumber = Console.ReadLine();

            int number = 0;
            int powerOfN = 1;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                int signN = binaryNumber[i] - 48;
                if (signN == 1)
                {
                    number += signN * powerOfN;
                }
                powerOfN *= 2;
            }
            Console.WriteLine(number);
        }
    }
}
