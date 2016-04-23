﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_BitsMatrixBombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] canvas = new int[10];

            for (int row = 0; row < 10; row++)
            {
                canvas[row] = 1023; // 10 1s in binary
            }

            string currentShot = Console.ReadLine();
            bool isWhite = false;

            while (currentShot != "End")
            {
                string[] shotDetails = currentShot.Split();

                int shotRowCenter = int.Parse(shotDetails[0]);
                int shotColCenter = int.Parse(shotDetails[1]);
                int shotRadius = int.Parse(shotDetails[2]);

                int startCol = Math.Max(shotColCenter - shotRadius, 0);
                int endCol = Math.Min(shotColCenter + shotRadius, 9);
                int startRow = Math.Max(shotRowCenter - shotRadius, 0);
                int endRow = Math.Min(shotRowCenter + shotRadius, 9);

                int maskSize = endCol - startCol + 1;
                int mask = (1 << maskSize) - 1;

                for (int i = startRow; i <= endRow; i++)
                {
                    if (isWhite)
                    {
                        canvas[i] |= mask << startCol;
                    }
                    else
                    {
                        canvas[i] &= ~(mask << startCol);
                    }
                }

                isWhite = !isWhite;
                currentShot = Console.ReadLine();
                //PrintMatrix(canvas);
            }

            int sum = canvas.Sum();
            Console.WriteLine(sum);
        }
    }
}
