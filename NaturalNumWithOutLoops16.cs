using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class NaturalNumWithOutLoops16
    {
        
        public static string GetNaturalNumbers(int start,int end)
        {
            
            if (start < 0 || end < 0)
            {
                return "-1";
            }
            if(start==0||end==0)
            {
                return "-2";
            }
            if (start > end)
                return "";

            if (start == end)
                return start.ToString();

            return start + " " + GetNaturalNumbers(start + 1, end);

        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter start value : ");
            int start=int.Parse(Console.ReadLine());
            Console.Write("Enter end value : ");
            int end =int.Parse(Console.ReadLine());

            Console.WriteLine(GetNaturalNumbers(start,end));
        
        }
    }
}
