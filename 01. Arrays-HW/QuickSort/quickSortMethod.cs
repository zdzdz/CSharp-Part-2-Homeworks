//Problem 14. Quick sort

//    Write a program that sorts an array of integers using the Quick sort algorithm.


using System;

class quickSortMethod
{
    static void Main()
    {
        // Create an unsorted array of string elements
        int[] unsorted = { 9, 15, 12, 1, -1, 0, 296,50 };
        // Print the unsorted array
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }
        Console.WriteLine();
        // Sort the array
        QuicksortSearch(unsorted, 0, unsorted.Length - 1);
        // Print the sorted array
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }
        Console.WriteLine();
    }

    public static void QuicksortSearch(int[] elements, int left, int right)
    {
        int i = left, j = right;
        int pivot = elements[(left + right) / 2];
        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }
            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }
            if (i <= j)
            {
                // Swap
                int tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;
                i++;
                j--;
            }
        }
        // Recursive calls
        if (left < j)
        {
            QuicksortSearch(elements, left, j);
        }
        if (i < right)
        {
            QuicksortSearch(elements, i, right);
        }
    }
}

