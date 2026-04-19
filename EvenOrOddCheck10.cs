using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class EvenOrOddCheck10
    {
        public static string IsEvenOrOdd(int num)
        {
            if(num<=0)
            {
                return "Invalid Input";
            }
            else if(num%2==0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num=int.Parse(Console.ReadLine());  

            Console.WriteLine(IsEvenOrOdd(num));
        }
    }
}
