//Problem 9. Frequent number

//    Write a program that finds the most frequent number in an array.

using System;

class printFrequentNumbers
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int mostFrequentNumber = array[0];
        int currentCount = 1;
        int maxCount = 1;

        for (int i = 0; i < array.Length; i++)
        {
            currentCount = 1;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] == array[i])
                {
                    currentCount++;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    mostFrequentNumber = array[j];
                }
            }
        }
        Console.WriteLine("Most frequent number in array [{0}]\nis {1} ({2} times)", String.Join(", ", array), mostFrequentNumber, maxCount);
    }
}

