//Problem 1. Leap year

//    Write a program that reads a year from the console and checks whether it is a leap one.
//    Use System.DateTime.


using System;

class checkLeapYear
{
    static void Main()
    {
        try
        {

            Console.Write("Please enter a year to check if it is aa leap year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the year {0} is leap? -> {1}", year, DateTime.IsLeapYear(year));

        }
        catch (FormatException)
        {
            Console.WriteLine("Your input is not a year in numbers.");
        }
        catch(ArgumentOutOfRangeException)
        {
            Console.WriteLine("The year you entered is not a positive number.");
        }
    }
}

