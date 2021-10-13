using System;

namespace Basic_Core_Programs
{
    class BasicCoreProgram
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1: FlipCoin\t\t\t\t 2: Leap Year");
            Console.WriteLine("3: Power of 2\t\t\t\t 4: Harmonic Number");
            Console.WriteLine("5: Factor\t\t\t\t 6: Quotient and Remainder");
            Console.WriteLine("7: Swap Two Numbers\t\t\t 8: Number is Even or odd");
            Console.WriteLine("9: Alphabet is Vowel or Constant\t10: largest Among three Numbers");

            Console.WriteLine("\nEnter your choice");
            int a=Convert.ToInt32(Console.ReadLine());
            switch(a)
                {
                case 1:
                    FlipCoinHeadTail flip = new FlipCoinHeadTail();
                    flip.FlipCoin();
                break;

                case 2:
                    LeapYearOrNot lp = new LeapYearOrNot();
                    lp.LeapYear();
                break;

                case 3:
                    PowerOfTwo pw = new PowerOfTwo();
                    pw.PowerTwo();
                    break;

                case 4:
                    HarmonicNumberOutput hn = new HarmonicNumberOutput();
                    hn.HarmonicNumber();
                    break;

                case 5:
                    FactorsOfNumber fn = new FactorsOfNumber();
                    fn.FactorsNum();
                    break;

                case 6:
                    QuotientRemainder qr = new QuotientRemainder();
                    qr.QuotRem();
                    break;

                case 7:
                    SwapTwoNumberscs sn = new SwapTwoNumberscs();
                    sn.Displaynum();
                    sn.SwapNum();
                    sn.SwappedOutput();
                    break;

                case 8:
                    EvenOrOdd eo = new EvenOrOdd();
                    eo.EvenOdd();
                    break;

                case 9:
                    VowelOrConstant vo = new VowelOrConstant();
                    vo.VowCon();
                    break;

                case 10:
                    LargestNumber ln = new LargestNumber();
                    ln.LarNum();
                    break;

                default:
                    Console.WriteLine("Your Choice is Not Within The Range");
                    break;
            }
        }
    }
}
