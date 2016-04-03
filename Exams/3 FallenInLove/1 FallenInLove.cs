using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FallenInLove
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char symbol = '#';
            int leafspace = 0;
            int insidespace = 2 * n;
            int middlespace = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}", symbol, new string('~',leafspace), new string('.',insidespace),new string('.',middlespace));
                leafspace ++;
                middlespace +=2;
                insidespace -= 2;
            }

            int outspace = 1;
            
            for (int i = 0; i < n; i++)
			{
			  Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string('.',outspace),symbol, new string('~',leafspace), new string('.',middlespace));
                outspace += 2;
                leafspace--;
                middlespace -= 2;
			}
            Console.WriteLine("{0}{1}{0}", new string('.', n * 2 + 1), new string('#', 4));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{1}{0}", new string('.', n * 2 + 2), symbol);
            }

        }
    }
}
