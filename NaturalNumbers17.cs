using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class NaturalNumbers17
    {
        public static string GetNumbersInRange(int start,int end)
        {
            string res = string.Empty;
            if(start < 0 || end < 0)
            {
                return "-1";
            }
            if(start==end)
            {
                return "-2";
            }
            if(start>end)
            {
                return "-3";
            }
            while(start<end-1)
            {
                
                res += start + " ";
                
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("enter start value : ");
            int start=int.Parse(Console.ReadLine());
            Console.Write("Enter end value : ");
            int end =int.Parse(Console.ReadLine());

            Console.WriteLine(GetNumbersInRange(start,end));
        }
    }
}
