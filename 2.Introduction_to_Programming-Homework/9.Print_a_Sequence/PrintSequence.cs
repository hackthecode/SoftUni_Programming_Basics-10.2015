using System;

class PrintSequence
{
    static void Main()
    {
        int count = 10;
        for (int i = 2; i <= count + 1; i++)
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

