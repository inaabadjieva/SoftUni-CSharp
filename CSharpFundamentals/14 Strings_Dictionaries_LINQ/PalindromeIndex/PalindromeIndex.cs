using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIndex
{
    class PalindromeIndex
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string palindrome = "";
            if (IsPalindrome(input))
            {
                Console.WriteLine("-1");
            }
            else
            {
                int index = 0;
                while (true)
                {
                    palindrome = input.Remove(index, 1);
                    if (IsPalindrome(palindrome))
                    {
                        Console.WriteLine(index);
                        break;
                    }
                    index++;
                }
            }  
        }
        public static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
