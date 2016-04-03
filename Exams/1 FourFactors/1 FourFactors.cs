using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_FourFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong fieldGoals = ulong.Parse(Console.ReadLine());
            ulong fieldGoalsAttempts = ulong.Parse(Console.ReadLine());
            ulong threePointGoals = ulong.Parse(Console.ReadLine());
            ulong turnovers = ulong.Parse(Console.ReadLine());
            ulong offensiveRebounds = ulong.Parse(Console.ReadLine());
            ulong defensiveRebounds = ulong.Parse(Console.ReadLine());
            ulong freeThrows = ulong.Parse(Console.ReadLine());
            ulong freeThrowsAttempts = ulong.Parse(Console.ReadLine());

            double eFG = (fieldGoals + 0.5 * threePointGoals) / fieldGoalsAttempts;
            double TOV = turnovers/ (fieldGoalsAttempts + 0.44 * freeThrowsAttempts + turnovers);
            double ORB = offensiveRebounds / (offensiveRebounds + defensiveRebounds);
            double FT = freeThrows / fieldGoalsAttempts;

            Console.WriteLine("eFG% {0}", Math.Round(eFG,3));
            Console.WriteLine("TOV% {0}", Math.Round(TOV,3));
            Console.WriteLine("ORB% {0}", Math.Round(ORB,3));
            Console.WriteLine("FT% {0}", Math.Round(FT,3));
        }
    }
}
