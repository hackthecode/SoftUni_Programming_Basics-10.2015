using System;

namespace _6.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Please enter the four digit number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int d = num % 10;
            num /= 10;
            int c = num % 10;
            num /= 10;
            int b = num % 10;
            num /= 10;
            int a = num;

            int sum = a + b + c + d;
            Console.WriteLine("The sum of digits is: " + sum);
            int reversed = d * 1000 + c * 100 + b * 10 + a;
            Console.WriteLine("Reversed number: " + reversed);
            int lastDigitInfront = d * 1000 + a * 100 + b * 10 + c;
            Console.WriteLine("Last digit at first position: " + lastDigitInfront);
            int switchSecondAndThird = a * 1000 + c * 100 + b * 10 + d;
            Console.WriteLine("Exchanged second and third digit: " + switchSecondAndThird);
        }
    }
}
