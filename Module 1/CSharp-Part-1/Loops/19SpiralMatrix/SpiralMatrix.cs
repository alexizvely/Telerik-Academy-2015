//Problem 19.** Spiral Matrix

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
//Examples:

//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1  2  3  4
//        4 3                 8 9 4               12 13 14 5
//                            7 6 5               11 16 15 6
//                                                10 9  8  7


using System;

class SpiralMatrix
{
    static void Main()
    {

        Console.WriteLine("The following prints a matrix holding the numbers from 1 to n*n");
        Console.Write("Please enter N: ");

        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int row = 0;
        int col = 0;
        int maxRow = n - 1;
        int maxCol = n - 1;
        int count = 1;

        while (count <= n * n)
        {
            for (int i = col; i <= maxCol; i++)
            {
                matrix[row, i] = count;
                count++;
            }
            row++;

            for (int i = row; i <= maxRow; i++)
            {
                matrix[i, maxCol] = count;
                count++;
            }
            maxCol--;

            for (int i = maxCol; i >= col; i--)
            {
                matrix[maxRow, i] = count;
                count++;
            }
            maxRow--;

            for (int i = maxRow; i >= row; i--)
            {
                matrix[i, col] = count;
                count++;
            }
            col++;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}

