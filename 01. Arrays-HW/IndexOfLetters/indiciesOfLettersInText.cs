//Problem 12. Index of letters

//    Write a program that creates an array containing all letters from the alphabet (A-Z).
//    Read a word from the console and print the index of each of its letters in the array.


using System;

class indiciesOfLettersInText
{
    static void Main()
    {
        char[] letters = new char[26];
        for (int i = 0; i < 26; i++)
        {
            letters[i] = (char)(i + 65);
        }
        Console.Write("Please enter a word: ");
        string text = Console.ReadLine().ToUpper();
        Console.Write("The indices of the letters of the entered word are: ");
        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (text[i] == letters[j])
                {
                    Console.Write(j);
                    if (i < text.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
        Console.WriteLine();
    }
}

