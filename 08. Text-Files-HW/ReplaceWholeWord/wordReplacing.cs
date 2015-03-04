//Problem 8. Replace whole word

//    Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
class wordReplacing
{
    const string FROM = "start";
    const string TO = "finish";
    static void Main()
    {
        string inputPath = "../../input.txt";
        string outputPath = "../../output.txt";

        using (StreamReader reader = new StreamReader(inputPath))
        {
            StringBuilder currentLine;
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                while (!reader.EndOfStream)
                {
                    currentLine = new StringBuilder(reader.ReadLine());
                    writer.WriteLine(Replace(currentLine));
                }
                Console.WriteLine("A file {0} has been created with the replaced text.",
Path.GetFileName(outputPath));
            }
        }
    }
    private static string Replace(StringBuilder currentLine)
    {
        int startIndex = 0;
        string checkLine = currentLine.ToString();
        while (startIndex < currentLine.Length &&
        checkLine.IndexOf(FROM, StringComparison.OrdinalIgnoreCase) != -1)
        {
            startIndex = checkLine.IndexOf(FROM, StringComparison.OrdinalIgnoreCase);
            bool startOfWord = (startIndex == 0 ||
            !Char.IsLetterOrDigit(currentLine[startIndex - 1]));
            bool endOfWord = ((startIndex + FROM.Length) == currentLine.Length ||
            !Char.IsLetterOrDigit(currentLine[startIndex + FROM.Length]));
            if (startOfWord && endOfWord)
            {
                currentLine = currentLine
                .Replace(currentLine.ToString()
                .Substring(startIndex, FROM.Length),
                TO, startIndex, FROM.Length);
            }
            startIndex += TO.Length;
            checkLine = currentLine.ToString().Substring(startIndex);
            checkLine = checkLine.PadLeft(currentLine.Length, '*');
        }
        return currentLine.ToString();
    }
}

