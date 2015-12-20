using System;
using System.Linq;


namespace _15.ExtractURLsFromText
{
    class ExtractURLsFromText
    {
        static void Main()
        {
            string input = Console.ReadLine();
            /*string input = "The site nakov.com can be access from http://nakov.com" +
            " or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. " +
            "Please check http://blog.nakov.com for more information.";*/
            char[] separators = { ' ' };
            var links = input.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Where(pattern => pattern.StartsWith("http://") || pattern.StartsWith("www."));
            foreach (var link in links)
            {
                Console.WriteLine(link);
            }
        }
    }
}
