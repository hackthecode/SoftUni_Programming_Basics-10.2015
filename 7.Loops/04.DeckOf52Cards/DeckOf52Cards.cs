using System;
using System.Security.Policy;

namespace _04.DeckOf52Cards
{
    class DeckOf52Cards
    {
        static void Main()
        {
            for (int i = 2; i < 15; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    switch (i)
                    {
                        case 2:
                            Console.Write(" 2");
                            break;
                        case 3:
                            Console.Write(" 3");
                            break;
                        case 4:
                            Console.Write(" 4");
                            break;
                        case 5:
                            Console.Write(" 5");
                            break;
                        case 6:
                            Console.Write(" 6");
                            break;
                        case 7:
                            Console.Write(" 7");
                            break;
                        case 8:
                            Console.Write(" 8");
                            break;
                        case 9:
                            Console.Write(" 9");
                            break;
                        case 10:
                            Console.Write("10");
                            break;
                        case 11:
                            Console.Write(" J");
                            break;
                        case 12:
                            Console.Write(" Q");
                            break;
                        case 13:
                            Console.Write(" K");
                            break;
                        case 14:
                            Console.Write(" A");
                            break;
                        default:
                            Console.WriteLine("Card Error");
                            break;
                    }
                    switch (j)
                    {
                        case 1:
                            Console.Write((char)5 + " ");
                            break;
                        case 2:
                            Console.Write((char)4 + " ");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write((char)3 + " ");
                            break;
                        case 4:
                            Console.WriteLine((char)6 + " ");
                            break;
                        default:
                            Console.WriteLine("Char Error");
                            break;
                    }
                }
            }
        }
    }
}