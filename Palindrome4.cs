using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class Palindrome4
    {
        public static int IsPalindrome(int num)
        {
            if(num<=0)
            {
                return -1;
            }
            else if(num>99 && num<=999)
            {
                int temp = num;
                int res = 0;
                while(num>0)
                {
                    res =  res*10 + num % 10;
                    num /= 10;
                }
                if (res != temp)
                {
                    return 0;
                }
                return 1;
                
            }
            else
            {
                return -2;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine(IsPalindrome(num));
        }
    }
}
