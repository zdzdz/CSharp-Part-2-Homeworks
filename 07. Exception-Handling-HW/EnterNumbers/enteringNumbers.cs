//Problem 2. Enter numbers

//    Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//        If an invalid number or non-number text is entered, the method should throw an exception.
//    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100


using System;

class enteringNumbers
{
    static void Main()
    {
        Console.Write("Enter a number as a start of the range: ");
        int startNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a number as an end of the range: ");
        int endNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 10 numbers in the range [{0}..{1}]: ", startNumber, endNumber);

        try
        {
            int newNumber = 0;
            for (int i = 0; i < 10; i++)
            {
                newNumber = ReadNumber(startNumber, endNumber);
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number was out of the predefined range.");
        }
        catch (FormatException)
        {
            Console.WriteLine("The input is not an integer or it is text.");
        }

    }

    private static int ReadNumber(int startNumber, int endNumber)
    {
        int newNumber = int.Parse(Console.ReadLine());
        if (newNumber < startNumber || newNumber > endNumber)
        {
            throw new ArgumentOutOfRangeException();
        }
        return newNumber;
    }
}

