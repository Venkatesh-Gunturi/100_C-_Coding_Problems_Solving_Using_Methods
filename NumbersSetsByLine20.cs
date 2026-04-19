using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class NumbersSetsByLine20
    {
        public static string GetFourPerLine(int num)
        {
            if(num<0)
            {
                return "-1";
            }
            if(num==0)
            {
                return "-2";
            }
            if(num>99)
            {
                return "-3";
            }
            else
            {
                int x = 1;
                string res=string.Empty;
                while(num>0)
                {
                    num--;
                    if (x%4==0)
                    {
                        res += x + "\n";
                    }
                    else
                    {
                        res += x + " ";
                    }
                        x++;
                    
                }
                return res;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine(GetFourPerLine(num));
        }
    }
}
