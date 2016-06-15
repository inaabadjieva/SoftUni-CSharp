using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace HourglassSum
{
    class HourglassSum
    {
        static void Main(string[] args)
        {
            var matrix = new long[6, 6];

            ReadingMatrix(matrix);
            long result = CalculateSum(matrix);
            Console.WriteLine(result);
        }

        private static long CalculateSum(long[,] matrix)
        {
            long maxSum = long.MinValue;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    long sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (i == 1 && j == 0 || i == 1 && j == 2)
                            {
                                continue;
                            }
                            else
                            {
                                sum += matrix[row + i, col + j];
                            }   
                        }
                    }
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }  
                }
            }
            return maxSum;
        }

        public static long[,] ReadingMatrix(long[,] matrix)
        {
            for (int row = 0; row < 6; row++)
            {
                var cells = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                for (int col = 0; col < 6; col++)
                {
                    matrix[row, col] = cells[col];
                }
            }
            return matrix;
        }
    }
}
