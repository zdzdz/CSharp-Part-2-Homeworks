//Problem 2. Compare arrays

//    Write a program that reads two integer arrays from the console and 
//    compares them element by element.


using System;

class compareValuesInArrays
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("firstArray[{0}]: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
            Console.Write("secondArray[{0}]: ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("The first value {0} is bigger than the second value {1} on {2} position.", firstArray[i], secondArray[i], i);
            }
            else if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("The first value {0} is less than the second value {1} on {2} position", firstArray[i], secondArray[i], i);
            }
            else
            {
                Console.WriteLine("The values on poistion {0} are equal.", i);
            }
        }
    }
}

