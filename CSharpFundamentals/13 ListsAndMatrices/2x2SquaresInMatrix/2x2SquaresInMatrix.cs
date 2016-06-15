using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = rowsCols[0];
            int cols = rowsCols[1];
            var matrix = new char[rows, cols];
            //reading the first matrix
            for (int row = 0; row < rows; row++)
            {
                var cells = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = cells[col];
                }
            }
            //algorithm
            var count = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                
                for (int col = 0; col < cols - 1; col++)
                {
                    char letter = matrix[row, col];
                    char letterRight = matrix[row+1, col];
                    char letterDown = matrix[row, col+1];
                    char letterDownRight = matrix[row+1, col+1];
                    
                    if (letter == letterRight && letter == letterDown && letter==letterDownRight) 
                        count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
