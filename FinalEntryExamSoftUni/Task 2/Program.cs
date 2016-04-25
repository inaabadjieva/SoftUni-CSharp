using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int players = int.Parse(Console.ReadLine());

            int maxScores = int.MinValue;
            string winningName = "";

            for (int i = 0; i < players; i++)
            {
                string name = Console.ReadLine();
                int initialScore = int.Parse(Console.ReadLine());
                foreach (var letter in name)
                {
                    if (letter % 2 == 0)
                        initialScore += letter;
                    else
                        initialScore -= letter;
                }
                if (initialScore > maxScores)
                {
                    winningName = name;
                    maxScores = initialScore;
                } 
            }
            Console.WriteLine("The winner is {0} - {1} points", winningName, maxScores);
        }
    }
}
