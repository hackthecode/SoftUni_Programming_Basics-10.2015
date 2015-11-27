using System;

namespace _02.PrintCompanyInfo
{
    class PrintCompanyInfo
    {
        static void Main()
        {
            // input
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: +359");
            double phoneNumber = double.Parse(Console.ReadLine());
            Console.Write("Fax number: ");
            string faxNumber = string.IsNullOrEmpty(faxNumber = Console.ReadLine()) ? "(no fax)" : faxNumber;
            Console.Write("Web site: http://");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerSecondName = Console.ReadLine();
            Console.Write("Manager age: ");
            byte managerAge = byte.Parse(Console.ReadLine());
            Console.Write("Manager phone: +359");
            double managerPhone = double.Parse(Console.ReadLine());
            // clear console
            Console.Clear();
            //output
            Console.WriteLine("{0}", companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. +359 {0:### ## ## ##}", phoneNumber);
            Console.WriteLine("Fax {0}", faxNumber);
            Console.WriteLine("Web site: http://{0}", webSite);
            Console.Write("Manager: {0} {1} ", managerFirstName, managerSecondName);
            Console.WriteLine("(age: {0}, tel. +359 {1:# ### ###})", managerAge, managerPhone);
        }
    }
}
