using System;
using System.Collections.Generic;


namespace _11.CountOfLetters
{
    class CountOfLetters
    {
        static void Main()
        {
            //Read the letters and add to array;
            string allLetters = Console.ReadLine();
            string[] letters = allLetters.Split(' ');
            //Sort and add to dictionary;
            Array.Sort(letters);
            Dictionary<string, int> lettersAndCounts = new Dictionary<string, int>();
            foreach (string letter in letters)
            {
                int count;
                if (lettersAndCounts.TryGetValue(letter, out count))
                {
                    lettersAndCounts[letter] += 1;
                }
                else
                {
                    lettersAndCounts.Add(letter, 1);
                }
            }
            //Print the result;
            foreach (var entry in lettersAndCounts)
            {
                Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
            }
        }
    }
}
