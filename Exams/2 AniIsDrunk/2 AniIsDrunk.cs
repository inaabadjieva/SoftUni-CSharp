using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_AniIsDrunk
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCabins = int.Parse(Console.ReadLine());
            string lines = Console.ReadLine();

            int currentPosition = 0;
            int totalSteps = 0;
          
            while (lines != "Found a free one!")
            {
                int stepsCount = int.Parse(lines);
                int oldPosition = currentPosition;
                currentPosition = (currentPosition + stepsCount) % numOfCabins;
                int difference = currentPosition - oldPosition;
                
                     
                if (difference > 0) Console.WriteLine("Go {0} steps to the right, Ani.", difference);
                else if (difference < 0) Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(difference));
                else Console.WriteLine("Stay there, Ani.");

                totalSteps += Math.Abs(difference); 
                lines = Console.ReadLine(); 
                
            }
            Console.WriteLine("Moved a total of {0} steps.", totalSteps);
            
        }
    }
}
