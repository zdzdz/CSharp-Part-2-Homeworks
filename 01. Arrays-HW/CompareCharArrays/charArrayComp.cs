//Problem 3. Compare char arrays

//    Write a program that compares two char arrays lexicographically (letter by letter).


using System;

class charArrayComp
{
    static void Main()
    {
        Console.Write("Enter characters in the first array: ");
        string firstArrayStr = Console.ReadLine();
        Console.Write("Enter characters in the second array: ");
        string secondArrayStr = Console.ReadLine();

        char[] firstArray = firstArrayStr.ToCharArray();
        char[] secondArray = secondArrayStr.ToCharArray();

        int compareBoth = Math.Min(firstArrayStr.Length, secondArray.Length);

        bool areEqual = true;

        for (int i = 0; i < compareBoth; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                areEqual = false;
                if (firstArrayStr[i] < secondArray[i])
                {
                    Console.WriteLine("The fist array is lexicografically before the second");
                    break;
                }
                else
                {
                    Console.WriteLine("The second array is lexicografically before the first");
                    break;
                }
            }
        }

        if (areEqual == true && firstArrayStr.Length == secondArrayStr.Length)
        {
            Console.WriteLine("The Two arrays are equal");
        }
        else if (areEqual == true && firstArrayStr.Length < secondArrayStr.Length)
        {
            Console.WriteLine("The first array is before the second");
        }
        else if (areEqual == true && firstArrayStr.Length < secondArrayStr.Length)
        {
            Console.WriteLine("The second array is before the first");
        }
    }
}

