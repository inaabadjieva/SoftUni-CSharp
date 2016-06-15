using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourExam = int.Parse(Console.ReadLine());
            var minutesExam = int.Parse(Console.ReadLine());
            var hourComing = int.Parse(Console.ReadLine());
            var minutesComing = int.Parse(Console.ReadLine());

            var late = (hourComing * 60 + minutesComing) > (hourExam * 60 + minutesExam);
            var onTime = (hourComing * 60 + minutesComing) == (hourExam * 60 + minutesExam) || 
                ((hourExam * 60 + minutesExam) - (hourComing * 60 + minutesComing)) <= 30;
            var early = (hourExam * 60 + minutesExam) - (hourComing * 60 + minutesComing);
            var timeExam = hourExam * 60 + minutesExam;
            var timeComing = hourComing * 60 + minutesComing;

            


            if (late)
            {
                Console.WriteLine("Late");

                if (timeComing - timeExam < 60)
                    Console.WriteLine(timeComing - timeExam + " minutes after the start");

                else if (timeComing - timeExam >= 60)
                {
                  
                    var hourlate = (timeComing - timeExam) / 60;
                    var minuteslate = (timeComing - timeExam) % 60;

                    if (minuteslate < 10)
                        Console.WriteLine(hourlate + ":0" + minuteslate + " hours after the start");
                    else
                        Console.WriteLine(hourlate + ":" + minuteslate + " hours after the start");
                }

            }
       
            else if (timeExam == timeComing || timeExam - timeComing <= 30)
            {
                Console.WriteLine("On time");
                if (timeExam - timeComing <= 30)
                {
                    Console.WriteLine(timeExam - timeComing + " minutes before the start");
                }
            }

            else if (timeExam - timeComing > 30)
            {
                Console.WriteLine("Early");

                if (timeExam - timeComing  < 60)
                    Console.WriteLine(timeExam - timeComing + " minutes before the start");
                else if (timeExam - timeComing >= 60)
                {
                    

                    var hourlate = (timeExam - timeComing) / 60;
                    var minuteslate = (timeExam - timeComing) % 60;

                    if (minuteslate < 10)
                        Console.WriteLine(hourlate + ":0" + minuteslate + " hours before the start");
                    else
                        Console.WriteLine(hourlate + ":" + minuteslate + " hours before the start");
                }
            }
            
        }
    }
}
