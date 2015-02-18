//Problem 7. Selection sort

//    Sorting an array means to arrange its elements in increasing order. 
//    Write a program to sort an array.
//    Use the Selection sort algorithm: Find the smallest element, 
//    move it at the first position, find the smallest from the rest, 
//    move it at the second position, etc.


using System;

class sortArray
{
    static void Main()
    {
        int[] array = { 99, 56, 3, 2, 18, 4, -1, -4, 33, 7, 19, 5, 1, -13, 2, 20 };
        Console.WriteLine("Initial array: {0}", String.Join(", ", array));
        int temp;

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        Console.WriteLine("Sorted array: {0}", String.Join(", ", array));
    }
}

