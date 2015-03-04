//Problem 3. Line numbers

//    Write a program that reads a text file and inserts line numbers in front of each of its lines.
//    The result should be written to another text file.


using System;
using System.IO;
class numberLines
{
    static void Main()
    {
        string firstTextPath = "../../text1.txt";
        string newTextPath = "../../numberedText.txt";

        int lineCount = 1;
        using(StreamReader reader = new StreamReader(firstTextPath))
        {
            string line = reader.ReadLine();
            while ((line = reader.ReadLine()) != null)
            {
                lineCount++;
            }
        }

        using (StreamWriter writer = new StreamWriter(newTextPath, false))
        {
            using (StreamReader reader = new StreamReader(firstTextPath))
            {
                for (int i = 1; i <= lineCount; i++)
                {
                    writer.WriteLine(i + " " + reader.ReadLine());
                }
            }
        }
    }
}

