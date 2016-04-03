using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length/2; i++)
            {
                var oldElement = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = oldElement;
            }
                Console.WriteLine(string.Join(" ", array));
        }
    }
}
