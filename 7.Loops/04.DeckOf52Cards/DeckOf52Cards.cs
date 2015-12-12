using System;
using System.Text;


namespace _04.DeckOf52Cards
{
    class DeckOf52Cards
    {
        static void Main()
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 2; i < 15; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    switch (i)
                    {
                        case 2: Console.Write(" 2"); break;
                        case 3: Console.Write(" 3"); break;
                        case 4: Console.Write(" 4"); break;
                        case 5: Console.Write(" 5"); break;
                        case 6: Console.Write(" 6"); break;
                        case 7: Console.Write(" 7"); break;
                        case 8: Console.Write(" 8"); break;
                        case 9: Console.Write(" 9"); break;
                        case 10: Console.Write("10"); break;
                        case 11: Console.Write(" J"); break;
                        case 12: Console.Write(" Q"); break;
                        case 13: Console.Write(" K"); break;
                        case 14: Console.Write(" A"); break;
                        default: Console.WriteLine("Card Error"); break;
                    }
                    switch (j)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("\u2663 "); //  Club
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 2: Console.Write("\u2666 "); break; //Diamond
                        case 3:
                            Console.Write("\u2665 "); // Heart
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        case 4: Console.WriteLine("\u2660 "); break; //  Spade
                        default: Console.WriteLine("Char Error"); break;
                    }
                }
            }
        }
    }
}