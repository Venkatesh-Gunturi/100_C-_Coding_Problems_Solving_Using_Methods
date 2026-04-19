using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class WaveString35
    {
        public static string GetWavedString(string value1,string value2)
        {
            if(value1 == null || value2 == null)
            {
                return "-1";
            }

            
            if (value1.Length > value2.Length)
            {
                return value2 + value1 + value2;
            }
            else if (value1.Length < value2.Length)
            {
                return value1 + value2 + value1;
            }
            else
            {
                string sum = string.Empty;
                for (int i = 0; i < value1.Length; i++)
                {
                    sum += value1[i].ToString() + value2[i].ToString();
                }
                return sum;
            }
        }

        static void Main(string[] args)
        {
            string value1=Console.ReadLine();
            string value2=Console.ReadLine();

            Console.WriteLine(GetWavedString(value1,value2));
        }
    }
}
