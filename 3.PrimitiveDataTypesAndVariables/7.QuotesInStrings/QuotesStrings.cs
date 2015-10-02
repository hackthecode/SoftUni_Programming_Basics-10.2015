using System;

class QuotesStrings
{
    static void Main()
    {
        string firstString = "The \"use\" of quotations causes difficulties.";
        string secondString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(firstString);
        Console.WriteLine(secondString);
    }
}