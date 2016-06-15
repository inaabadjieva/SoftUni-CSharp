using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = new char[26];
            char first = 'a';
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = first;
                first++;
            }

            var input = Console.ReadLine().ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                int index = Array.IndexOf(alphabet, letter);
                Console.WriteLine($"{letter} -> {index}");
            }
        }
    }
}
