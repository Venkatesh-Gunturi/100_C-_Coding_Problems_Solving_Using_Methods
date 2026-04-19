using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class DigitDifferance2
    {
        public static int GetDiffOfdigits(int num)
        {
            if(num<0)
            {
                return -3;
            }
            else if(num>=0 && num<=9)
            {
                return -1;
            }
            else if(num>99)
            {
                return -2;
            }
            else
            {
                int tensDigit = num / 10;
                int unitDigit = num % 10;
                return tensDigit - unitDigit;
              
              
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine(GetDiffOfdigits(num));
        }
    }
}
