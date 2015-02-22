//Problem 1. Decimal to binary

//    Write a program to convert decimal numbers to their binary representation.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class DecToBin
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int number = int.Parse(Console.ReadLine());
        int binary;
        string str = "";
        while (number != 0)
        {
            binary = number & 1;
            str = binary.ToString() + str;
            number = number >> 1;
        }
        Console.WriteLine("In binary: " + str);
    }
}