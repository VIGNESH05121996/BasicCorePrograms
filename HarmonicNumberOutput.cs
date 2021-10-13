using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class HarmonicNumberOutput
    {        
        public void HarmonicNumber()
        {
            float har = 1;
            Console.WriteLine("Enter nth value");
            float n = Convert.ToInt32(Console.ReadLine());
            for(float i=2;i<=n;i++)
            {
                har += 1 / i;
                Console.WriteLine("Harmonic:" + har);
            }
        }
    }
}
