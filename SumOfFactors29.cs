using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class SumOfFactors29
    {
        public static int FactorsSum(int num)
        {
            if(num<0)
            {
                return -1;
            }
            if(num==0)
            {
                return -2;
            }
            else
            {
                int sum = 0;
                for(int i=1;i<=num;i++)
                {
                    if(num%i==0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine(FactorsSum(num));

        }
    }
}
