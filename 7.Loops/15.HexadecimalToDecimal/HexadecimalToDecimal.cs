using System;

namespace _15.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main()
        {
            string hexadecimalNum = Console.ReadLine();
            long number = 0;
            long power = 1;

            for (int i = hexadecimalNum.Length - 1; i >= 0; i--)
            {
                int letters;
                switch (hexadecimalNum[i])
                {
                    case 'A':
                        letters = 10;
                        break;
                    case 'B':
                        letters = 11;
                        break;
                    case 'C':
                        letters = 12;
                        break;
                    case 'D':
                        letters = 13;
                        break;
                    case 'E':
                        letters = 14;
                        break;
                    case 'F':
                        letters = 15;
                        break;
                    default:
                        letters = hexadecimalNum[i] - 48;
                        break;
                }
                number += letters * power;
                power *= 16;
            }
            Console.WriteLine(number);
        }
    }
}