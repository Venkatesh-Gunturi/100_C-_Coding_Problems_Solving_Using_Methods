using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class RoundedSum13
    {
        public static int SumOfRoundedValues(int x, int y,int z)
        {
            if(x>0 && y>0 && z>0)
            {
                int sum = RoundOf(x)+RoundOf(y)+RoundOf(z);

                return sum;
            }
            else
            {
                return -1;
            }
        }
        public static int RoundOf(int num)
        {
            int LastDigit = num % 10;
            if(LastDigit<5)
            {
                return (num/10)*10;
            }
            else
            {
                return ((num / 10)+1) * 10;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter x value : ");
            int x=int.Parse(Console.ReadLine());
           
            
            Console.Write("Enter y value : ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter z value : ");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine(SumOfRoundedValues(x,y,z));
        }
    }
}
