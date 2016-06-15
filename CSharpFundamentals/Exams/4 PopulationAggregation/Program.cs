using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PopulationAggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var countries = new Dictionary<string, int>();
            var cities = new Dictionary<string, long>();

            while (input != "stop")
            {
                var data = input.Split('\\').ToList();
                long population = long.Parse(data[2]);
                var towns = new List<string>();
                var word = "";
                var city = "";
                var country = "";
                for (int i = 0; i < data.Count - 1; i++)
                {
                    for (int j = 0; j < data[i].Length; j++)
                    {
                        if (char.IsLetter(data[i][j]))
                            word += data[i][j];
                    }
                    if (char.IsLower(word[0]))
                    {
                        city = word;
                    }
                    else if (char.IsUpper(word[0]))
                    {
                        country = word;
                    }
                    word = "";               
                }

                if (cities.ContainsKey(city))
                    cities[city] = population;
                else
                    cities.Add(city, population);

                if (countries.ContainsKey(country))
                    countries[country] += 1;
                else
                    countries.Add(country, 1);

                input = Console.ReadLine();
            }

            var orderedCountries = countries.OrderBy(x => x.Key);
            foreach (var pair in orderedCountries)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }

            var orderedCities = cities.OrderByDescending(x => x.Value).Take(3);
            foreach (var pair in orderedCities)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
