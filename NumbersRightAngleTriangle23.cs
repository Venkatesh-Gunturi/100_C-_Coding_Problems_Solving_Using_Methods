using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class NumbersRightAngleTriangle23
    {
        public static string NumberPattern(int row)
        {
            if(row <0)
            {
                return "-1";
            }
            if(row==0)
            {
                return "-2";
            }
            else
            {
                
                string res=string.Empty;
                for(int i=1;i<=row;i++)
                {
                    int x = i;
                    for (int j=1;j<=i;j++)
                    {
                        
                        res += x + " ";
                        x = x + i;
                    }
                    res = res.Trim() + "\n";
                   
                    
                }
                return res;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter row size : ");
            int row =int.Parse(Console.ReadLine());

            Console.WriteLine(NumberPattern(row));
        }
    }
}
