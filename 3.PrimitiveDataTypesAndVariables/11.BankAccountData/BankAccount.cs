using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Dragomir";
        string middleName = "Nedev";
        string lastName = "Tsanev";
        decimal balance = 2000000;
        string bankName = "Societe Generale ExpressBank";
        object iban = "BG33AAАА12311012345678";
        object bic = "TTBBBG22";
        ulong visa = 4929637921579933;
        ulong mastercard = 5309009101730784;
        ulong americanExpress = 342020322211587;
        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Middle Name: {0}", middleName);
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("Balance: {0}", balance);
        Console.WriteLine("Bank Name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("BIC: {0}", bic);
        Console.WriteLine("Credit Card Number - Visa : {0}", visa);
        Console.WriteLine("Credit Card Number - Mastercard : {0}", mastercard);
        Console.WriteLine("Credit Card Number - American Express: {0}", americanExpress);
    }
}
