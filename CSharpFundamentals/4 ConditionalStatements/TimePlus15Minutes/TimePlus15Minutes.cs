using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var newminutes = minutes + 15;
            
            var hours = newminutes / 60;
            hour = hour + hours;
            if (hour > 23)
            {
                hour -= 24;
            }

            newminutes = newminutes % 60;

            if (newminutes < 10)
            {
                Console.WriteLine(hour + ":0" + newminutes);
            }
            else
            {
                Console.WriteLine(hour + ":" + newminutes);
            }
           

        }
    }
}
