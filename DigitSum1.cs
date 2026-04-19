using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class DigitSum1
    {
        public static int GetSumOfdigits(int num)
        {
           if(num<0)
           {
                return -3;
           }
            else if(num >=0 && num<=9)
            {
                return -1;
            }
           else if(num>99)
            {
                return -2;
            }
            else
            {
                int sum = 0;
                while(num>0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                return sum;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine(GetSumOfdigits(num));
        }
    }
}
