using System;
using System.Collections.Generic;


namespace _12.CountOfNames
{
    class CountOfNames
    {
        static void Main()
        {
            //Read the names and add to array;
            string allNames = Console.ReadLine();
            string[] names = allNames.Split(' ');
            //Sort and add to dictionary;
            Array.Sort(names);
            Dictionary<string, int> namesAndCounts = new Dictionary<string, int>();
            foreach (string name in names)
            {
                int count;
                if (namesAndCounts.TryGetValue(name, out count))
                {
                    namesAndCounts[name] += 1;
                }
                else
                {
                    namesAndCounts.Add(name, 1);
                }
            }
            //Print the result;
            foreach (var entry in namesAndCounts)
            {
                Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
            }

        }
    }
}
