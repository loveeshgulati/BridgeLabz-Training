using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods.level_3
{
    public class MatrixOperations
    {
        // a. Create random matrix
        static double[,] CreateRandomMatrix(int rows, int cols)
        {
            double[,] matrix = new double[rows, cols];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = random.Next(1, 10);

            return matrix;
        }

        // i. Display matrix
        static void DisplayMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // b. Matrix addition
        static double[,] AddMatrices(double[,] a, double[,] b)
        {
            int r = a.GetLength(0), c = a.GetLength(1);
            double[,] result = new double[r, c];

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    result[i, j] = a[i, j] + b[i, j];

            return result;
        }

        // c. Matrix subtraction
        static double[,] SubtractMatrices(double[,] a, double[,] b)
        {
            int r = a.GetLength(0), c = a.GetLength(1);
            double[,] result = new double[r, c];

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    result[i, j] = a[i, j] - b[i, j];

            return result;
        }

        // d. Matrix multiplication
        static double[,] MultiplyMatrices(double[,] a, double[,] b)
        {
            int r1 = a.GetLength(0), c1 = a.GetLength(1);
            int c2 = b.GetLength(1);

            double[,] result = new double[r1, c2];

            for (int i = 0; i < r1; i++)
                for (int j = 0; j < c2; j++)
                    for (int k = 0; k < c1; k++)
                        result[i, j] += a[i, k] * b[k, j];

            return result;
        }

        // Transpose
        static double[,] TransposeMatrix(double[,] matrix)
        {
            int r = matrix.GetLength(0), c = matrix.GetLength(1);
            double[,] transpose = new double[c, r];

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    transpose[j, i] = matrix[i, j];

            return transpose;
        }

        // e. Determinant of 2x2
        static double Determinant2x2(double[,] m)
        {
            return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
        }

        // f. Determinant of 3x3
        static double Determinant3x3(double[,] m)
        {
            return
                m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) -
                m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) +
                m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
        }

        // g. Inverse of 2x2
        static double[,] Inverse2x2(double[,] m)
        {
            double det = Determinant2x2(m);
            double[,] inv = new double[2, 2];

            inv[0, 0] = m[1, 1] / det;
            inv[0, 1] = -m[0, 1] / det;
            inv[1, 0] = -m[1, 0] / det;
            inv[1, 1] = m[0, 0] / det;

            return inv;
        }

        // h. Inverse of 3x3
        static double[,] Inverse3x3(double[,] m)
        {
            double det = Determinant3x3(m);
            double[,] inv = new double[3, 3];

            inv[0, 0] = (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) / det;
            inv[0, 1] = -(m[0, 1] * m[2, 2] - m[0, 2] * m[2, 1]) / det;
            inv[0, 2] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]) / det;

            inv[1, 0] = -(m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) / det;
            inv[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]) / det;
            inv[1, 2] = -(m[0, 0] * m[1, 2] - m[0, 2] * m[1, 0]) / det;

            inv[2, 0] = (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]) / det;
            inv[2, 1] = -(m[0, 0] * m[2, 1] - m[0, 1] * m[2, 0]) / det;
            inv[2, 2] = (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]) / det;

            return inv;
        }

        static void Main(string[] args)
        {
            double[,] A = CreateRandomMatrix(2, 2);
            double[,] B = CreateRandomMatrix(2, 2);

            Console.WriteLine("Matrix A:");
            DisplayMatrix(A);

            Console.WriteLine("Matrix B:");
            DisplayMatrix(B);

            Console.WriteLine("Addition:");
            DisplayMatrix(AddMatrices(A, B));

            Console.WriteLine("Subtraction:");
            DisplayMatrix(SubtractMatrices(A, B));

            Console.WriteLine("Multiplication:");
            DisplayMatrix(MultiplyMatrices(A, B));

            Console.WriteLine("Transpose of A:");
            DisplayMatrix(TransposeMatrix(A));

            Console.WriteLine("Determinant of A: " + Determinant2x2(A));

            Console.WriteLine("Inverse of A:");
            DisplayMatrix(Inverse2x2(A));

            Console.WriteLine("Inverse of A: 3x3 ");
            DisplayMatrix(Inverse3x3(A));
        }
    }
}
