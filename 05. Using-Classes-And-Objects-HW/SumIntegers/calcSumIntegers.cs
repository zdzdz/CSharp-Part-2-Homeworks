//Problem 6. Sum integers

//    You are given a sequence of positive integer values written into a string, separated by spaces.
//    Write a function that reads these values from given string and calculates their sum.


using System;

class calcSumIntegers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string with digits folow with a space aftert each sequence of digits");
        string str = Console.ReadLine();
        Console.WriteLine("The sum is: {0}", StringToIntegerSum(str));
    }
    static int StringToIntegerSum(string str)
    {
        int sum = 0;
        char[] specialSigns = { ' ', '$', '@' };
        string[] s = str.Split(specialSigns, StringSplitOptions.RemoveEmptyEntries);
        foreach (string number in s)
        {
            sum += int.Parse(number);
        }
        return sum;
    }
}

