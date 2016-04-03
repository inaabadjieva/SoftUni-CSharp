using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PlaidTowel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char background = char.Parse(Console.ReadLine());
            char rhombus = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}{1}{0}", new string(background,n),rhombus,new string(background,2*n-1));

            int outside = n-1;
            int inside = 1;
            int between = 2 * n - 3;

            for (int i = 0; i < n - 1; i++)
			{
			    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(background,outside),rhombus, new string(background,inside),new string(background,between));
                outside --;
                inside +=2;
                between -=2;
			}

            Console.WriteLine("{0}{1}{0}{1}{0}", rhombus, new string(background,inside));

            for (int j = 0; j < n-1; j++)
            {
                outside++;
                inside -= 2;
                between += 2; 
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(background, outside), rhombus, new string(background, inside), new string(background, between));
            }
            Console.WriteLine("{0}{1}{2}{1}{0}", new string(background, n), rhombus, new string(background, 2 * n - 1));
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(background, outside), rhombus, new string(background, inside), new string(background, between));
                outside--;
                inside += 2;
                between -= 2;
            }

            Console.WriteLine("{0}{1}{0}{1}{0}", rhombus, new string(background, inside));

            for (int j = 0; j < n - 1; j++)
            {
                outside++;
                inside -= 2;
                between += 2;
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(background, outside), rhombus, new string(background, inside), new string(background, between));
            }
            Console.WriteLine("{0}{1}{2}{1}{0}", new string(background, n), rhombus, new string(background, 2 * n - 1));
        }
    }
}
