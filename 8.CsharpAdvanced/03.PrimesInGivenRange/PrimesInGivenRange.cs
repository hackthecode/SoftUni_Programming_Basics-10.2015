using System;
using System.Collections.Generic;

namespace _03.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main()
        {
            Console.Write("Start number: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("End number: ");
            int endNum = int.Parse(Console.ReadLine());

            if (startNum > endNum)
            {
                Console.WriteLine("(empty list)");
            }
            else
            {
                List<int> primes = FindPrimesInRange(startNum, endNum + 1); // "+1" inclusive endNum

                for (int i = 0; i < primes.Count; i++)
                {
                    if (i < primes.Count)
                    {
                        Console.Write("{0}", primes[i]);
                        if (i < primes.Count - 1)
                        {
                            Console.Write(", "); //check - not written a comma after the last number
                        }
                    }
                }
            }
            // This is just to output message "Press any key to continue . . ." on a new line!
            Console.WriteLine(); 
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primesList = new List<int>();

            if (startNum < 2)
            {
                startNum = 2;
            }
            for (int i = startNum; i < endNum; i++)
            {
                int divider = 2;
                double maxDivider = Math.Sqrt(i);
                bool isPrime = true;

                while (divider <= maxDivider)
                {
                    if (i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    divider++;
                }

                if (isPrime && i != 0 && i != 1)
                {
                    primesList.Add(i);
                }
            }
            return primesList;
        }
    }
}