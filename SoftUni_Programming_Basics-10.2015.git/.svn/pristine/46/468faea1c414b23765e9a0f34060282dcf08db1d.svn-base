using System;
using System.Text;

namespace _14.PrintTheASCIITable
{
    class PrintASCII
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            for (byte index = 0; index < byte.MaxValue; index++)
            {
                byte[] byteArray = { index };
                char[] asciiArray = Encoding.GetEncoding(437).GetChars(byteArray);
                char asciiSign = asciiArray[0];
                //or: char asciiSign = Encoding.GetEncoding(437).GetChars(new byte[]{index})[0];

                switch (index)
                {
                    case 0:
                        Console.WriteLine("{0:000} = not visible (null)", index);
                        break;
                    case 7:
                        Console.WriteLine("{0:000} ={1} not visible (\"beep!\" sound)", index, asciiSign);
                        break;
                    case 8:
                        Console.WriteLine("{0:000} = not visible (backspace)", index);
                        break;
                    case 9:
                        Console.WriteLine("{0:000} = not visible (horizontal tab)", index);
                        break;
                    case 10:
                        Console.WriteLine("{0:000} = not visible (new line)", index);
                        break;
                    case 13:
                        Console.WriteLine("{0:000} = not visible (carriage return)", index);
                        break;
                    case 127:
                        Console.WriteLine("{0:000} = not visible (DEL)", index);
                        break;
                    case 32:
                        Console.WriteLine("{0:000} = space", index);
                        break;

                    default:
                        Console.WriteLine("{0:000} = {1}", index, asciiSign);
                        break;
                }
            }
            char lastChar = Encoding.GetEncoding(437).GetChars(new byte[] { 255 })[0];
            Console.WriteLine("{0:000} = not visible {1}", 255, lastChar);
        }

    }
}