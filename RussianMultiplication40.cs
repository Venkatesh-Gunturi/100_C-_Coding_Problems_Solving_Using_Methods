using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class RussianMultiplication40
    {
        public static int GetProduct(int halving, int doubling)
        {
            if(halving <0 || doubling <0)
            {
                return -1;

            }
            int sum = 0;
            for(int i=halving;i>0;i/=2)
            {
                
                if (i%2 !=0)
                {                    
                    sum += doubling;
                }
                doubling = doubling + doubling;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int halving=int.Parse(Console.ReadLine());
            int doubling =int.Parse(Console.ReadLine());

            Console.WriteLine(GetProduct(halving, doubling));
        }
    }
}
