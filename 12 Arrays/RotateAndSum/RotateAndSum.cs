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
            int k = int.Parse(Console.ReadLine());
            int[] sumArr = new int[array.Length];
            int[] temp = new int[array.Length];
            for (int i = 0; i < k; i++)
			{
                for (int ii = 0; ii < array.Length; ii++)
                {
                    if (ii == 0)
                    {
                         temp[ii] = array[array.Length - 1];
                    }
                    else {
                        temp[ii] =  array[ii - 1];
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
