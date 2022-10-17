using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DATA_STRUCTURES.ARRAYS
{

    ///     A Matrix is a 2-Dimensional Array.
    ///     Multi-Dimensional Array vs Jagged Array

    ///     A jagged Array is simply an array of Arrays. e.g   int[] []. This means an array of integer arrays. 
    ///     A element in this this collection can be accessed like so. A[0][1]

    ///     A Matrix on the other hand is an collection of items that that progress in a 
    ///     


    public class Matrix
    {
        //  1   2   3   4
        //  5   1   1   8
        //  9   1   1  12
        //  13 14  15  16
        int[,] matrix2 = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 1, 1, 8 }, { 9, 1, 1, 12 }, { 13, 14, 15, 16 } };

        int[,] matrix = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

        public Matrix()
        {

            Print_Matrix_Items(matrix2);



            // Print_Matrix_Spirally(matrix);

            Debugger.Break();
        }


        // Print Every item in a matrix
        void Print_Matrix_Items(int[,] matrix)
        {
            int upper = matrix.GetLength(0);
            int lower = matrix.GetLength(1);
            for (int i = 0; i < upper; i++)
            {
                for (int j = 0; j < lower; j++)
                {
                    Console.Write($"{matrix[i, j]}  ");
                }
                Console.WriteLine();
            }
        }


        // Print the elements in a matrix sprially. i.e circuling inwards towards the center. 
        //  1   2   3   4
        //  5   6   7   8
        //  9  10  11  12
        //  13 14  15  16
        void Print_Matrix_Spirally(int[,] A)
        {
            HashSet<string> printed = new HashSet<string>();

            int itemCounter = 0;
            int a = A.GetLength(0)-1;
            int b = A.GetLength(1)-1;
            int p1 = 0;
            int p2 = 0;
           
            while (itemCounter < A.Length)
            {
                Console.Write(A[p1,p2]+ " ");

                printed.Add($"{p1}{p2}");

                itemCounter++;

                if (p2 < b && !printed.TryGetValue($"{p1}{p2+1}", out string val))
                {
                    p2++;
                }
                else if (p1 < a && !printed.TryGetValue($"{p1+1}{p2}", out string val2))
                {
                    p1++;
                }
                else if (p2 > 0 && !printed.TryGetValue($"{p1}{p2-1}", out string val3))
                {
                    p2--;
                }
                else if (p1 > 0 && !printed.TryGetValue($"{p1-1}{p2}", out string val4))
                {
                    p1--;
                }
            }
        }
    }
}
