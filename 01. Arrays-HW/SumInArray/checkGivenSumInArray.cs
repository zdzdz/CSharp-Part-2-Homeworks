//Problem 10. Find sum in array

//    Write a program that finds in given array of integers a sequence of given sum S (if present).


using System;

class checkGivenSumInArray
{
    static void Main()
    {
        int[] array = { 5, 6, 2, 3, 4, 6, 9 };
        int givenSum = 11;
        int currentStart = 0;
        int currentEnd = 0;
        bool sumFound = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (sumFound)
            {
                break;
            }
            currentStart = i;
            long currentSum = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                if (currentSum < givenSum)
                {
                    currentSum += array[j];
                    if (currentSum == givenSum)
                    {
                        currentEnd = j;
                        sumFound = true;
                        break;
                    }
                }
                else
                {
                    currentSum = array[j];
                }
            }
        }
        if (sumFound)
        {
            int[] wantedSequence = new int[currentEnd - currentStart + 1];
            for (int i = 0; i < wantedSequence.Length; i++)
            {
                wantedSequence[i] = array[currentStart + i];
            }
            Console.WriteLine("The sequence [{0}] has the given sum of {1}", String.Join(", ", wantedSequence), givenSum);
        }
        else
        {
            Console.WriteLine("There is no sequence with sum = {0} in the array [{1}].", givenSum, String.Join(", ", array));
        }
    }
}

