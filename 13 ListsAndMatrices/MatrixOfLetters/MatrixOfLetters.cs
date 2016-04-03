using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfLetters
{
    class MatrixOfLetters
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            var matrix = new char[rows, cols];
            char letter = 'A';
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = letter++;
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    Console.Write(matrix[row, col] + " ");

                }
                Console.WriteLine(matrix[row, cols - 1]);
            }
        }
    }
}
