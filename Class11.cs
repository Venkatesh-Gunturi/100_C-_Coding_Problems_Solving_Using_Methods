using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class Class11
    {
        public static int Calculate(int num)
        {
            if(num<=0)
            {
                return -1;
            }
            else
            {
                if(num%2==0)
                {
                    num = (int)Math.Pow(num, 2);
                    return num;
                }
                else
                {
                    num = (int)Math.Pow(num, 3);

                    return num;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num=int.Parse(Console.ReadLine());  

            Console.WriteLine(Calculate(num));
        }
    }
}
