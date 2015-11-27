using System;

namespace _14.ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Enter positive integer number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter a position to be changed: ");
            int position = int.Parse(Console.ReadLine());
            Console.Write("Enter a bit value (1 or 0): ");
            int value = int.Parse(Console.ReadLine());

            if (value == 1)
            {
                int mask = 1 << position;
                int changed = number | mask;
                Console.WriteLine(changed);
                Console.WriteLine(Convert.ToString(changed, 2).PadLeft(16, '0'));
            }
            else if (value == 0)
            {
                int mask = ~(1 << position);
                int changed = (number & mask);
                Console.WriteLine(changed);
                Console.WriteLine(Convert.ToString(changed, 2).PadLeft(16, '0'));
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
