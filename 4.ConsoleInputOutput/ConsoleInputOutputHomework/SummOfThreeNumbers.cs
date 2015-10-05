using System;

namespace ConsoleInputOutputHomework
{
    static class SummOfThreeNumbers
    {
        static void Main()
        {
            // input value of A
            Console.Write("Enter a value for A: ");
            double numA;
            if (double.TryParse(Console.ReadLine(), out numA)) ; //check input 
            else
            {
                Console.WriteLine("Invalid input!"); //error message if input is invalid
                return;
            }

            // input value of B
            Console.Write("Enter a value for B: ");
            double numB;
            if (double.TryParse(Console.ReadLine(), out numB)) ;  //check input 
            else
            {
                Console.WriteLine("Invalid input!"); //error message if input is invalid
                return;
            }

            // input value of C
            Console.Write("Enter a value for C: ");
            double numC;
            if (double.TryParse(Console.ReadLine(), out numC)) ; //check input 
            else
            {
                Console.WriteLine("Invalid input!"); //error message if input is invalid
                return;
            }
            // sum values
            double sum = numA + numB + numC;
            Console.WriteLine("The sum of the three numbers is {0}.", sum); //print sum of 3 numbers

        }
    }
}
