using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            bool areEqual = false;

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] == arr2[i])
                {
                    continue;
                }
                else
                {
                    if (arr1[i] > arr2[i])
                    {
                        Console.WriteLine(arr1);
                        Console.WriteLine(arr2);
                    }
                    if (arr1[i] > arr2[i])
                    {
                        Console.WriteLine(arr2);
                        Console.WriteLine(arr1);
                    }
                    areEqual = true;
                    break;
                } 
                if (!areEqual)
                {
                    if (arr1.Length < arr2.Length)
                    {
                        Console.WriteLine(arr1);
                        Console.WriteLine(arr2);
                    }
                    else if (arr1.Length > arr2.Length)
                    {
                        Console.WriteLine(arr2);
                        Console.WriteLine(arr1);
                    }
                }
            }
        }
    }
}
