using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnswers
{
    class EncodedAnswers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = null;
            uint countA = 0;
            uint countB = 0;
            uint countC = 0;
            uint countD = 0;

            for (int i = 0; i < n; i++)
            {
                uint answerAsNumber = uint.Parse(Console.ReadLine());
                string answer;

                if (answerAsNumber % 4 == 0)
                {
                    answer = "a";
                    countA++;
                }
                else if (answerAsNumber % 4 == 1)
                {
                    answer = "b";
                    countB++;
                }
                else if (answerAsNumber % 4 == 2)
                {
                    answer = "c";
                    countC++;
                }
                else
                {
                    answer = "d";
                    countD++;
                }

                result += answer + ' ';
            }

            Console.WriteLine(result);
            Console.WriteLine("Answer A: " + countA);
            Console.WriteLine("Answer B: " + countB);
            Console.WriteLine("Answer C: " + countC);
            Console.WriteLine("Answer D: " + countD);

            //Console.WriteLine("Answer A: {0}\nAnswer B: {1}\nAnswer C: {2}\nAnswer D: {3}", countA, countB, countC, countD);
        }                
    }
}
