//Problem 11. Binary search

//    Write a program that finds the index of given element in 
//    a sorted array of integers by using the Binary search algorithm.


using System;

class searchBin
{
    static void Main()
    {
        Console.Write("Enter an integer N: ");
        int number = int.Parse(Console.ReadLine());
        BinarySearchAlg(number);
    }
    public static int BinarySearchAlg(int number)
    {
        int[] array = { 5, 9, 0, 13, 6, -1, 3, 2, -2, 8, -3, 12, -4 };
        Console.WriteLine("Original array: [{0}]", String.Join(", ", array));
        Array.Sort(array);
        Console.WriteLine("Sorted array: [{0}]", String.Join(", ", array));
        int min = 0;
        int max = array.Length - 1;
        while (min <= max)
        {
            int middle = (min + max) / 2;
            if (number == array[middle])
            {
                Console.WriteLine("{0} was found at index {2} in [{1}]", number, String.Join(", ", array), middle);
                return middle;
            }
            else if (number > array[middle])
            {
                min = middle + 1;
            }
            else
            {
                max = middle - 1;
            }
        }
        Console.WriteLine("{0} was not found in [{1}]", number, String.Join(", ", array));
        return -1;
    }
}

