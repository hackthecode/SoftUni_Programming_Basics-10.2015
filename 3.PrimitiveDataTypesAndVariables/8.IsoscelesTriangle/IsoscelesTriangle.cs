using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        int symbol = 169;

        //Simple Variant
        Console.WriteLine(" " + " " + " " + (char)symbol);
        Console.WriteLine(" " + " " + (char)symbol + " " + (char)symbol);
        Console.WriteLine(" " + (char)symbol + " " + " " + " " + (char)symbol);
        Console.WriteLine((char)symbol + " " + (char)symbol + " " + (char)symbol + " " + (char)symbol);
    }
}

