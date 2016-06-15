using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            var text = Console.ReadLine().Split('.', '!', '?').ToArray();
            for (int i = 0; i < text.Length; i++)
            {
                string sentence = text[i];
                string testSentence = sentence;
                for (int j = 0; j < testSentence.Length; j++)
                {
                    if (!char.IsLetter(testSentence[j]))
                    {
                        testSentence = testSentence.Replace(sentence[j], ' ');
                    }
                }

                var words = testSentence.Split(' ');
                var result = new List<string>();
                foreach (var word in words)
                {
                    result.Add(word);
                }

                if (result.Contains(key))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
