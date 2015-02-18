//Problem 5. Sort by string length

//    You are given an array of strings. Write a method that sorts the array 
//    by the length of its elements (the number of characters composing them).


using System;

class sortArray
{
    static void Main()
    {
        Console.Write("Enter length of the array: ");
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("arr [{0}]= ", i);
            arr[i] = Console.ReadLine();
        }
        Console.WriteLine();

        Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));

        foreach (string str in arr)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine();
    }
}

