using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLParser
{
    class URLParser
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string protocol = "";
            string server = "";
            string resource = "";
            int index = input.IndexOf("://");
            if (index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    protocol += input[i];
                }
                input = input.Remove(0, index + 3);
            }          
            index = input.IndexOf("/");
            if (index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    server += input[i];
                }
                input = input.Remove(0, index + 1);
                for (int i = 0; i < input.Length; i++)
                {
                    resource += input[i];
                }
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    server += input[i];
                }
            }
            Console.WriteLine(@"[protocol] = ""{0}""", protocol);
            Console.WriteLine(@"[server] = ""{0}""", server);
            Console.WriteLine(@"[resource] = ""{0}""", resource);
        }
    }
}
