using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class PrimeNumbersSum34
    {
        public static bool IsPrime(int num)
        {
            if(num>1)
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetPrimeNumbersSum(int start , int end)
        {
            if(start <0 ||  end <0)
            {
                return -1;
            }
            if(start > end)
            {
                return -2;
            }
            else
            {
                int sum = 0;
                for (int i = start; i <= end; i++)
                {
                    if (IsPrime(i))
                    {
                        sum += i;
                    }
                }
                return sum;
            }
            
        }

        static void Main(string[] args)
        {
            int start =int.Parse(Console.ReadLine());
            int end =int.Parse(Console.ReadLine()); 

            Console.WriteLine(GetPrimeNumbersSum(start, end));
        }
    }
}
