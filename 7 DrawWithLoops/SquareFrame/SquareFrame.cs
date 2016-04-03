﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                if (row == 0 || row == n - 1)
                {
                    Console.Write("+");
                    for (int col = 0; col < n - 2; col++)
                    {
                        Console.Write(" -");
                    }
                    Console.Write(" +");
                }
                else
                {
                    Console.Write("|");
                    for (int col = 0; col < n - 2; col++)
                    {
                        Console.Write(" -");
                    }
                    Console.Write(" |");
                }   
                Console.WriteLine();
            }
        }
    }
}
