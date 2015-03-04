//Problem 4. Compare text files

//    Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//    Assume the files have equal number of lines.

using System;
using System.IO;
class comapreLines
{
    static void Main()
    {
        string firstTextPath = "../../text1.txt";
        string secondTextPath = "../../text2.txt";

        int similarCount = 0;
        int differentCount = 0;

        using (StreamReader firstText = new StreamReader(firstTextPath))
        {
            using (StreamReader secondText = new StreamReader(secondTextPath))
            {
                string firstTextLine = firstText.ReadLine();
                string secondTextLine = secondText.ReadLine();
                while(firstTextLine != null && secondTextLine != null)
                {
                    if (firstTextLine == secondTextLine)
                    {
                        similarCount++;
                    }
                    else if (firstTextLine != secondTextLine)
                    {
                        differentCount++;
                    }
                    firstTextLine = firstText.ReadLine();
                    secondTextLine = secondText.ReadLine();
                }
            }
            Console.WriteLine("SAME LINES COUNT: {0}", similarCount);
            Console.WriteLine("DIFFERENT LINES COUNT: {0}", differentCount);
        }
    }
}

