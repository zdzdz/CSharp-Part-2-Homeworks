//Problem 4. Appearance count

//    Write a method that counts how many times given number appears in given array.
//    Write a test program to check if the method is workings correctly.


using System;

class checkAppearanceInArray
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
        Console.Write("Enter a number to check: ");
        int number = int.Parse(Console.ReadLine());
        int count = Appearance(array, number);
        Console.WriteLine("Number {0} appears in that array {1} times.", number, count);
    }

    static int Appearance(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
}

