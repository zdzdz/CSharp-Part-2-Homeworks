//Problem 2. Binary to decimal

//    Write a program to convert binary numbers to their decimal representation.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BinToDec
{
    static void Main(string[] args)
    {
        Console.Write("Enter a binary number: ");
        int binary = Int32.Parse(Console.ReadLine());
        string strBinary = binary.ToString();
        char[] array = strBinary.ToCharArray();
        int dec = 0;
        int digit;
        for (int i = 0; i < array.Length; i++)
        {
            digit = (int)Char.GetNumericValue(array[array.Length - 1 - i]);
            dec += digit * (int)Math.Pow(2, i);
        }
        Console.WriteLine("In decimal: {0}", dec);
    }
}
