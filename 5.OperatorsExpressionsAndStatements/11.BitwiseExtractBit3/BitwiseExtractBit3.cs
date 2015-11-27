using System;

namespace _11.BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.Write("Enter positive integer number: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.Write("Binary representation: ");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

            uint bitMask = 1;

            Console.WriteLine((bitMask << 3 & number) == 0 ? "bit #3 is: 0" : "bit #3 is: 1");
        }
    }
}
