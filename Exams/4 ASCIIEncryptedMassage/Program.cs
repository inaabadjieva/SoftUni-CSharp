using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ASCIIEncryptedMassage
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input.ToLower() != "start")
            {
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            int countMessages = 0;
            string encryptedMessage = string.Empty;

            while (input.ToLower() != "end")
            {
                if (string.IsNullOrWhiteSpace(input))
                {

                    input = Console.ReadLine();
                    continue;
                }
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    char currentSymbol = input[i];
                    if (('a' <= currentSymbol && currentSymbol <= 'm') || ('A' <= currentSymbol && currentSymbol <= 'M'))
                    {
                        encryptedMessage += (char)(currentSymbol + 13);
                    }
                    else if (('n' <= currentSymbol && currentSymbol <= 'z') || ('N' <= currentSymbol && currentSymbol <= 'Z'))
                    {
                        encryptedMessage += (char)(currentSymbol - 13);
                    }
                    else if ('0' <= currentSymbol && currentSymbol <= '9')
                    {
                        encryptedMessage += currentSymbol;
                    }
                    else
                    {
                        switch (currentSymbol)
                        {
                            case ' ':
                                encryptedMessage += '+';
                                break;
                            case ',':
                                encryptedMessage += '%';
                                break;
                            case '.':
                                encryptedMessage += '&';
                                break;
                            case '?':
                                encryptedMessage += '#';
                                break;
                            case '!':
                                encryptedMessage += '$';
                                break;
                        }
                    }
                }
                encryptedMessage += Environment.NewLine;
                countMessages++;

                input = Console.ReadLine();
            }

            if (countMessages == 0)
            {
                Console.WriteLine("No messages sent.");
            }
            else
            {
                Console.WriteLine("Total number of messages: {0}", countMessages);

                Console.Write(encryptedMessage);
            }
        }
    }
}
