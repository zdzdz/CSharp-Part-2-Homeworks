//Problem 5. Larger than neighbours

//    Write a method that checks if the element at given position in given array
//    of integers is larger than its two neighbours (when such exist).


using System;

class compareNeighboursInArray
{
    static void Main()
    {
        Console.Write("Please enter the size of the array: ");
        int arrSize = int.Parse(Console.ReadLine());
        int[] array = new int[arrSize];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("arr[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter a position to check: ");
        
        int position = int.Parse(Console.ReadLine());
        if (IsLarger(array, position))
        {
            Console.WriteLine("The element at position {0} ({1}) is larger than its neighbours {2} and {3}.", position, array[position], array[position -1], array[position + 1]);
        }
        else
        {
            Console.WriteLine("The element at position {0} ({1}) is NOT larger than its neighbours {2} and {3}.", position, array[position], array[position - 1], array[position + 1]);
        }
        

    }

    static bool IsLarger(int[] array, int position)
    {
        bool isLarger = false;

        if (position > 0 && position < array.Length)
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                isLarger = true;
            }
        }
        else
        {
            Console.WriteLine("There are no neighbours to compare ");
            
        }
        return isLarger;
    }
}

