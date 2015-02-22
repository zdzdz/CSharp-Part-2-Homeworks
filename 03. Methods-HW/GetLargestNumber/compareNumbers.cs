//Problem 2. Get largest number

//    Write a method GetMax() with two parameters that returns the larger of two integers.
//    Write a program that reads 3 integers from the console and prints the largest 
//    of them using the method GetMax().


using System;

class compareNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("The biggets number is {0}",Max(Max(a, b), c));
    }

    static int Max(int number1, int number2)
    {
        int maxNumber = number1;
        if (number2 > number1)
        {
            maxNumber = number2;
        }
        return maxNumber;
    }
}

