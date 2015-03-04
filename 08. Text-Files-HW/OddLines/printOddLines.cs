//Problem 1. Odd lines

//    Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class printOddLines
{
    static void Main()
    {
        string inputPath = "../../random text.txt";
        StreamReader reader = new StreamReader(inputPath);
        using(reader)
        {
            int count = 1;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (count++ % 2 != 0)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}

