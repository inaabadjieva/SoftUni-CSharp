﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            do
            {
                num = num * n;
                n--;
            }
            while (n > 1);
            Console.WriteLine(num);
        }
    }
}
