using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FootballStanding
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            var countryPoints = new Dictionary<string, long>();
            var countryGoals = new Dictionary<string, long>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "final")
                {
                    break;
                }
                var info = input.Split(' ').ToList();

                var team1 = FindTeam(info[0], key).ToUpper();
                var team2 = FindTeam(info[1], key).ToUpper();
                var results = info[2].Split(':').Select(int.Parse).ToList();
                var team1Result = results[0];
                var team2Result = results[1];              
                //first team
                if (countryPoints.ContainsKey(team1))
                    countryPoints[team1] += CalculatePoints(team1Result, team2Result);
                else
                    countryPoints.Add(team1, CalculatePoints(team1Result, team2Result));

                if (countryGoals.ContainsKey(team1))
                    countryGoals[team1] += team1Result;
                else
                    countryGoals.Add(team1, team1Result);

                //second team
                if (countryPoints.ContainsKey(team2))
                    countryPoints[team2] += CalculatePoints(team2Result, team1Result);
                else
                    countryPoints.Add(team2, CalculatePoints(team2Result, team1Result));

                if (countryGoals.ContainsKey(team2))
                    countryGoals[team2] += team2Result;
                else
                    countryGoals.Add(team2, team2Result);
            }
            Console.WriteLine("League standings:");
            var result = countryPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            int number = 1;
            foreach (var pair in result)
            {
                Console.WriteLine("{0}. {1} {2}", number, pair.Key, pair.Value);
                number++;
            }
            
            Console.WriteLine("Top 3 scored goals:");
            if (countryGoals.Count >= 3)
            {
                var top3 = countryGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3);
                foreach (var pair in top3)
                {
                    Console.WriteLine("- {0} -> {1}", pair.Key, pair.Value);
                }
            }
            else
            {
                var top = countryGoals.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).Take(3);
                foreach (var pair in top)
                {
                    Console.WriteLine("- {0} -> {1}", pair.Key, pair.Value);
                }
            }
        }

        private static long CalculatePoints(long result1, long result2)
        {
            long points = 0;
            if(result1 > result2)
            {
                points = 3;
            }
            else if (result1 == result2)
            {
                points = 1;
            }
            else if(result1 < result2)
            {
                points = 0;
            }
            return points;
        }

        public static string FindTeam(string t, string key)
        {
            int index = t.IndexOf(key) + key.Length;
            var temp = t.Substring(index);
            index = temp.IndexOf(key);
            var team = "";
            for (int i = index - 1; i >= 0; i--)
            {
                team += temp[i];
            }
            return team;
        }
    }
}
