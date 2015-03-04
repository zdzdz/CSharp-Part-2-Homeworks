//Problem 2. Concatenate text files

//    Write a program that concatenates two text files into another text file.


using System;
using System.IO;
class joinFiles
{
    static void Main()
    {
        string firstTextPath = "../../text1.txt";
        string secondTextPath = "../../text2.txt";
        string concatenatedPath = "../../concatText.txt";

        try
        {
            ReadFileConetnt(firstTextPath, concatenatedPath);
            ReadFileConetnt(secondTextPath, concatenatedPath);

            PrintConcatenatedFile(concatenatedPath);
        }
        catch(FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch(DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    private static void PrintConcatenatedFile(string resultPath)
    {
        using (StreamReader reader = new StreamReader(resultPath))
        {
            while(!reader.EndOfStream)
            Console.WriteLine(reader.ReadLine());
        }
    }

    private static void ReadFileConetnt(string textPath, string resultPath)
    {
        using(StreamWriter writer = new StreamWriter(resultPath, true))
        {
            using(StreamReader reader = new StreamReader(textPath))
            {
                while (!reader.EndOfStream)
                {
                    writer.WriteLine(reader.ReadLine());
                }
            }
        }
    }
}

