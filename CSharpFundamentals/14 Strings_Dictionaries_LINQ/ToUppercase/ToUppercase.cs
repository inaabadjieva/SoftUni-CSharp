using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUppercase
{
    class ToUppercase
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            int start = text.IndexOf("<upcase>");
            int end = text.IndexOf("</upcase>");
            string toUpper = "";
            while (start != -1)
            {
                for (int j = start + 8; j < end; j++)
                {
                    toUpper += text[j];
                }
                toUpper = toUpper.ToUpper();
                text = text.Remove(start, toUpper.Length + 17);
                text = text.Insert(start, toUpper);
                toUpper = "";
                start = text.IndexOf("<upcase>");
                end = text.IndexOf("</upcase>");
            }

            Console.WriteLine(string.Join(" ", text));
        }
    }
}
