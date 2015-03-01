//Problem 2. Reverse string

//    Write a program that reads a string, reverses it and prints the result at the console.


using System;
using System.Text;
using System.Linq;

class reverseText
{
    static void Main()
    {
        string text = Console.ReadLine();

        string reverse = new string(text.ToCharArray().Reverse().ToArray()); //First method
        Console.WriteLine(reverse );

        Console.WriteLine(ReverseString(text)); //Second method
    }

    private static StringBuilder ReverseString(string text)
    {
        StringBuilder reversedText = new StringBuilder();
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversedText.Append(text[i]);
        }
        return reversedText;
    }
}

