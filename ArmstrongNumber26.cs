using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class ArmstrongNumber26
    {
        public static string CheckArmStrong(int num)
        {
            if(num<0)
            {
                return "-1";
            }
            if(Count(num)!=4)
            {
                return "-2";
            }
            else
            {
                int temp = num;
                int sum = 0;
                while(num>0)
                {
                    sum =sum +(int)Math.Pow(num%10, 4);
                    num /= 10;
                }
                if(sum==temp)
                {
                    return "ArmStrong Number";
                }
                return "Not ArmStrong Number";
            }
        }
        public static int Count(int num)
        {
            int res = 0;
            while(num>0)
            {
                res++;
                num /= 10;
            }
            return res;
        }
        public static void Main(string[] arg)
        {
            Console.Write("Enter a number : ");
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine(CheckArmStrong(num));
        }
    }
}
