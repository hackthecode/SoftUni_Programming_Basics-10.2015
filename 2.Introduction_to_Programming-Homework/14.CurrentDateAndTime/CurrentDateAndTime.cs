using System;
using System.Text;

namespace _14.CurrentDateAndTime
{
    class CurrentDateAndTime
    {
        static void Main()
        {
            //using encoding output UTF8
            Console.OutputEncoding = Encoding.UTF8;
            DateTime timeNow = DateTime.Now;
            // using ToString for correct output
            Console.WriteLine(timeNow.ToString("dd.mm.yyyy" + " \u0433. " + "HH:mm:ss" + " \u0447."));
        }
    }
}
