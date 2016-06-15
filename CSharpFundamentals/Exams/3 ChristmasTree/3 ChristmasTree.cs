using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int mid = 1;
            for (int row = 0; row < n / 2 +1; row++)
            {   
                Console.Write(new string('\'', n - row));
                Console.Write(new string('^', mid));
                mid+=2;
                Console.WriteLine(new string('\'', n - row));   
            }
            int mid1 = 3;
            for (int row = 1; row <= n / 2 + 1; row++)
            {
                Console.Write(new string('\'', n - row));
                Console.Write(new string('^', mid1));
                mid1 += 2;
                Console.WriteLine(new string('\'', n - row));
            }
            for (int i = 0; i < n/2 + 1; i++)
            {
                Console.Write(new string('\'', n - 1));
                Console.Write("| |");
                Console.WriteLine(new string('\'', n - 1));
            }
            Console.WriteLine(new string('-', 2*n +1));
        }
    }
}
