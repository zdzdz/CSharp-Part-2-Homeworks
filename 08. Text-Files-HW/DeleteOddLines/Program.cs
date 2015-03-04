//Problem 9. Delete odd lines

//    Write a program that deletes from given text file all odd lines.
//    The result should be in the same file.

using System;
using System.IO;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string inputPath = "../../input.txt";

        StringBuilder output = new StringBuilder();
        using (StreamReader reader = new StreamReader(inputPath))
        {
            
                int count = 1;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (count++ % 2 == 0)
                    {
                        output.AppendLine(line);
                    }
                }
        }
        using (StreamWriter writer = new StreamWriter(inputPath, false))
        {
            writer.WriteLine(output);
        }
        Console.WriteLine("The file {0} has been modified.",
Path.GetFileName(inputPath));
    }
}

