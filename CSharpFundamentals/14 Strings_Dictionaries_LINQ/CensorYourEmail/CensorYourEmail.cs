using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensorYourEmail
{
    class CensorYourEmail
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            var text = Console.ReadLine().Split(' ').ToArray();
            string username = email.Split('@')[0];
            string domain = email.Split('@')[1];
            
            string mail = new string('*', username.Length) + "@" + domain;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == email)
                    text[i] = mail; 
            }
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
