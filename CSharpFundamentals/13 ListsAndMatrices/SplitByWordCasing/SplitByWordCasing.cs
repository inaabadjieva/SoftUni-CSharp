using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            //var separators = new char[]{',',';',':','.','!','(',')','"','\'','/','\\','[',']'};
            //var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            var text = Console.ReadLine();
            var separators = ";,:.!()\"'/\\[] ".ToArray();
            var words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var lowerCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();

            foreach (var word in words)
	        {
                var lowerLetters = 0;
                var upperLetters = 0;
                foreach (var letter in word)
                {
                    if (char.IsLower(letter)) lowerLetters++;
                    if (char.IsUpper(letter)) upperLetters++;
                }
                if (upperLetters == word.Length)
                    upperCaseWords.Add(word);
                else if (lowerLetters == word.Length)
                    lowerCaseWords.Add(word);
                else
                    mixedCaseWords.Add(word);
	        }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
        }
    }
}
