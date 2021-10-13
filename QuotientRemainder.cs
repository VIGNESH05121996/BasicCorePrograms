using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class QuotientRemainder
    {
        public void QuotRem()
        {
            Console.WriteLine("Enter Divident");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quotient:" + divident / divisor);
            Console.WriteLine("Remainder:" + divident % divisor);
        }
    }
}
