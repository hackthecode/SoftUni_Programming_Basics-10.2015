using System;
using System.Text;

namespace _14.DecimalToBin
{
    class DecimalToBin
    {
        static void Main()
        {
            Console.WriteLine("Please enter your number: ");
            long decimalNum = long.Parse(Console.ReadLine());
            long remainder;
            StringBuilder binary = new StringBuilder();

            while (decimalNum > 0)
            {
                int index = 0;
                remainder = decimalNum % 2;
                binary.Insert(index, remainder);

                decimalNum /= 2;
                index++;
            }
            Console.WriteLine(binary);
        }
    }
}
