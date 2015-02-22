//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SolveThreeTasks
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an option from the menu: ");
        Console.WriteLine("**************MENU**************");
        Console.WriteLine("1. Reverses the digits of a number.");
        Console.WriteLine("2. Calculates the average of a sequence of integers");
        Console.WriteLine("3. Solves a linear equation a * x + b = 0");
        Console.WriteLine("********************************");
        int choice = 0;
        do
        {
            Console.Write("Your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: ReverseDecimal(); break;
                case 2: AvarageSequence(); break;
                case 3: SolveLinearEquation(); break;
                default: Console.WriteLine("Wrong choice");
                    break;
            }
        } while (choice < 0 || choice > 3);
    }
    static void ReverseDecimal()
    {
        while (true)
        {
            Console.WriteLine("Enter a positive number: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                decimal reverse = decimal.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
                Console.WriteLine("Revsered is {0}", reverse);
                break;
            }
        }
    }
    static void AvarageSequence()
    {
        while (true)
        {
            Console.Write("Enter a positive number for arrays lenght: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                int sum = 0;
                double avarage;
                int[] arr = new int[number];
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Arr[{0}] =: ", i);
                    arr[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                avarage = (double)sum / number;
                Console.WriteLine("The average from the sequence is {0}", avarage);
                break;
            }
        }
    }
    static void SolveLinearEquation()
    {
        while (true)
        {
            double result;
            Console.Write("Enter A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            int b = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("A must not equal 0");
                continue;
            }
            else
            {
                result = (double)-b / a;
                Console.WriteLine("The Result from the equation is {0}", result);
                break;
            }
        }
    }
}