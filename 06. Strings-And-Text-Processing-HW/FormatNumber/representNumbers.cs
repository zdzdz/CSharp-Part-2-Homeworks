//Problem 11. Format number

//    Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//    Format the output aligned right in 15 symbols.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumber
{
    class representNumbers
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15:D}", num);
            Console.WriteLine("{0,15:X}", num);
            Console.WriteLine("{0,15:P}", num);
            Console.WriteLine("{0,15:E}", num);
        }
    }
}
