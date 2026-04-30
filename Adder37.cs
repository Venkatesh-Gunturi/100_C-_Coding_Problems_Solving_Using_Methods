using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class Adder37
    {
        public static string GetSum(int a, int b)
        {
            if(a <= 0 || b <= 0)
            {
                return "Error";
            }
            else
            {
                return (a + b).ToString();
            }

        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());

            Console.WriteLine(GetSum(a, b));
        }
    }
}
