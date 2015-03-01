//Problem 24. Order words

//    Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWords
{
    class orderWords
    {
        static void Main()
        {
            
            Console.Write("Enter some words, separated by a space: ");
            var words = Console.ReadLine()
            .ToUpperInvariant()
            .Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
            words = words
            .Distinct()
            .ToList();
            words = words.OrderBy(x => x).ToList();
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
