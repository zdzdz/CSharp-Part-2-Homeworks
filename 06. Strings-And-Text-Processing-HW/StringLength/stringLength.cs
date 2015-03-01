//Problem 6. String length

//    Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//    Print the result string into the console.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class stringLength
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string (MAX LENGTH: 20 chars): ");
            string text = Console.ReadLine();

            if (text.Length > 20)
            {
                Console.WriteLine("Invalid lenght!");
                return;
            }

            Console.WriteLine(text.PadRight(20, '*'));
        }

    }
}
