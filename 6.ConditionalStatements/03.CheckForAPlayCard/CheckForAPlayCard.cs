using System;

namespace _03.CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main()
        {
            Console.Write("Enter the card: ");
            string CheckCard = Console.ReadLine();

            if (CheckCard == "2" ||
                CheckCard == "3" ||
                CheckCard == "4" ||
                CheckCard == "5" ||
                CheckCard == "6" ||
                CheckCard == "7" ||
                CheckCard == "8" ||
                CheckCard == "9" ||
                CheckCard == "10" ||
                CheckCard == "J" ||
                CheckCard == "Q" ||
                CheckCard == "K" ||
                CheckCard == "A")
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
