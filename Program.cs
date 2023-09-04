using System;

class MatrixOperations
{
    static void Main()
    {
        // Generate random dimensions for the matrices
        Random rand = new Random();
        int Rows = rand.Next(2, 11); // Random number of rows for both matrices (2 to 10)
        int Cols = rand.Next(2, 11); // Random number of columns for both matrices (2 to 10)

        // Initialize random matrices with values between 1 and 100
        int[,] matrixA = InitializeMatrix(Rows, Cols);
        int[,] matrixB = InitializeMatrix(Rows, Cols);

        Console.WriteLine("Matrix A:");
        PrintMatrix(matrixA);

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMatrix A + Matrix B:");
        int[,] add = Add(matrixA, matrixB);
        PrintMatrix(add);

        Console.WriteLine("\nMatrix A - Matrix B:");
        int[,] sub = Subtract(matrixA, matrixB);
        PrintMatrix(sub);

        Console.WriteLine("\nMatrix A * Matrix B:");
        int[,] multi = Multiply(matrixA, matrixB);
        PrintMatrix(multi);
    }

    private static int[,] InitializeMatrix(int rows, int cols)
    {
        Random rand = new Random();
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(1, 101); // Random values between 1 and 100
            }
        }
        return matrix;
    }

    private static void PrintMatrix(int[,] matrix)
    {
        int Rows = matrix.GetLength(0);
        int Cols = matrix.GetLength(1);

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    private static int[,] Add(int[,] matrixA, int[,] matrixB)
    {
        int Rows = matrixA.GetLength(0);
        int Cols = matrixA.GetLength(1);
        int[,] result = new int[Rows, Cols];

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return result;
    }

    private static int[,] Subtract(int[,] matrixA, int[,] matrixB)
    {
        int Rows = matrixA.GetLength(0);
        int Cols = matrixA.GetLength(1);
        int[,] result = new int[Rows, Cols];

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                result[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }

        return result;
    }

    private static int[,] Multiply(int[,] matrixA, int[,] matrixB)
    {
        int Rows = matrixA.GetLength(0);
        int Cols = matrixB.GetLength(1);
        int[,] result = new int[Rows, Cols];

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                result[i, j] = matrixA[i, j] * matrixB[i, j];
            }
        }

        return result;
    }
}
