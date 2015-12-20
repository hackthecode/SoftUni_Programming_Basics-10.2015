using System;


namespace _14.LongestWordInText
{
    class LongestWordInText
    {
        static void Main()
        {
            string input = Console.ReadLine();
            //string input = "Welcome to the Software University.";
            char[] charSeparators = { ' ', '.', ',' };
            string[] words = input.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            int longestWordLen = 0;
            string longestWord = "";
            foreach (string word in words)
            {
                int currentWordLen = word.Length;
                if (currentWordLen > longestWordLen)
                {
                    longestWordLen = currentWordLen;
                    longestWord = word;
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}
