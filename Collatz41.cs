using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class Collatz41
    {
        public static string GetCollatzSequence(int num)
        {
            if(num<0)
            {
                return "Error";
            }
            //if(num==0)
            //{
            //    return $"{num} 0";
            //}
            string str=num + " ";
            if(num>0)
            {
                for(int i=num-1;i>=0;i--)
                {
                    str += Math.Pow(2, i)+" ";
                }
            }
            return str;
        }

        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine(GetCollatzSequence(num));
        }
    }
}
