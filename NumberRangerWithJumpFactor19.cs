using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class NumberRangerWithJumpFactor19
    {
        public static string GetNumbersInRange(int high , int low,int decrement)
        {
            if(high < 0|| low < 0|| decrement <= 0)
            {
                return "-1";
            }
            if(high == low || low == decrement || low == decrement)
            {
                return "-2";
            }
           if(low>high || high<decrement)
           {
                return "-3";
           }
            else
            {
                string res = string.Empty;
                while (high > low + 1)
                {
                    high = high - decrement;
                    if(high>low)
                    {
                        res += high + " ";
                    }
                }
                return res;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter high value : ");
            int high = int.Parse(Console.ReadLine());

            Console.Write("Enter low value : ");
            int low = int.Parse(Console.ReadLine());

            Console.Write("Enter range of decrement : ");
            int decrement=int.Parse(Console.ReadLine());

            Console.WriteLine(GetNumbersInRange(high, low,decrement));
        }
    }
}
