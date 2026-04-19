using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class OddRounder08
    {
        public static int IsOddRounder(int num)
        {
            if(num<0)
            {
                return -1;
            }
            else if(num==0)
            {
                return -2;

            }
            else if(num%2==0)
            {
                return num;
            }
            else
            {
                num = (num/10 + 1) * 10;

                return num;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine(IsOddRounder(num));
        }
    }
}
