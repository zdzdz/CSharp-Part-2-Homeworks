//Problem 6. Maximal K sum

//    Write a program that reads two integer numbers N and K and an array of N elements 
//    from the console.
//    Find in the array those K elements that have maximal sum.


using System;

class maxSumOfIntInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int sum = 0;
        int greaterSum = 0;
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= n - k; i++)
        {
            for (int j = i; j < k + i; j++)
            {
                sum += array[j];
            }
            if (sum > greaterSum)
            {
                greaterSum = sum;
            }
            sum = 0;
        }
        Console.WriteLine("The greatest sum is {0}", greaterSum);
    }
}

