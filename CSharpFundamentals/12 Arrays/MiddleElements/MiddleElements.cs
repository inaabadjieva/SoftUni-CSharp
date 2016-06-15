using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleElements
{
    class MiddleElements
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = array.Length/2 - 1;
            int end = start + 2;
            if(array.Length == 1) start = end = 0;
            else if(array.Length % 2 == 0) end--;

            int[] mid = new int[end - start + 1];
            int counter = 0;
            for (int i = start; i <= end; i++)
            {
               mid[counter] = array[i];
               counter++;
            }
            for (int i = 0; i < mid.Length; i++)
                Console.Write(mid[i]+" ");
        }
    }
}
