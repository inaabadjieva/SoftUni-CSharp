using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCalorieIntake
{
    class DailyCalorieIntake
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine()) / 2.2;
            double height = double.Parse(Console.ReadLine()) * 2.54;
            double age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            int workouts = int.Parse(Console.ReadLine());
            double BMR = 0;
            double DCI = 0;
            if (gender == "m")
                BMR = 66.5 + (13.75 * weight) + (5.003 * height) - (6.755 * age);
            else
                BMR = 655 + (9.563 * weight) + (1.850 * height) - (4.676 * age);

            if (workouts <= 0) DCI = BMR * 1.2;
            else if (workouts >= 1 && workouts <= 3) DCI = BMR * 1.375;
            else if (workouts >= 4 && workouts <= 6) DCI = BMR * 1.55;
            else if (workouts >= 7 && workouts <= 9) DCI = BMR * 1.725;
            else if (workouts > 9) DCI = BMR * 1.9;

            Console.WriteLine(Math.Floor(DCI));
        }
    }
}
