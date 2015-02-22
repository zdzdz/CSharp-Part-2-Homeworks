//Problem 6. First larger than neighbours

//    Write a method that returns the index of the first element in array that is larger 
//    than its neighbours, or -1, if there’s no such element.
//    Use the method from the previous exercise.


using System;

class firstBiggerElement
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

        int position = CheckNeighbours(array);

        if (position > 0)
        {
            Console.WriteLine("The element is on postion " + position);
        }
        else
        {
            Console.WriteLine(position);
        }
    }

    static int CheckNeighbours(int[] array)
    {
        int position = -1;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                position = i;
                break;
            }
        }
        return position;
    }
}

