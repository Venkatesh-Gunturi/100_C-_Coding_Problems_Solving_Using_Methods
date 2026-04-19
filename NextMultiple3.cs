using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class NextMultiple3
    {
        public static int GetNextMultipleOf100(int num)
        {
            if(num<=0)
            {
                return -1;
            }
            else
            {
                num = ((num / 100) + 1) * 100;
                return num;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine(GetNextMultipleOf100(num));
        }
    }
}
