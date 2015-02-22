//Problem 9. Sorting array

//    Write a method that returns the maximal element in a portion of array of integers starting at given index.
//    Using it write another method that sorts an array in ascending / descending order.

using System;
class printMaxElement
{
    static void Main()
    {
        int[] array = { 12, 8, 15, -2, 4, 53, -11 };
        Sort(array);// Ascending
        Print(array);
        Sort(array, false);// Descending
        Print(array);
    }
    static int GetMaxElement(int[] array, int index, bool ascecnding = true)
    {
        int best = index;
        for (index++; index < array.Length; index++)
        {
            if (ascecnding)
            {
                if (array[index] < array[best])
                {
                    best = index;
                }
            }
            else
            {
                if (array[index] > array[best])
                {
                    best = index;
                }
            }
        }
        return best;
    }
    static void Sort(int[] array, bool ascdeing = true)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Swap(array, i, GetMaxElement(array, i, ascdeing));
        }
    }
    static void Swap(int[] array, int i, int j)
    {
        int t = array[i];
        array[i] = array[j];
        array[j] = t;
    }
    static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + (i == array.Length - 1 ? "\n" : " "));
        }
    }
}