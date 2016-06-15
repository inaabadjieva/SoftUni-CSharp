using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLettersInString
{
    class CountLettersInString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            int[] count = new int[str.Max() + 1];
            foreach (var letter in str)
            {
                count[letter]++;
            }
            for (char ch = (char)0; ch < count.Length; ch++)
            {
                if (count[ch] != 0)
                    Console.WriteLine($"{ch} -> {count[ch]}");
            }
        }
    }
}
