using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class Class12
    {
        public static int SumOfMultiples(int x, int y,int z)
        {
            if(x<=0  || y<=0 || z<=0)
            {
                return -1;
            }
            else
            {
                int sum = 0;
                if(x%10!=0)
                {
                    x = ((x / 10) + 1) * 10;
                    sum += x;
                }
                else
                {
                    sum += x;
                }

                if(y%10!=0)
                {
                    y = ((y / 10) + 1) * 10;
                    sum += y;
                }
                else
                {
                    sum += y;
                }

                if(z%10!=0)
                {
                    z = ((z / 10) + 1) * 10;
                    sum += z;
                }
                else
                {
                    sum += z;
                }

                return sum;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first  number : ");
            int x=int.Parse(Console.ReadLine());
            Console.Write("Enter Second  number : ");
            int y=int.Parse(Console.ReadLine());
            Console.Write("Enter Third  number : ");
            int z=int.Parse(Console.ReadLine());

            Console.WriteLine(SumOfMultiples(x,y,z));
        }
    }
}
