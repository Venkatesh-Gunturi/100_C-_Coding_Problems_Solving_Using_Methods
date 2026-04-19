using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class FactorialOfNumber27
    {
        public static int GetFactorial(int num)
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
                int fact = 1;
                for(int i=1;i<=num;i++)
                {
                    fact *= i; 
                }
                return fact;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine(GetFactorial(num));
        }
    }
}
