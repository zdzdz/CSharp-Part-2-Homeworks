//Problem 1. Square root

//    Write a program that reads an integer number and calculates and prints its square root.
//        If the number is invalid or negative, print Invalid number.
//        In all cases finally print Good bye.
//    Use try-catch-finally block.


using System;

class exceptionInSquareRoot
{
    static void Main()
    {
        
        try
        {
            Console.Write("Please eneter an integer: ");
            uint number = uint.Parse(Console.ReadLine());
            
            double sqRoot = Math.Sqrt(number);
            Console.WriteLine(sqRoot);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid Number!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid Number!");
        }
        
        finally
        {
            Console.WriteLine("Good Bye!");
        }
    }
}

