//Problem 4. Hexadecimal to decimal

//    Write a program to convert hexadecimal numbers to their decimal representation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HecDectoDec
{
    static void Main(string[] args)
    {
        Console.Write("Enter a Hexadecimal number: "); 
        string strHex = Console.ReadLine();
        char[] array = strHex.ToCharArray();
        int dec = 0;
        int digit;
        for (int i = 0; i < array.Length; i++)
        {
            if (char.IsDigit(array[i]))
            {
                digit = (int)Char.GetNumericValue(array[array.Length - 1 - i]);
                dec += digit * (int)Math.Pow(16, i);
            }
            else
            {
                switch (array[i])
                {
                    case 'A': dec += 10 * (int)Math.Pow(16, i); break;
                    case 'B': dec += 11 * (int)Math.Pow(16, i); break;
                    case 'C': dec += 12 * (int)Math.Pow(16, i); break;
                    case 'D': dec += 13 * (int)Math.Pow(16, i); break;
                    case 'E': dec += 14 * (int)Math.Pow(16, i); break;
                    case 'F': dec += 15 * (int)Math.Pow(16, i); break;
                    default:
                        break;
                }
            }
        }
        Console.WriteLine("In decimal: {0}", dec);
    }
}
