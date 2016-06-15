using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexInDecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int decNum = Convert.ToInt32(hex, 16);
            Console.WriteLine(decNum);
        }
    }
}
