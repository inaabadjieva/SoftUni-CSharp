using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DrawDNA_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            uint length = uint.Parse(Console.ReadLine());
            char letter = char.Parse(Console.ReadLine());

            char spaceChar = '.';
            
            int mid = 7/2;
            int diff = 0;
            int diffCount = 0;
            
            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (col >= mid-diff && col <= mid+diff)
                    {
                        Console.Write(letter);
                        if (letter == 'G') letter = 'A';
                        else letter++;
                    }
                    else Console.Write(spaceChar);
                }
                if (diffCount >= mid)
                    diff--;
                else
                    diff++;

                diffCount++;

                if (diffCount == 7)
                {
                    diffCount = 0;
                    diff++;
                }
              
                Console.WriteLine();
            }
            
        }
    }
}
