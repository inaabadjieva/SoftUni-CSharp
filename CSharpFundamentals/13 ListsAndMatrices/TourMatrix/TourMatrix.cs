using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourMatrix
{
    class TourMatrix
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            FillInMatrix(matrix, size);

            var routes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
            int sum = 0;
            for (int i = 0; i < routes.Length; i++)
            {
                sum += matrix[start, routes[i]];
                start = routes[i];
            }
            Console.WriteLine(sum);
        }
        static void FillInMatrix(int[,] matrix, int n)
        {
            for (int row = 0; row < n; row++)
            {
                int[] cells = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                    matrix[row, col] = cells[col];
            }
        }
    }
}
