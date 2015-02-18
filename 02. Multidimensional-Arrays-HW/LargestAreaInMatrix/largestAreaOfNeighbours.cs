//Problem 7.* Largest area in matrix

//    Write a program that finds the largest area of equal neighbour elements in 
//    a rectangular matrix and prints its size.


using System;
using System.Collections.Generic;

class largestAreaOfNeighbours
{
    private static Stack<int> bCellCol;
    private static Stack<int> bCellRow;
    private static int[,] table;
    private static bool[,] visitedCells;
    private static int rows;
    private static int cols;
    private static int maxAreaSize;
    private static int currentAreaSize;
    private static void Initialize(int[,] ltable, int cols, int rows)
    {
        bCellCol = new Stack<int>();
        bCellRow = new Stack<int>();
        InitializeVisitedCells(cols, rows);
        table = ltable;
        cols = cols;
        rows = rows;
        maxAreaSize = 0;
        currentAreaSize = 0;
    }
    private static void InitializeVisitedCells(int cols, int rows)
    {
        visitedCells = new bool[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                visitedCells[row, col] = false;
            }
        }
    }
    private static bool IsBranching(int row, int col)
    {
        int currentValue = table[row, col];
        if (col - 1 >= 0 && table[row, col - 1] == currentValue &&
        IsVisited(row, col - 1) == false) //left
        {
            return true;
        }
        else if (col + 1 < cols && table[row, col + 1] == currentValue &&
        IsVisited(row, col + 1) == false)//right
        {
            return true;
        }
        else if (row - 1 >= 0 && table[row - 1, col] == currentValue &&
        IsVisited(row - 1, col) == false)//up
        {
            return true;
        }
        else if (row + 1 < rows && table[row + 1, col] == currentValue &&
        IsVisited(row + 1, col) == false)//down
        {
            return true;
        }
        return false;
    }
    private static bool IsVisited(int row, int col)
    {
        return visitedCells[row, col];
    }
    public static int CheckMatrix(int[,] table, int cols, int rows)
    {
        Initialize(table, cols, rows);
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (visitedCells[row, col] == false && IsBranching(row, col) == true)
                {
                    bCellCol.Push(col);
                    bCellRow.Push(row);
                    Explore(col, row);
                }
            }
        }
        return maxAreaSize;
    }
    private static void Explore(int col, int row)
    {
        int currentValue = table[row, col];
        //_currentAreaSize++;
        while (bCellCol.Count > 0 && bCellRow.Count > 0)
        {
            col = bCellCol.Pop();
            row = bCellRow.Pop();
            int colTemp = col;
            int rowTemp = row;
            while (colTemp - 1 >= 0 && table[rowTemp, colTemp - 1] == currentValue &&
            IsVisited(rowTemp, colTemp - 1) == false) //left
            {
                colTemp = colTemp - 1;
                //rowTemp = rowTemp;
                bCellCol.Push(colTemp);
                bCellRow.Push(rowTemp);
                visitedCells[rowTemp, colTemp] = true;
                currentAreaSize++;
            }
            colTemp = col;
            rowTemp = row;
            while (colTemp + 1 < cols && table[rowTemp, colTemp + 1] == currentValue &&
            IsVisited(rowTemp, colTemp + 1) == false)//right
            {
                colTemp = colTemp + 1;
                //rowTemp = rowTemp;
                bCellCol.Push(colTemp);
                bCellRow.Push(rowTemp);
                visitedCells[rowTemp, colTemp] = true;
                currentAreaSize++;
            }
            colTemp = col;
            rowTemp = row;
            while (rowTemp - 1 >= 0 && table[rowTemp - 1, colTemp] == currentValue &&
            IsVisited(rowTemp - 1, colTemp) == false)//up
            {
                //colTemp = colTemp;
                rowTemp = rowTemp - 1;
                bCellCol.Push(colTemp);
                bCellRow.Push(rowTemp);
                visitedCells[rowTemp, colTemp] = true;
                currentAreaSize++;
            }
            colTemp = col;
            rowTemp = row;
            while (rowTemp + 1 < rows && table[rowTemp + 1, colTemp] == currentValue &&
            IsVisited(rowTemp + 1, colTemp) == false)//down
            {
                //colTemp = colTemp;
                rowTemp = rowTemp + 1;
                bCellCol.Push(colTemp);
                bCellRow.Push(rowTemp);
                visitedCells[rowTemp, colTemp] = true;
                currentAreaSize++;
            }
        }
        if (currentAreaSize > maxAreaSize)
        {
            maxAreaSize = currentAreaSize;
        }
        currentAreaSize = 0;
    }
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int m = int.Parse(Console.ReadLine());
        int[,] array = new int[n, m];
        // Read data from console
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Array[{0},{1}] = ", i, j);
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Initialize(array, n, m);
        Console.WriteLine("Size: " + CheckMatrix(array, n, m));
    }
}

