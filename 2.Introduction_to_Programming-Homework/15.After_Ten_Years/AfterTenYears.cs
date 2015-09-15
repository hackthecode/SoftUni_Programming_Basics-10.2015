using System;

class AfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        int Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Аfter 10 years you will be: {0}", Age + 10 + " years.");
    }
}