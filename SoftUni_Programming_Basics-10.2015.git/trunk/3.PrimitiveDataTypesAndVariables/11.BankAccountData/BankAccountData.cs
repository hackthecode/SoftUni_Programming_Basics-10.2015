using System;

namespace _11.BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            //Using string because no need to change this values, only balance is changeable
            string firstName = "Dragomir";
            string middleName = "Nedev";
            string lastName = "Tsanev";
            decimal balance = 264654.54M;
            string bankName = "Societe Generale ExpressBank";
            string iban = "BG33AAAA12311012345678";
            string bic = "TTBBBG22"; // Societe Generale ExpressBank BIC
            // http://www.getcreditcardnumbers.com/
            string visa = "4929637921579933"; 
            string mastercard = "5309009101730784";
            string americanExpress = "344540704743566";
            string space = null; // for output formatting
            Console.WriteLine("{0,6}First Name: {1}", space, firstName);
            Console.WriteLine("{0,5}Middle Name: {1}", space, middleName);
            Console.WriteLine("{0,7}Last Name: {1}", space, lastName);
            Console.WriteLine("{0,9}Balance: {1}", space, balance);
            Console.WriteLine("{0,7}Bank Name: {1}", space, bankName);
            Console.WriteLine("{0,12}IBAN: {1}", space, iban);
            Console.WriteLine("{0,13}BIC: {1}", space, bic);
            Console.WriteLine("{0,12}Visa: {1}", space, visa);
            Console.WriteLine("{0,6}Mastercard: {1}", space, mastercard);
            Console.WriteLine("American Express: {0}", americanExpress);
        }
    }
}
