﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            if (product == "banana" || product == "apple"|| product == "kiwi"|| product == "cherry"|| product == "lemon"|| product == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "cucumber"|| product == "tomato"||product == "pepper"||product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
