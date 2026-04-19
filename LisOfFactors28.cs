using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class LisOfFactors28
    {
        public static string GetFactors(int num)
        {
            if(num<0)
            {
                return "-1";
            }
            if(num==0)
            {
                return "-2";
            }
            else
            {
                string res = string.Empty;
                for(int i=1;i<=num;i++)
                {
                    if(num%i==0)
                    {
                        res += i + " ";
                    }
                }
                return res;
            }
        }
        static void Main(string[] arg)
        {
            Console.Write("Enter a number : ");
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine(GetFactors(num));
        }
    }
}
