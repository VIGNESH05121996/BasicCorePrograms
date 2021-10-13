using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class FlipCoinHeadTail
    {
        public void FlipCoin()
        {

            int t = 0, h = 0;
            Console.WriteLine("Enter How Many Times Need To Flip The Coin");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                double f = random.Next(0, 1);
                if (f < 0.5)
                {
                    t++;
                }
                else
                {
                    h++;
                }
        }
            int heads = ((h / n) * 100);
            int tails = ((t / n) * 100);
            Console.WriteLine("Percentage of Heads" + heads);
            Console.WriteLine("Percentage of Tails" + tails);
        }

    }
}