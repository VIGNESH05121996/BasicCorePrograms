using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class FactorsOfNumber
    {
        int prime;
        public void FactorsNum()
        {
            Console.WriteLine("Enter Number To Find Prime factor");
            int num= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("All Prime Factors of" + num);
            for(int i=2;i<=num;i++)
            {
                if(num%i==0)
                {
                    prime = 1;
                    for(int j=2;j<=i/2;j++)
                    {
                        if(i%j==0)
                        {
                            prime = 0;
                            break;
                        }
                    }
                    if(prime==1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
