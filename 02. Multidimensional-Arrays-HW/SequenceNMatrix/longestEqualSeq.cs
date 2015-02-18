//Problem 3. Sequence n matrix

//    We are given a matrix of strings of size N x M. Sequences in the matrix we define as 
//    sets of several neighbour elements located on the same line, column or diagonal.
//    Write a program that finds the longest sequence of equal strings in the matrix.


using System;

class longestEqualSeq
{
    static void Main()
    {
        Console.Write("Enter the number of rows of the matrix: = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of rows of the matrix: = ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];
        // Read data from console

        //string[,] matrix = 
        //{
        // {"ha","fifi","ho","hi"},
        // {"fo","ha","hi","xx"},
        // {"xxx","ho","ha","xx"}
        //};
        //string[,] matrix = 
        //{
        // {"s","qq","s"},
        // {"pp","pp","s"},
        // {"pp","qq","s"}
        //};
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("matrix[{0},{1}]=", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
        //Search everal neighbour elements located on the same line, column or diagonal
        string element = string.Empty;
        int currentcount = 1;
        int count = 1;
        // string currentElement = matrix[0, 0];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currentcount = 1;
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentcount++;
                }
                else
                {
                    currentcount = 1;
                }
                if (currentcount > count)
                {
                    count = currentcount;
                    element = matrix[row, col];
                }
            }
            currentcount = 1;
        }
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentcount++;
                }
                else
                {
                    currentcount = 1;
                }
                if (currentcount > count)
                {
                    count = currentcount;
                    element = matrix[row, col];
                }
            }
            currentcount = 1;
        }
        for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
        {
            if (matrix[row, col] == matrix[row + 1, col + 1])
            {
                currentcount++;
            }
            else
            {
                currentcount = 1;
            }
            if (currentcount > count)
            {
                count = currentcount;
                element = matrix[row, col];
            }
        }
        //Print Matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-6}", matrix[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        //Output result
        Console.WriteLine("Result: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(i < count - 1 ? "{0}, " : "{0}", element);
        }
        Console.WriteLine();

    }
}

