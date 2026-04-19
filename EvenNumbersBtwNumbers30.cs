using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class EvenNumbersBtwNumbers30
    {
        public static string GetEvenNumbers(int x,int y)
        {
            if(x < 0 || y < 0)
            {
                return "-1";
            }
            if(x==y|| x==0||y==0)
            {
                return "-2";
            }
            string res=string.Empty;
            if(x>y)
            {
                for(int i=y;i<=x;i++)
                {
                    if(i%2==0)
                    {
                        res += i + " ";
                    }
                }
                return res;
            }
            else
            {
                for (int i = x; i <= y; i++)
                {
                    if (i % 2 == 0)
                    {
                        res += i + " ";
                    }
                }
                return res;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter x value : ");
            int x=int.Parse(Console.ReadLine());

            Console.Write("Enter y value : ");
            int y=int.Parse(Console.ReadLine());    

            Console.WriteLine(GetEvenNumbers(x,y));
        }
    }
}
