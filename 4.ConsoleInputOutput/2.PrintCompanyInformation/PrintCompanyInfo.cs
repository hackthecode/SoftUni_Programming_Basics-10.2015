using System;


namespace _2.PrintCompanyInformation
{
    class PrintCompanyInfo
    {
        private static void Main()
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();

            Console.Write("Phone numer: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Fax number: ");
            // no input - check
            string faxNumber = String.IsNullOrEmpty(faxNumber = Console.ReadLine()) ? "(no fax)" : faxNumber;

            Console.Write("Web Site: ");
            string webSite = Console.ReadLine();

            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Manager age: ");
            string managerAge = Console.ReadLine();

            Console.Write("Manager phone: ");
            string managerPhone = Console.ReadLine();
            Console.Clear();
            // print all data
            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            Console.WriteLine("Fax: " + faxNumber);
            Console.WriteLine("Web Site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }
}
