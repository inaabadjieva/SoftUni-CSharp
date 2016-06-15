using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int index1 = int.Parse(Console.ReadLine());
            int index2 = int.Parse(Console.ReadLine());
            Console.Write((char)index1);
            for (int i = index1 + 1; i <= index2; i++)
            {
                Console.Write($" {(char)i}");
            }
            Console.WriteLine();
        }
    }
}
