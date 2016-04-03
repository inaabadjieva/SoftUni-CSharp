using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiIvanAdventures
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            decimal money = Decimal.Parse(Console.ReadLine());
            decimal litresWanted = Decimal.Parse(Console.ReadLine());
            decimal litersBought = 0.0M;

            switch (day)
            {
                case 0: litersBought = money / 25M; break;
                case 1: litersBought = money / 21M; break;
                case 2: litersBought = money / 14M; break;
                case 3: litersBought = money / 17M; break;
                case 4: litersBought = money / 45M; break;
                case 5: litersBought = money / 59M; break;
                case 6: litersBought = money / 42M; break;

            }


            //if (day == 0) litersBought = money / 25M;
            //else if (day == 1) litersBought = money / 21M;
            //else if (day == 2) litersBought = money / 14M;
            //else if (day == 3) litersBought = money / 17M;
            //else if (day == 4) litersBought = money / 45M;
            //else if (day == 5) litersBought = money / 59M;
            //else if (day == 6) litersBought = money / 42M;

            string status;
            if (litersBought < 1M) status = "sober";
            else if (litersBought <= 1.5M) status = "drunk";
            else status = "very drunk";

            if (litersBought>litresWanted)
                Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends", status, litersBought-litresWanted);
            else if (litersBought == litresWanted)
                Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", status); 
            else if (litersBought < litresWanted)
                Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol", status, litresWanted - litersBought);

        }
    }
}
