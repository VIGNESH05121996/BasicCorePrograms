using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class LargestNumber
    {
        public void LarNum()
        {
            Console.WriteLine("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third Number");
            int c = Convert.ToInt32(Console.ReadLine());

            if(a>b && a>c)
            {
                Console.WriteLine("First Number Is Largest");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("Second Number Is Largest");
            }
            else
            {
                Console.WriteLine("Third Number Is Largest");
            }
        }
    }
}
