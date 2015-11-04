using System;
using System.Text;

namespace _02.FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main()
        {
            // float Precision = 7 digits
            // double Precision = 15-16 digits
            double variable1 = 34.567839023;
            float variable2 = 12.345F;
            double variable3 = 8923.1234857;
            float variable4 = 3456.091F;
            // Console Print
            Console.OutputEncoding = Encoding.UTF8;
            char rightwardsArrow = '\u2192'; // char →
            Console.WriteLine(String.Format("{0, -7}", "double ") + rightwardsArrow + "{0, 13}", variable1);
            Console.WriteLine(String.Format("{0, -7}", "float ") + rightwardsArrow + "{0, 13}", variable2);
            Console.WriteLine(String.Format("{0, -7}", "double ") + rightwardsArrow + "{0, 13}", variable3);
            Console.WriteLine(String.Format("{0, -7}", "float ") + rightwardsArrow + "{0, 13}", variable4);
        }
    }
}
