using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class PlaindromeNumber25
    { 
        public static string Checkpalindrome(int num)
        {
            if(num<0)
            {
                return "-1";
            }
            if(num>=1 && num<=9)
            {
                return "-2";
            }
            else
            {
                int temp=num;
                int sum = 0;
                while(num>0)
                {
                    sum = sum * 10 + num % 10;
                    num /= 10;
                }
                if(sum==temp)
                {
                    return "true";
                }
                return "false";
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine(Checkpalindrome(num));    
        }
    }
}
