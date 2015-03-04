//Problem 6. Save sorted names

//    Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        string inputPath = "../../names.txt";
        string outputPath = "../../sortedNames.txt";

        List<string> text = new List<string>();
        using(StreamReader reader = new StreamReader(inputPath))
        {
            text = reader.ReadToEnd()
                         .Split('\n')
                         .Select(x => x.Trim())
                         .OrderBy(x => x)
                         .ToList();
            File.WriteAllLines(outputPath, text);
        }
    }
}

