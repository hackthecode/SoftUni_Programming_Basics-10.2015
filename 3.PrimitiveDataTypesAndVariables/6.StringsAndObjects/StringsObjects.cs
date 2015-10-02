using System;

class StringsObjects
{
    static void Main()
    {
        string hi = "Hello";
        string world = "World";
        object concatenation = hi + " " + world;
        string objectvariable = (string)concatenation;
        Console.WriteLine(objectvariable);
    }
}
