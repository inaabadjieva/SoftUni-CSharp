using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalization
{
    class Capitalization
    {
        static void Main(string[] args)
        {
            var separators = new char[] { ' ', ',', '.', '?', '!', ';' };
            var input = Console.ReadLine().Split(separators).ToArray();
            string firstLetter = "";
            string rest = "";
            string words = "";
            foreach (var word in input)
            {               
                for (int i = 0; i < 1; i++)
                {
                    firstLetter = word[i].ToString().ToUpper();
                }
                for (int i = 1; i < word.Length; i++)
                {
                    rest += word[i];
                }
                Console.Write(firstLetter + rest+ " ");
                rest = "";
            }
        }
    }
}
