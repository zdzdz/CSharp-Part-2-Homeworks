//Problem 2. Maximal sum

//    Write a program that reads a rectangular matrix of size N x M and finds in it 
//    the square 3 x 3 that has maximal sum of its elements.

using System;

class calculateMaxSum
{
    static void Main()
    {
        Console.Write("Enter the number of rows of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of cols of the matrix: ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;


        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (bestSum < currentSum)
                {
                    bestSum = currentSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine();
        for (int row = bestRow; row < bestRow + 3; row++)
        {
            for (int col = bestCol; col < bestCol + 3; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("The best sum is: " + bestSum);
    }
}

