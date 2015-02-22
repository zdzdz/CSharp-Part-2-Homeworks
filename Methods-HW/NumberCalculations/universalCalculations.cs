//Problem 15.* Number calculations

//    Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//    Use generic method (read in Internet about generic methods in C#).


using System;

class universalCalculations
{
    static void Main()
    {
        Console.WriteLine("The minimum of set is: {0}", Min(1, -2, 3.0, -4, 5, -6, 7.5));
        Console.WriteLine("The maximum of set is: {0}", Max(1, -2.5, 3, -4, 5.2, -6, 7));
        Console.WriteLine("The average of set is: {0}", Average(1, -2.5, 3, -4, 5, -6, 7));
        Console.WriteLine("The sum of set is: {0}", Sum(1, -2.5, 3, -4, 5.2, -6, 7));
        Console.WriteLine("The product of set is: {0}", Product(1.8, -2.5, 3, -4, 5.2, -6, -7.95, 10));
    }
    static T Min<T>(params T[] arr)
    {
        dynamic min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
    static T Max<T>(params T[] arr)
    {
        dynamic max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
    static T Sum<T>(params T[] arr)
    {
        dynamic sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    static dynamic Average<T>(params T[] arr)
    {
        dynamic sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return ((dynamic)sum / (dynamic)arr.Length);
    }
    static T Product<T>(params T[] arr)
    {
        dynamic product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }
}

