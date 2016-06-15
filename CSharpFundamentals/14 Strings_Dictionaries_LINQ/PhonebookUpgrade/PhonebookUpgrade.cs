using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();
            var input = Console.ReadLine().Split(' ');
            while (!input.Contains("END"))
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
                else if (input.Contains("ListAll"))
                {
                    foreach (var pair in phonebook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }
                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
