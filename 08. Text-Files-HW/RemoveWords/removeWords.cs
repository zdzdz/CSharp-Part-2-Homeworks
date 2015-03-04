//Problem 12. Remove words

//    Write a program that removes from a text file all words listed in given another text file.
//    Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
class removeWords
{
    static void Main()
    {
        string inputPath = "../../input.txt";
        string forbiddenWords = "../../forbidden words.txt";

        List<string> result = new List<string>();
        List<string> forbidden = new List<string>();
        using (StreamReader reader = new StreamReader(forbiddenWords))
        {
            while (!reader.EndOfStream)
            {
                string[] words = reader.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                forbidden.AddRange(words);
            }
        }
        using (StreamReader reader = new StreamReader(inputPath))
        {
            while (!reader.EndOfStream)
            {
                string[] words = reader.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => !forbidden.Contains(x))
                .ToArray();
                result.AddRange(words);
            }
        }
        using (StreamWriter writer = new StreamWriter(inputPath))
        {
            writer.Write(String.Join(", ", result));
            Console.WriteLine("DIRECTORY: " +
            Path.GetFullPath(inputPath).Replace(Path.GetFileName(inputPath), String.Empty));
            Console.WriteLine("The file {0} has been ccensored.",
            Path.GetFileName(inputPath));
        }

    }
}

