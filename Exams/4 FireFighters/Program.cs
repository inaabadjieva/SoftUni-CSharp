using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FireFighters
{
    class Program
    {
        static void Main(string[] args)
        {
            int fireFighters = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int kids = 0;
            int adults = 0;
            int seniors = 0;

            while (input != "rain")
            {
                int remainingFireFighters = fireFighters;
                int priorityPerson = 1;
                while (remainingFireFighters > 0 && priorityPerson <= 3)
                {
                    foreach (char t in input)
                    {
                        if (remainingFireFighters <= 0)
                        {
                            break;
                        }
                        switch (priorityPerson)
                        {
                            case 1:
                                if (t == 'K')
                                {
                                    kids++;
                                    remainingFireFighters--;
                                }
                                break;
                            case 2:
                                if (t == 'A')
                                {
                                    adults++;
                                    remainingFireFighters--;
                                }
                                break;
                            case 3:
                                if (t == 'S')
                                {
                                    seniors++;
                                    remainingFireFighters--;
                                }
                                break;
                        }
                    }
                    priorityPerson++;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Kids: {0}", kids);
            Console.WriteLine("Adults: {0}", adults);
            Console.WriteLine("Seniors: {0}", seniors);
        }
    }
}
