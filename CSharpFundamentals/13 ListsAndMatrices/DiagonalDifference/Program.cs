using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                var rowValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rowValues[j];
                }
            }
            int leftDiagonal = 0;
            int rightDiagonal = 0;

            //left diagonal
            int row = 0;
            int col = 0;
            for (int i = 0; i < n; i++)
            {
                leftDiagonal += matrix[row, col];
                row++;
                col++;
            }
            //right diagonal
            row = 0;
            col = n -1;
            for (int i = 0; i < n; i++)
            {
                rightDiagonal += matrix[row, col];
                row++;
                col--;
            }
            Console.WriteLine(Math.Abs(rightDiagonal-leftDiagonal));
        }
    }
}
