using System;

namespace _12.ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("Enter positive integer number: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.Write("Enter bit at index p: ");
            int position = int.Parse(Console.ReadLine());
            Console.Write("Binary representation: ");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

            uint bitMask = 1;

            Console.WriteLine((bitMask << position & number) == 0 ? "bit @ p: 0" : "bit @ p: 1");
        }
    }
}
