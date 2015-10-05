using System;
using System.Text;

namespace _5.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("Enter integer a: ");
            int a = int.Parse(Console.ReadLine());
            while (a < 0 || a > 500) //Check number is valid
            {
                Console.WriteLine("Invalid input! Try again!");
                a = int.Parse(Console.ReadLine());
            };
            Console.Write("Enter an floating-point b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter an floating-point  c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10:F2}|{3, -10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
    }
}
