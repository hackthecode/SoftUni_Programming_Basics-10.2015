using System;

namespace _2.BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            Console.Write("Enter integer nubmer in range [1-9]: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0 && number < 4)
            {
                Console.WriteLine(number * 10);
            }
            if (number > 3 && number < 7)
            {
                Console.WriteLine(number * 100);
            }
            if (number > 6 && number < 10)
            {
                Console.WriteLine(number * 1000);
            }
            if (number < 1 || number >= 10)
            {
                Console.WriteLine("ivalid score");
            }
        }
    }
}
