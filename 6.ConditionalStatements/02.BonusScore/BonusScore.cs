using System;

namespace _02.BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            Console.Write("Enter integer nubmer in range [1-9]: ");
            int score = int.Parse(Console.ReadLine());

            if (score > 0 && score < 4)
            {
                Console.WriteLine(score * 10);
            }
            if (score > 3 && score < 7)
            {
                Console.WriteLine(score * 100);
            }
            if (score > 6 && score < 10)
            {
                Console.WriteLine(score * 1000);
            }
            if (score < 1 || score >= 10)
            {
                Console.WriteLine("ivalid score");
            }
        }
    }
}
