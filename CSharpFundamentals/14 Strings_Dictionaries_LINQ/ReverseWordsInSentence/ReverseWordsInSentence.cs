using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsInSentence
{
    class ReverseWordsInSentence
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };

            var words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            words.Reverse();

            //string sep = "";
            string chars = "";
            for (int i = 0; i < words.Count; i++)
            {
                chars += words[i];
            }
            var sep = text.Split(chars.ToArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < words.Count; i++)
            {
                Console.Write(words[i] + sep[i]);
            }
        }
    }
}
