using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class NumberSignIdentify09
    {
        public static int SignOf(int num)
        {
            if(num<0)
            {
                return -1;
            }
            else if(num>0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(SignOf(num));
        }

    }
}
