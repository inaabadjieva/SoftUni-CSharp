﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -1;
            for (int i = 2; i <= 1000; i++)
            {
                a = a * -1;
                int result = 0;
                result += result + a * i;
                Console.WriteLine(result);
            }
        }
    }
}
