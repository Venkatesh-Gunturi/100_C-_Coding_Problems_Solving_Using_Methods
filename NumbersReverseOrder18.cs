using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class NumbersReverseOrder18
    {
        public static string GetNumbersInRange(int high,int low)
        {
            if(high<0||low<0)
            {
                return "-1";
            }
            if(high<low)
            {
                return "-3";
            }
            if(high==low)
            {
                return "-2";
            }
            if((high-low)==1)
            {
                return "-4";
            }
            else
            {
                string res = string.Empty;
                while(high>low+1)
                {
                    res += (--high) + " ";
                }
                return res;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter high value : ");
            int high=int.Parse(Console.ReadLine());

            Console.Write("Enter low value : ");
            int low = int.Parse(Console.ReadLine());

            Console.WriteLine(GetNumbersInRange(high,low));
        }
    }
}
