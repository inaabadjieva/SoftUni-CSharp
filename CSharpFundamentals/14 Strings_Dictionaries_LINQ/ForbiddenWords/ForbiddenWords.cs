using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbidenWords
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var forbidden = Console.ReadLine().Split(' ');
            foreach (var word in forbidden)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
