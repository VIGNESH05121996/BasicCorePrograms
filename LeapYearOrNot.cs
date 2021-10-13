using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class LeapYearOrNot
    {
        public void LeapYear()
        {
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if((year%4)==0)
            {
                Console.WriteLine("Entered Year is Leap Year");
            }
            else if((year%100)==0)
            {
                Console.WriteLine("Entered Year Is Leap Year");
            }
            else if ((year%400)==0)
            {
                Console.WriteLine("Entered is Not Leap Year");
            }

        }
    }
}
