//Problem 7. Reverse number

//    Write a method that reverses the digits of given decimal number.


using System;
using System.Linq;

class reverseMethod
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        decimal number = int.Parse(Console.ReadLine());
        
        decimal reversed = ReverseDecimal(number);
        Console.Write("Reversed: ");
        Console.WriteLine(reversed);
    }

    static decimal ReverseDecimal(decimal number)
    {
        return decimal.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
    }
}

