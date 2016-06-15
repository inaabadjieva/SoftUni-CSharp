using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurrenciesInString
{
    class OccurrenciesInString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            int count = 0;
            var pos = -1;
            while (true)
            {
                pos = str.IndexOf(word, pos + 1);
                if (pos == -1) break;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
