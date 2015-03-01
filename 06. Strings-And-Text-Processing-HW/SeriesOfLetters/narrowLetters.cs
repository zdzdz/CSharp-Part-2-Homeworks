//Problem 23. Series of letters

//    Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class narrowLetters
    {
        static void Main()
        {
            
            Console.Write("Enter some string: ");
            string input = Console.ReadLine();
            if (input.Length == 0)
            {
                Console.WriteLine("No characters to show!");
                return;
            }
            StringBuilder result = new StringBuilder();
            char lastChar = '\0';
            foreach (var letter in input)
            {
                if (letter != lastChar)
                    result.Append(letter);
                lastChar = letter;
            }
            Console.WriteLine(result);
        }
    }
}
