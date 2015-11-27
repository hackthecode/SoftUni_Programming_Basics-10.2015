using System;

namespace _09.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            byte a = 5, b = 10, tempValue;
            //Print before swap
            Console.WriteLine("Before:\na = {0} \nb = {1}", a, b);
            //Applyng the programming logic to swap two numbers in variables with each other
            tempValue = a;
            a = b;
            b = tempValue;
            //Print after swap
            Console.WriteLine("After:\na = {0} \nb = {1}", a, b);
        }
    }
}
