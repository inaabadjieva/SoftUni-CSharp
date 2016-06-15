using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] sumArr = new int[array.Length];
            int[] temp = new int[array.Length];
            for (int i = 0; i < rotations; i++)
			{
                for (int j = 0; j < array.Length; j++)
                {
                    if (j == 0)
                    {
                         temp[j] = array[array.Length - 1];
                    }
                    else
                    {
                        temp[j] =  array[j - 1];
                    }                   
                }

                Array.Copy(temp, array, temp.Length);

                for (int a = 0; a < sumArr.Length; a++)
                {
                    sumArr[a] += temp[a];
                }
			}
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
