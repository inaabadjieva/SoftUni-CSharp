using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrix
{
    class RotateMatrix
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            var matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var cells = Console.ReadLine().Split(' ').ToArray();
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = cells[col];
            }
            
            for (int col = 0; col < cols; col++)
            {
                for (int row = rows-1; row >= 0; row--)
                {
                    Console.Write(matrix[row,col] + " "); 
                }
                Console.WriteLine();
            }

        }
    }
}
