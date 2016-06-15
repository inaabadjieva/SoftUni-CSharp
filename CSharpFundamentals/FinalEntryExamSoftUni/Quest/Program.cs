using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace _4_TrifonQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            long points = long.Parse(Console.ReadLine());
            var dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var rows = dimentions[0];
            var cols = dimentions[1];

            //Reading
            var matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string cells = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = cells[col];
                }
            }

            int turns = 0;
            for (int col = 0; col < cols; col++)
            {
                char letter;
                if (col % 2 == 0)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        letter = matrix[row, col];
                        if (row != rows - 1)
                        {

                        }
                        
                        if (points <= 0)
                        {
                            Console.WriteLine("Died at: [{0}, {1}]", row, col);
                            break;
                        }
                        turns++;
                    }
                    letter = matrix[col, rows - 1];
                    switch (letter)
                    {
                        case 'F':
                            points -= turns / 2;
                            break;
                        case 'H':
                            points += turns / 3;
                            break;
                        case 'T':
                            turns += 2;
                            break;
                        case 'E':
                            turns++;
                            break;
                    }
                    if (points <= 0)
                    {
                        Console.WriteLine("Died at: [{0}, {1}]", row, col);
                        break;
                    }
                    turns++;
                }
                else
                {
                    for (int row = rows - 1; row >= 0; row--)
                    {
                        letter = matrix[row, col];
                        switch (letter)
                        {
                            case 'F':
                                points -= turns / 2;
                                break;
                            case 'H':
                                points += turns / 3;
                                break;
                            case 'T':
                                turns += 2;
                                break;
                            case 'E':
                                row--;
                                turns++;
                                break;
                        }
                        
                        if (points <= 0)
                        {
                            Console.WriteLine("Died at: [{0}, {1}]", row, col);
                            break;
                        }
                        turns++;
                    }
                }
            }
            if (points > 0)
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine($"Health: {points}");
                Console.WriteLine($"Turns: {turns}");
            }
        }

        private static void PrintingIfDie(long points, int row, int col)
        {
            throw new NotImplementedException();
        }
    }
}
