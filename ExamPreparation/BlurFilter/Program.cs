using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlurFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int blurAmount = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            long[,] matrix = new long[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] columns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = columns[col];
                }
            }
            int[] coordinatesToBlur = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowToBlur = coordinatesToBlur[0];
            int colToBlur = coordinatesToBlur[1];

            int startRow = Math.Max(0, rowToBlur - 1);
            int endRow = Math.Min(rowToBlur + 1, rows-1);
            int startCol = Math.Max(0, colToBlur - 1);
            int endCol = Math.Min(colToBlur + 1, cols - 1);

            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    matrix[row, col] += blurAmount;
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0} ", matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
