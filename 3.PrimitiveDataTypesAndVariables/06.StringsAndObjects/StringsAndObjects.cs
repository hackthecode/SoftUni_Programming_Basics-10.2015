using System;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            //Casting from object to string
            string objectToString = (string)helloWorld;
            Console.WriteLine(objectToString);
        }
    }
}
