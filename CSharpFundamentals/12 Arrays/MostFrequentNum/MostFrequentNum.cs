using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNum
{
    class MostFrequentNum
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
            int bestCount = 0;
            int num = 0;
            int bestNum = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                num = array[i];
               
                for (int j = 0; j < array.Length; j++)
                {
                    if (num == array[j])
                    {
                        count++;
                    }   
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestNum = num;
                }
            }
            Console.WriteLine(bestNum);
        }
    }
}
