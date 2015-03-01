//Problem 22. Words count

//    Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CountWords
{
    class wordsCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine().ToUpper();
            StringBuilder result = new StringBuilder();
            Dictionary<string, int> words = new Dictionary<string, int>();
            CountWords(text, words);
            if (words.Count == 0)
            {
                Console.WriteLine("No letters to count!");
            }
            else
            {
                foreach (var word in words)
                {
                    Console.WriteLine("{1,-12}[{0}]", word.Key, word.Value);
                }
            }
        }
        private static void CountWords(string text, Dictionary<string, int> words)
        {
            foreach (var match in Regex.Matches(text, @"\w+"))
            {
                if (!words.ContainsKey(match.ToString()))
                {
                    words.Add(match.ToString(), 1);
                }
                else
                {
                    words[match.ToString()] += 1;
                }
            }
        }
    }
}
