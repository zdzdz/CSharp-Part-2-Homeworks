//Problem 3. Day of week

//    Write a program that prints to the console which day of the week is today.
//    Use System.DateTime.


using System;

class printDayOfWeek
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine("Today is {0}.",today.DayOfWeek);
    }
}

