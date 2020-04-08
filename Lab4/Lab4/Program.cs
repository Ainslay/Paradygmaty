using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[3,3];
            int[,] matrixB = new int[3,3];

            var random = new Random();

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = random.Next(0, 10);
                    matrixB[i, j] = random.Next(0, 10);
                }
            }

            Console.WriteLine("Matrix A:");
            PrintMatrix(matrixA);
            Console.WriteLine("Matrix B:");
            PrintMatrix(matrixB);
            Console.WriteLine();

            Console.WriteLine("Wynik sumowania tych dwóch macierzy:");
            SumMatrices(matrixA, matrixB);

            Console.ReadKey();
        }

        static void SumMatrices(int[,] matrixA, int[,] matrixB)
        {
            if(matrixA.Length == matrixB.Length)
            {
                int[,] result = new int[matrixA.GetLength(0), matrixA.GetLength(1)];

                unsafe
                {
                    fixed (int* resultPtr = result)
                    fixed (int* matrixAPtr = matrixA)
                    fixed (int* matrixBPtr = matrixB)
                        
                    for (int i = 0; i < result.Length; i++)
                    {
                            resultPtr[i] = matrixAPtr[i] + matrixBPtr[i];
                    }
                }

                PrintMatrix(result);
            }
            else
            {
                Console.WriteLine("Macierze muszą posiadać te same wymiary!");
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        //static void MultiplyMatrices(int[,] matrixA, int[,] matrixB)
        //{
        //    if(matrixA.GetLength(1) == matrixB.GetLength(0))
        //    {
        //        int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        //        unsafe
        //        {
        //            fixed (int* resultPtr = result)
        //            fixed (int* matrixAPtr = matrixA)
        //            fixed (int* matrixBPtr = matrixB)

        //            for (int i = 0; i < result.Length; i++)
        //            {
        //                int sum = 0;
        //                for (int x = 0; x < matrixA.GetLength(1); x++)
        //                {
        //                    sum += matrixAPtr[x] * matrixBPtr[x];
        //                }
        //                resultPtr[i] = sum;
        //            }
        //        }

        //        PrintMatrix(result);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Liczba kolumn macierzy A i liczba wierszy macierzy B musi byc taka sama!");
        //    }

        //}
    }
}
