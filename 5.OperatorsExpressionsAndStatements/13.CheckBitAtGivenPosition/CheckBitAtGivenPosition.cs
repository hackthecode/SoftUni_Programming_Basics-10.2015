using System;

namespace _13.CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Enter positive integer number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter bit at index p: ");
            int pposition = int.Parse(Console.ReadLine());
            bool isOne = (number & (1 << pposition)) > 0;
            Console.WriteLine(isOne);
        }
    }
}
