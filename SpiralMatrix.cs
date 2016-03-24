using System;

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n 
//in the form of square spiral like in the examples below. 

//Traverse the array starting from element (0,0) (top-left), and heading right (incrementing your column index). Keep a running counter that 
//increments each time you fill an element, as well as upper and lower bounds on the rows and columns you have yet to fill. For an M-row by 
//N-column matrix, your row bounds should be 0 and (M-1), and your column bounds 0 and (N-1). Go right until you hit your upper column bound, 
//decrement your upper column bound, go down until you hit your upper row bound, decrement your upper row bound, go left until you hit your 
//lower column bound, increment your lower column bound, go up until you hit your lower row bound, increment your lower bound, and repeat 
//until your upper and low row or column bounds are equal (or until your running count is M*N).

class SpiralMatrix
{
    static void Main()
    {
        System.Console.SetWindowSize(100, 30);
        int n = int.Parse(Console.ReadLine());
        Console.Clear();
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        int value = 1;

        if (n > 0 && n < 21)
        {
            while (value <= n * n)
            {
                while (col < matrix.GetLength(0) && matrix[row, col] == 0)
                {
                    matrix[row, col++] = value;
                    value++;
                }
                col--;
                row++;
                while (row < matrix.GetLength(1) && matrix[row, col] == 0)
                {
                    matrix[row++, col] = value;
                    value++;
                }
                row--;
                col--;
                while (col >= 0 && matrix[row, col] == 0)
                {
                    matrix[row, col--] = value;
                    value++;
                }
                col++;
                row--;
                while (row >= 0 && matrix[row, col] == 0)
                {
                    matrix[row--, col] = value;
                    value++;
                }
                col++;
                row++;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j * 5, i * 2);
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}
