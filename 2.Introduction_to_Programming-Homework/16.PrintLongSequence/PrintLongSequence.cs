using System;

namespace _16.PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int count = 1000;
            for (int i = 2; i <= 1001; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(-i);
                }
                if (i != count + 1)
                {
                    Console.Write(",");
                }
            }
        }
    }
}
