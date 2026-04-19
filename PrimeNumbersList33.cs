using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class PrimeNumbersList33
    {
        public static bool IsPrime(int num)
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

        public static string GetPrimeNumbers(int start,int end )
        {
            if( start <= 0 || end <= 0 )
            {
                return "-1";
            }
            if(start >= end)
            {
                return "-2";
            }
            else
            {
                string list =string.Empty;
                for(int i = start; i <= end; i++)
                {
                   if(IsPrime(i))
                   {
                        list += i + " ";
                   }
                    
                   
                }
                return list;
            }
            
        }

        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());    

            Console.WriteLine(GetPrimeNumbers(start,end));  
        }
    }
}
