using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestIncreasingSubsequence
{
    private static int[] GetLongestIncreasingSubsequence(int[] array, out int length, out int end)
    {
        int maxi = 0;
        int maxj = 0;
        end = 0;

        int n = array.Length;
        int[] L = new int[n];
        int[] b = new int[n];

        L[0] = 1;

        for (int j = 1; j < n; j++)
        {
            b[j] = j;
            for (int i = 0; i < j; i++)
            {
                if (array[i] <= array[j] && L[i] > maxi)
                {
                    maxi = L[i];
                    b[j] = i;
                }
            }
            L[j] = 1 + maxi;
            maxi = 0;
            if (L[j] >= maxj)
            {
                maxj = L[j];
                end = j;
            }
        }

        length = maxj;
        return b;
    }

    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int length;
        int end;
        int[] indices = GetLongestIncreasingSubsequence(numbers, out length, out end);
        int j;
        List<int> sequenceElements = new List<int>();

        for (j = end; j > 1 && j != indices[j]; j = indices[j])
        {
            sequenceElements.Add(numbers[j]);
        }

        sequenceElements.Add(numbers[j]);

        if (j != indices[j])
        {
            sequenceElements.Add(numbers[indices[j]]);
        }

        sequenceElements.Reverse();
      
        Console.WriteLine(String.Join(" ", sequenceElements.ToArray()));
    }
}
