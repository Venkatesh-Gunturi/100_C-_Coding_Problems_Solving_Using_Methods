using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class EvenCheck5
    {
        public static int IsEven(int num)
        {
            if(num<=0)
            {
                return -1;
            }
            else
            {
                if(num%2 != 0)
                {
                    return 0;
                }
                return 1;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(IsEven(num));
        }
    }
}
