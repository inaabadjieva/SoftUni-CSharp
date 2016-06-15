using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MaxPlatform3x3
{
    class MaxPlatform3x3
    {
        static void Main(string[] args)
        {
            var rowsCols = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long rows = rowsCols[0];
            long cols = rowsCols[1];
            var matrix = new long[rows, cols];

            //reading the matrix
            for (long row = 0; row < rows; row++)
            {
                var cells = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                for (long col = 0; col < cols; col++)
                {
                    matrix[row, col] = cells[col];
                }
            }

            //algorithm
            long maxSum = long.MinValue;
            var result = new long[3, 3];

            for (long row = 0; row < rows - 2; row++)
            {               
                for (long col = 0; col < cols - 2; col++)
                {
                    long sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sum += matrix[row + i, col + j];
                        }
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                               result[i, j] = matrix[row + i, col + j];
                            }
                        }
                    }
                }  
            }

            Console.WriteLine(maxSum);
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(result[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
