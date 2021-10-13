using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class PowerOfTwo
    {
        public void PowerTwo()
        {
            Console.WriteLine("Enter 2^n's nth value");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i=1;i<=n;i++)
            {
                double a = Math.Pow(2, i);
                Console.WriteLine(+ a);

            }
        }
    }
}
