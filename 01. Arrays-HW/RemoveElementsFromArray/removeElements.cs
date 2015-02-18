//Problem 18.* Remove elements from array

//    Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
//    Print the remaining sorted array.


using System;
using System.Collections.Generic;
using System.Linq;

class removeElements
{
    static void Main()
    {
        List<List<int>> sequences = new List<List<int>>();
        List<int> currentSequence = new List<int>();
        Console.Write("Enter an array of integers in the format a, b, c, ...: ");
        string input = Console.ReadLine();
        string[] numsStr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[numsStr.Length];
        int counter = 1;
        int start = 0;
        int end = sequences.Count;
        int bestSequenceLength = 1;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(numsStr[i]);
        }
        Console.WriteLine("Initial array: [{0}]", string.Join(", ", array));
        for (int i = 0; i < array.Length; i++) 
        {
            List<int> temp1 = new List<int>(1);
            temp1.Add(i);
            sequences.Add(temp1);
        }
        while (counter <= array.Length) 
        {
            end = sequences.Count;
            for (int i = start; i < end; i++) 
            {
                currentSequence = new List<int>();
                currentSequence.AddRange(sequences[i]);
                for (int j = currentSequence.Last() + 1; j < array.Length; j++) 
                { 
                    if (array[j] >= array[currentSequence.Last()]) 
                    { 
                        List<int> temp = new List<int>(); 
                        temp.AddRange(currentSequence); 
                        temp.Add(j); 
                        sequences.Add(temp);
                    }
                }
            }
            start = end;
            counter++;
        }
        for (int i = 0; i < sequences.Count; i++)
        {
            if (sequences[i].Count >= bestSequenceLength)
            {
                bestSequenceLength = sequences[i].Count; 
            }
        }
        for (int i = 0; i < sequences.Count; i++)
        {
            if (sequences[i].Count == bestSequenceLength)
            {
                Console.Write("Best non-decreasing sequence: ");
                for (int j = 0; j < bestSequenceLength; j++)
                {
                    Console.Write(array[sequences[i][j]]); 
                    if (j < bestSequenceLength - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

