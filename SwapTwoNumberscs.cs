using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class SwapTwoNumberscs
    {

        int a = 10;
        int b = 20;
        int temp;
        public void Displaynum()
        {
            Console.WriteLine("Value Before Swapping");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
        public void SwapNum()
        {
            temp = a;
            a = b;
            b = temp;
        }
        public void SwappedOutput()
        {
            Console.WriteLine("Swapping Number Process Done");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
    }
}
