using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCells
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);
            //building reading
            var matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var cells = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = cells[col];
            }
            int[] coordinatesToMultiply = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowMulti = coordinatesToMultiply[0];
            int colMulti = coordinatesToMultiply[1];
            int initialValue = matrix[rowMulti, colMulti];
           
            int startRow = Math.Max(0, rowMulti - 1);
            int endRow = Math.Min(rowMulti + 1, rows - 1);
            int startCol = Math.Max(0, colMulti - 1);
            int endCol = Math.Min(colMulti + 1, cols - 1);

            int sum = 0;

            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    sum += matrix[row, col]; 
                }
            }
            sum -= initialValue; //checked

            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    matrix[endRow - 1, endCol - 1] = initialValue * sum;
                    if (matrix[row, col] != matrix[endRow - 1, endCol - 1])
                        matrix[row, col] *= initialValue;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
