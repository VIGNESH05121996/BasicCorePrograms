using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class VowelOrConstant
    {
        char vowel;
        public void VowCon()
        {
            Console.WriteLine("Enter Any Letter From a to z");
            vowel = Convert.ToChar(Console.ReadLine());
            if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u' || vowel == 'A' || vowel == 'E' || vowel == 'I' || vowel == 'O' || vowel == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Constant");
            }

        }
    }
}
