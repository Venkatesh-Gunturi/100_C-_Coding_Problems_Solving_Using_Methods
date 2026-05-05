using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class FizzBizz42
    {
        public static string GetFizzBizz(int num)
        {
            if(num<= 0)
            {
                return "Error";
            }
            if(num%3==0 && num%5==0)
            {
                return "FIZZBIZZ";
            }
            if( num%3==0)
            {
                return "FIZZ";
            }
            if( num%5==0)
            {
                return "BIZZ";
            }
            
            return $"{num}";
        }
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine(GetFizzBizz(num));
        }
    }
}
