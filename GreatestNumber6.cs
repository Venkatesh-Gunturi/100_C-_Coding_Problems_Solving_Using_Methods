using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class GreatestNumber6
    {
        public static int GetGreatest(int x , int y)
        {
            if(x < 0 || y < 0)
            {
                return -1;
            }
            else if(x==0 || y==0)
            {
                return -2;
            }
            else if(x==y)
            {
                return 0;
            }
            else
            {
                if (x > y)
                {
                    return x;
                }
                else
                {
                    return y;
                }
            }
            
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            int x=int.Parse(Console.ReadLine());
            Console.Write("Enter Second number : ");
            int y=int.Parse(Console.ReadLine());

            Console.WriteLine(GetGreatest(x,y));
        }
    }
}
