using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProcesses
{
    class PhoneProcesses
    {
        static void Main(string[] args)
        {
            string batteryPercentage = Console.ReadLine();
            batteryPercentage = batteryPercentage.Replace("%", "");
            int battery = int.Parse(batteryPercentage);
            
            bool needRecharge = false;
            bool phoneOff = false;
            int count = 0;
            

            if (battery <= 0) phoneOff = true;
            else if (battery <= 15) needRecharge = true;
            
            string app = Console.ReadLine();
            while (app.ToLower() != "end")
            {
                int percentage = int.Parse(app.Substring(app.Length - 3, 2));
                if (battery - percentage <= 0) 
                {
                    phoneOff = true;
                    count++;
                }
                else if (battery - percentage <= 15)
                {
                    needRecharge = true;
                    battery -= percentage;
                    app = Console.ReadLine();
                    continue;
                }
                else
                {
                    battery -= percentage;
                }
                
                app = Console.ReadLine();

            }
            if (needRecharge == true)
            {
                Console.WriteLine("Connect charger -> {0}%", battery);
                Console.WriteLine("Programs left -> {0}", count);
            }
            else if (phoneOff == true)
            {
                Console.WriteLine("Phone Off");
            }
            else
            {
                Console.WriteLine("Successful complete -> {0}%", battery);
            }

        }
    }
}
