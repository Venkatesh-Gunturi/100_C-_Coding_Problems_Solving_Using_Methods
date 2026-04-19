using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class FindingTriangle32
    {
        public static string FindTriangle(int side1, int side2,int side3)
        {
            if(side1==0||side2==0||side3==0)
            {
                return "-1";
            }
            else if(side1<0||side2<0||side3<0)
            {
                return "-2";
            }
            else if(side1+side2 >side3 && side2+side3>side1 && side3+side1>side2)
            {
                if (side1 == side2 && side2 == side3)
                {
                    return "EQUILATERAL";
                }
                else if (side1 == side2 || side2 == side3 || side3 == side1)
                {
                    return "ISOSCELES";
                }
                else
                {
                    return "SCALENE";
                }
            }
            else
            {
                return "-3"; 
            }
        }

        static void Main(string[] args)
        {
            int side1 = int.Parse(Console.ReadLine());
            int side2= int.Parse(Console.ReadLine());
            int side3= int.Parse(Console.ReadLine());

            Console.WriteLine(FindTriangle(side1, side2, side3));
        }
    }
}
