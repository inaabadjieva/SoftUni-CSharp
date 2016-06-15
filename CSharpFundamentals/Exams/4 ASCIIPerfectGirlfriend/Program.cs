using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ASCIIPerfectGirlfriend
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string input = Console.ReadLine();
            while (input != "Enough dates!")
            {
                string[] data = input.Split('\\');
                string dayOfWeek = data[0];
                string phoneNumber = data[1];
                string braSize = data[2];
                string name = data[3];

                int result = 0;
                int number = 0;
                switch (dayOfWeek)
                {
                    case "Monday": number = 1; break;
                    case "Tuesday": number = 2; break;
                    case "Wednesday": number = 3; break;
                    case "Thursday": number = 4; break;
                    case "Friday": number = 5; break;
                    case "Saturday": number = 6; break;
                    case "Sunday": number = 7; break;
                }
                result += number;

                for (int i = 0; i < phoneNumber.Length; i++)
                {
                    result += int.Parse(phoneNumber[i].ToString());
                }

                int braNum = 0;
                var braLetter = braSize[braSize.Length - 1];
                if (braSize.Length == 3)
                    braNum = int.Parse(braSize.Substring(0, 2));
                else if (braSize.Length == 4) 
                        braNum = int.Parse(braSize.Substring(0, 3));

                result += braNum * braLetter;

                char firstLetter = name[0];
                result -= firstLetter * name.Length;

                if (result >= 6000)
                {
                    Console.WriteLine("{0} is perfect for you.", name);
                    count++;
                }
                else
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", name);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(count);
        }
    }
}
