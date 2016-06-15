using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_MatrixReadingPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            //building
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            var matrix = new char[rows, cols];
            char letter = 'A';
            for (int row = 0; row < rows; row++)
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = letter++;

            // Build the matrix with the text
            //char[,] matrix = new char[rows, cols];
            //for (int row = 0, letter = 0; row < rows; row++)
            //{
            //    for (int col = 0; letter < text.Length && col < cols; col++, letter++)
            //    {
            //        matrix[row, col] = text[letter];
            //    }
            //}

            //reading
            //int rows = int.Parse(Console.ReadLine());
            //int cols = int.Parse(Console.ReadLine());
            //var matrix = new int[rows, cols];
            //for (int row = 0; row < rows; row++)
            //{
            //    var cells = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //    for (int col = 0; col < cols; col++)
            //        matrix[row, col] = cells[col];
            //}

            //printing
            //    for (int i = 0; i < length; i++)
            //    {
            //        for (int j = 0; j < length; j++)
            //        {
            //            Console.Write(matrix[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
        }
    }
}

