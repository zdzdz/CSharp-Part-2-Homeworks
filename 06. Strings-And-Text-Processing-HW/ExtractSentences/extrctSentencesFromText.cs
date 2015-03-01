//Problem 8. Extract sentences

//    Write a program that extracts from a given text all sentences containing given word

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class extrctSentencesFromText
    {
        static void Main()
        {
            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine();
            Console.Write("Enter a word that we are going to looking for in the text: ");
            string word = Console.ReadLine();
            string[] sentences = text.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\nSentences containing word [{0}]:\n", word);
            for (int i = 0; i < sentences.Length; i++)
            {
                if (IsSentenceContainsWord(sentences, i, word))
                {
                    Console.WriteLine(sentences[i].Trim() + ".");
                }
            }
            Console.WriteLine();
        }
        private static bool IsSentenceContainsWord(string[] sentences, int index, string word)
        {
            return Regex.Matches(sentences[index], string.Format(@"\b{0}\b", word), RegexOptions.IgnoreCase).Count != 0;
        }
    }
}
