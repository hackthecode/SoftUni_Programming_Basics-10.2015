using System;

namespace _06.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Enter \"n\" four-digit number in format abcd (e.g. 2011) \nn: ");
            int num = int.Parse(Console.ReadLine());
            //  % 10 gives the final digit each time
            //  /= 10 performs integer division, essentially removing the final digit each time.
            int d = num % 10;
            num /= 10;
            int c = num % 10;
            num /= 10;
            int b = num % 10;
            num /= 10;
            int a = num;
            //•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            //•	Prints on the console the number in reversed order: dcba (in our example 1102).
            //•	Puts the last digit in the first position: dabc (in our example 1201).
            //•	Exchanges the second and the third digits: acbd (in our example 2101).
            int sum = a + b + c + d;
            Console.WriteLine("sum of digits: " + sum);
            int reversed = d * 1000 + c * 100 + b * 10 + a;
            Console.WriteLine("reversed: " + reversed);
            int lastDigitInfront = d * 1000 + a * 100 + b * 10 + c;
            Console.WriteLine("last digit in front: " + lastDigitInfront);
            int switchSecondAndThird = a * 1000 + c * 100 + b * 10 + d;
            Console.WriteLine("second and third digits exchanged: " + switchSecondAndThird);
        }
    }
}
