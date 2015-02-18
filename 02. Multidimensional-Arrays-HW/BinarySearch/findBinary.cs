//Problem 4. Binary search

//    Write a program, that reads from the console an array of N integers and an integer K, 
//    sorts the array and using the method Array.BinSearch() finds the largest number in the array 
//    which is ≤ K.


using System;

class findBinary
{
    static void Main()
    {
        Console.Write("Array with elements N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        int maxValue = 0;
        int[] array = new int[n];
        //int[] array = new int[]{1,2,37,4,5,99,11,2,3,5,4,6,8,9};

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= k)
            {
                maxValue = array[i];
            }
        }

        Array.BinarySearch(array, maxValue);

        if (k < array[0])
        {
            Console.WriteLine("K = {0} is smaller than the min element in array.", k);
        }
        else
        {
            Console.WriteLine("The biggest number smaller or equal to K = {1} is {0}", maxValue, k);
        }
    }
}

