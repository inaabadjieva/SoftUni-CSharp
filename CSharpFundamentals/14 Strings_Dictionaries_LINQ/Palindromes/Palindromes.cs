using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var separators = new char[] { ' ', ',', '.', '?', '!' };
            var text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            var palindromes = new List<string>();
            
            foreach (var word in text)
            {
                bool isPalindrome = true;
                if (word.Length == 1)
                {
                    palindromes.Add(word);
                }
                else
                {
                    for (int i = 0; i < word.Length / 2; i++)
                    {
                        if (word[i] != word[word.Length - i - 1])
                        {
                            isPalindrome = false;
                            continue;
                        }
                    }                            
                    if (isPalindrome)
                    {
                        palindromes.Add(word);
                    }                
                }
            }            
            palindromes.Sort((a, b) => a.CompareTo(b));
            var result = palindromes.Distinct();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
