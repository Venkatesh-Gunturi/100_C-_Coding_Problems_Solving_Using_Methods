using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class PrimeCheck24
    {
        public static string CheckPrime(int num)
        {
            if(num<0)
            {
                return "-1";
            }
            if(num==0 || num==1)
            {
                return "-2";
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if(num%i==0)
                    {
                        return "false";
                        
                    }
                   
                }
                return "true";
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine(CheckPrime(num));
        }
    }
}
