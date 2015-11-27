using System;

namespace _1.ExchangeifGreater
{
    class ExchangeifGreater
    {
        static void Main()
        {
            Console.Write("a: ");
            double integerA = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double integerB = double.Parse(Console.ReadLine());

            if (integerA > integerB)
            {
                Console.WriteLine("result: {0} {1}", integerB, integerA);
            }
            else
            {
                Console.WriteLine("result: {0} {1}", integerA, integerB);
            }
        }
    }
}
