﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStringLetters
{
    class PrintStringLetters
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                char symbol = str[i];
                Console.WriteLine("str[{0}] -> '{1}'", i, symbol);
            }
        }
        
    }
}
