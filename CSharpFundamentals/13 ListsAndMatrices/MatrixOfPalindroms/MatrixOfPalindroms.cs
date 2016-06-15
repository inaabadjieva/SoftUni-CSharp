using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindroms
{
    class MatrixOfPalindroms
    {
        static void Main(string[] args)
        {
            var dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];
            var matrix = new string[rows, cols];
            char letter = 'a';
            for (int row = 0; row < rows; row++)
            {
                char middleLetter = letter;
                for (int col = 0; col < cols; col++)
                {
                   Console.Write( string.Format("{0}{1}{2} ", letter, middleLetter, letter));
                   middleLetter++;
                }
                letter++;
                Console.WriteLine();
            }
        }
    }
}
