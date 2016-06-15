using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class MatrixGenerator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            char letter = char.Parse(input[0]);
            int rows = int.Parse(input[1]);
            int cols = int.Parse(input[2]);
            
            int num = 1;

            var matrix = new int[rows, cols];
            //a case
            if (letter == 'A')
            {
                for (int col = 0; col < cols; col++)
                    for (int row = 0; row < rows; row++)
                        matrix[row, col] = num++;
            }
            //b case
            else if (letter == 'B')
            {
                for (int col = 0; col < cols; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < rows; row++)
                            matrix[row, col] = num++;
                    }
                    else
                    {
                        for (int row = rows - 1; row >= 0; row--)
                            matrix[row, col] = num++;
                    }
                }
            }

            //c case
            else if (letter == 'C')
            {
                for (int row = rows - 1; row >= 0; row--)
                {
                    for (int col = 0; col < rows - row; col++)
                    {
                        matrix[row + col, col] = num++;
                    }
                }

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 1; col < cols - row; col++)
                    {
                        matrix[col - 1, col + row] = num++;
                    }
                }
            }

            //d case
            else
            {
                int row = 0;
                int col = 0;
                string direction = "down";
                int maxRotations = rows * cols;

                for (int i = 1; i <= maxRotations; i++)
                {
                    if (direction == "down" && (row > rows - 1 || matrix[row, col] != 0))
                    {
                        direction = "right";
                        col++;
                        row--;
                    }
                    if (direction == "right" && (col > cols - 1 || matrix[row, col] != 0))
                    {
                        direction = "up";
                        row--;
                        col--;
                    }
                    if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                    {
                        direction = "left";
                        col--;
                        row++;
                    }

                    if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                    {
                        direction = "down";
                        row++;
                        col++;
                    }

                    matrix[row, col] = i;

                    if (direction == "down")
                    {
                        row++;
                    }
                    if (direction == "right")
                    {
                        col++;
                    }
                    if (direction == "up")
                    {
                        row--;
                    }
                    if (direction == "left")
                    {
                        col--;
                    }
                }
            }

            //printing
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j + 1 != cols)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else Console.Write(matrix[i, j]);

                }
                Console.WriteLine();
            }

        }
    }
}
