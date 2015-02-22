//Problem 10. N Factorial

//    Write a program to calculate n! for each n in the range [1..100].

//Hint: Implement first a method that multiplies a number represented as array of 
//digits by given integer number.

using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

class calculateNFactorial
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        CalculateFactorial(n);
    }
    private static void CalculateFactorial(int number)
    {
        BigInteger product = 1;
        int[] nums = Enumerable.Range(1, number).ToArray();
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            product *= nums[i];
        }
        Console.WriteLine(product);
    }
}