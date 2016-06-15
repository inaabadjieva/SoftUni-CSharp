using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            var input = Console.ReadLine().Split(' ');
            while(!input.Contains("END"))
            {
                if (input.Contains("A"))
                {
                    string name = input[1];
                    string number = input[2];
                    if (phonebook.ContainsKey(name))
                    {
                        phonebook[name] = number;
                    }
                    else
                    {
                        phonebook.Add(name, number);
                    }   
                }
                else if (input.Contains("S"))
                {
                    string searched = input[1];
                    string num = "";
                    if (phonebook.TryGetValue(searched, out num))
                    {
                        Console.WriteLine($"{searched} -> {num}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {searched} does not exist.");
                    }
                }
                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
