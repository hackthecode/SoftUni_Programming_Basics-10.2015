using System;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            //Read the input from the console as a string array and split the whitespaces
            string[] input = Console.ReadLine().Split();
            int[] numbers = new int[input.Length];

            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);

            }

            for (int j = 0; j < input.Length; j += 2)
            {
                oddProduct *= numbers[j];
            }

            for (int k = 1; k < input.Length; k += 2)
            {
                evenProduct *= numbers[k];
            }

            if (evenProduct == oddProduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", oddProduct);
            }
            else if (evenProduct != oddProduct)
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", oddProduct);
                Console.WriteLine("even_product = {0}", evenProduct);
            }
        }
    }
}