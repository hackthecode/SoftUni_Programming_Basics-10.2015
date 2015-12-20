using System;

namespace _06.LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main()
        {
            Console.Write("Array lenght: ");
            int len = int.Parse(Console.ReadLine());
            //Set array;
            string[] words = new string[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write("Word[{0}]: ", i + 1);
                string text = Console.ReadLine();
                words[i] = text;
            }
            //Find longest area;
            int count = 1;
            int savedCount = 0;
            string word = "";
            string savedWord = "";
            for (int i = 0; i < len - 1; i++)
            {
                if (words[i] == words[i + 1])
                {
                    word = words[i];
                    count++;
                }
                else
                {
                    if (count > savedCount)
                    {
                        savedCount = count;
                        savedWord = words[i];
                    }
                    count = 1;
                }
            }
            //Current count is bigger than saved;
            if (count > savedCount)
            {
                savedCount = count;
                savedWord = word;
            }
            //Result;
            if (len == 0)
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                Console.WriteLine(savedCount);
            }
            if (len == 1)
            {
                Console.WriteLine(words[0]);
            }
            else
            {
                for (int i = 0; i < savedCount; i++)
                {
                    Console.WriteLine(savedWord);
                }
            }

        }
    }
}