using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestIncreasingSubsequence
{
    private static int[] GetLongestIncreasingSubsequence(int[] array, out int length, out int end)
    {
        // This variable saves the length of the longest 
        // increasing subsequence satisfying the condition
        // i < j and array[i] <= array[j] 
        int maxi = 0;

        // This variable saves the length of the longest 
        // increasing subsequence across all (j) values.
        int maxj = 0;

        // This variable points to the (j) value at which 
        // the longest increasing subsequences ends. 
        // It is going to be the start point to print the
        // individual elements in the solution using back
        // pointers array b[j]
        end = 0;

        int n = array.Length;
        int[] L = new int[n];
        int[] b = new int[n];

        // The length of the increasing subsequence 
        // ending at position (1) is also (1) because it only 
        // contains one number which is array[1]
        L[0] = 1;

        // We already initialized L(1) so we compute the 
        // rest of L(j) values as (j) goes from (2) to (n)
        for (int j = 1; j < n; j++)
        {
            // Recall that b[j] points to the array 
            // element in (array) from which the current 
            // subsequence was extended so we initially 
            // set b[j] = j in case the current sequence 
            // was not extended (started new sequence) 
            // then we update that later in case it was 
            // indeed extended
            b[j] = j;

            // For all i < j find the longest 
            // increasing sub sequence from which the 
            // current sequence ending at (j) was extended 
            for (int i = 0; i < j; i++)
            {
                // Pay attention here. We have two conditions.
                // The first condition array[i] <= array[j] is used to
                // make sure the sequence ending at (j) is indeed
                // increasing by extending a previous subsequence
                // ending at some position (i). The second condition
                // L(i) > maxi is used to find the longest increasing
                // subsequence from which to extend the current sequence
                // at (j).
                if (array[i] <= array[j] && L[i] > maxi)
                {
                    // Update maxi whenever a longer 
                    // subsequence is found
                    maxi = L[i];

                    // Save the (i) value at which the 
                    // longest sub sequence was found
                    // This (i) value is a back pointer
                    // needed to construct the actual solution
                    b[j] = i;
                }
            }

            // Refer back to the explanation at the 
            // beginning of the article. We showed that
            // L(j) = 1 + Max (L(i)) where i < j and A[i] <= A[j]
            L[j] = 1 + maxi;

            // Reset the variable maxi for the next (j) value
            maxi = 0;

            // Just populating L(j) is not the solution however 
            // we need to find the largest value in L(j)
            if (L[j] >= maxj)
            {
                // Keep updating until we get the largest value
                maxj = L[j];

                // Save the (j) value at which the longest 
                // increasing subsequence (the solution we 
                // are looking for) ends. This value is used 
                // as the start point to generate the actual 
                // solution using back pointers.
                end = j;
            }
        }

        length = maxj;
        return b;
    }

    static void Main()
    {
        string numberN;
        int n;


        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int length;
        int end;
        int[] indices = GetLongestIncreasingSubsequence(numbers, out length, out end);

        Console.WriteLine("Longest increasing subsequence length = {0}", length);
        Console.Write("Elements of the longest increasing subsequence: ");
        int j;
        List<int> sequenceElements = new List<int>();

        // Start at the (j) position (end variable) at 
        // which the longest increasing subsequence
        // ends then trace back using the array b[j].
        // Recall that for each value (j) there is a 
        // b[j] value that points to the previous 
        // subsequence from which the current 
        // sequence was extended
        for (j = end; j > 1 && j != indices[j]; j = indices[j])
        {
            sequenceElements.Add(numbers[j]);
        }

        sequenceElements.Add(numbers[j]);

        if (j != indices[j])
        {
            // The last element in the solution is 
            // printed alone to prevent the previous 
            // loop from going infinite.
            sequenceElements.Add(numbers[indices[j]]);
        }

        sequenceElements.Reverse();
        Console.WriteLine(String.Join(", ", sequenceElements.ToArray()));
    }
}