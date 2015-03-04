//Problem 10. Extract text from XML

//    Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;
using System.Text;
class extractText
{
    static void Main()
    {
        string inputPath = "../../test.xml";
        string outputPath = "../../output.txt";

        using (StreamReader reader = new StreamReader(inputPath))
        {
            string xml = reader.ReadToEnd();
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                writer.Write(GetResult(xml));

                Console.WriteLine("A file {0} with {1} text content has been created.",
                Path.GetFileName(outputPath), Path.GetFileName(inputPath));
            }
        }
    }

    private static string GetResult(string xml)
    {
        StringBuilder result = new StringBuilder();
        StringBuilder current = new StringBuilder();
        bool insideTag = false;
        foreach (var letter in xml)
        {
            if (insideTag)
            {
                if (letter == '>')
                {
                    insideTag = false;
                }
                continue;
            }
            else
            {
                if (letter == '<')
                {
                    if (current.Length > 0)
                    {
                        result.AppendLine(current.ToString());
                        current.Clear();
                    }
                    insideTag = true;
                }
                else
                {
                    current.Append(letter);
                }
                continue;
            }
        }
        return result.ToString();
    }
}

