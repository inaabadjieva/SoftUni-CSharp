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
            int[] old = new int[array.Length / 2];
            int count = 0;
            for (int i = 0; i < array.Length/4; i++)
			{
                folded[count] = array[array.Length/4 - 1 - i];
                folded[folded.Length - folded.Length / 2 + i] = array[array.Length - 1 - i];

                count++;
			}
            for (int i = 0; i < array.Length/2; i++)
            {
                old[i] = array[array.Length / 4 + i] + folded[i];

            }
            for (int i = 0; i < old.Length; i++)
            {
                Console.Write(old[i] + " ");
            }
        }
    }
}
