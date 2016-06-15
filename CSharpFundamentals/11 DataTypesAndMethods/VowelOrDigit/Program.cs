using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            bool isDigit = Char.IsDigit(symbol);
            bool isVowel = false;
            switch (symbol)
            {
                case 'a': isVowel = true; break;
                case 'e': isVowel = true; break;
                case 'i': isVowel = true; break;
                case 'u': isVowel = true; break;
                case 'o': isVowel = true; break;
                case 'y': isVowel = true; break;    
              
            }
            if (isDigit) Console.WriteLine("digit");
            else if (isVowel) Console.WriteLine("vowel");
            else Console.WriteLine("other");
        }
    }
}
