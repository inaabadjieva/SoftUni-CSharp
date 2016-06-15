using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] folded = new int[array.Length / 2];
            int[] sum = new int[array.Length / 2];
            
            for (int i = 0; i < array.Length/4; i++)
			{
                folded[i] = array[array.Length/4 - 1 - i];
                folded[folded.Length - folded.Length / 2 + i] = array[array.Length - 1 - i];
			}

            for (int i = 0; i < array.Length/2; i++)
            {
                sum[i] = array[array.Length / 4 + i] + folded[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
