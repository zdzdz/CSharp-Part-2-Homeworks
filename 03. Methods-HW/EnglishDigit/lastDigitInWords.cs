//Problem 3. English digit

//    Write a method that returns the last digit of given integer as an English word.


using System;

class lastDigitInWords
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("The last digit in words is: ");
        LastDigit(number);
    }

    static void LastDigit(int number)
    {
        int lastNumber = number % 10;
        string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        for (int i = 0; i < words.Length; i++)
        {
            if (lastNumber == i)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}

