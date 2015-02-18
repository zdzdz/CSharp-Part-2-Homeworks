//Problem 6.* Matrix class

//    Write a class Matrix, to hold a matrix of integers. Overload the operators 
//    for adding, subtracting and multiplying of matrices, indexer for accessing 
//    the matrix content and ToString().


using System;

class matrixClass
{
    class Matrix
    {
        // matrix size
        public const int MatrixSize = 3;
        private double[,] m = new double[MatrixSize, MatrixSize];
        // Indexer
        public double this[int x, int y]
        {
            get { return m[x, y]; }
            set { m[x, y] = value; }
        }
        // plus
        public static Matrix operator +(Matrix mat1, Matrix mat2)
        {
            Matrix newMatrix = new Matrix();
            for (int x = 0; x < MatrixSize; x++)
                for (int y = 0; y < MatrixSize; y++)
                    newMatrix[x, y] = mat1[x, y] + mat2[x, y];
            return newMatrix;
        }
        // minus
        public static Matrix operator -(Matrix mat1, Matrix mat2)
        {
            Matrix newMatrix = new Matrix();
            for (int x = 0; x < MatrixSize; x++)
                for (int y = 0; y < MatrixSize; y++)
                    newMatrix[x, y] = mat1[x, y] - mat2[x, y];
            return newMatrix;
        }
        // multiply
        public static Matrix operator *(Matrix mat1, Matrix mat2)
        {
            Matrix newMatrix = new Matrix();
            for (int x = 0; x < MatrixSize; x++)
                for (int y = 0; y < MatrixSize; y++)
                    newMatrix[x, y] = mat1[x, y] * mat2[x, y];
            return newMatrix;
        }
        public override string ToString()
        {
            string str = "";
            for (int x = 0; x < MatrixSize; x++)
            {
                for (int y = 0; y < MatrixSize; y++)
                {
                    str += m[x, y] + " ";
                }
                str += "\n";
            }
            return str;
        }
    }
    static void Main()
    {
        Matrix a = new Matrix();
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                a[x, y] = 5;
            }
        }
        Matrix b = new Matrix();
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                b[x, y] = 2;
            }
        }
        Console.WriteLine("Matrix A");
        Console.WriteLine(a);
        Console.WriteLine("Matrix B");
        Console.WriteLine(b);
        Console.WriteLine("Matrix A+B");
        Console.WriteLine(a + b);
        Console.WriteLine("Matrix A-B");
        Console.WriteLine(a - b);
        Console.WriteLine("Matrix A*B");
        Console.WriteLine(a * b);
    }
    
}

