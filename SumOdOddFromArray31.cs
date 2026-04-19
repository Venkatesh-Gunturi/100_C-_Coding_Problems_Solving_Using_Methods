using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class SumOdOddFromArray31
    {
        public static int GetOddSum(int[] array)
        {
            if(array == null )
            {
                return -4;
            }
            if(array.Length != 5)
            {
                return -1;
            }
            bool IsOdd = false;
            int sum = 0;
            foreach ( int i in array )
            {
                if (i <= 0)
                {
                    return -2;
                }

                
                if (i % 2 != 0)
                {
                    sum += i;
                    IsOdd = true;
                }
                
            }
            if (!IsOdd)
            {
                return -3;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5};
            int[] arra= {2,4,6,8,10};
            int[] arr = null;
            int[] ar = { 0,-5,5,5,2};
            int[] a = { 1, 2, 3, 4 };

            Console.WriteLine(GetOddSum(array));
            Console.WriteLine(GetOddSum(arra));
            Console.WriteLine(GetOddSum(arr));
            Console.WriteLine(GetOddSum(ar));
            Console.WriteLine(GetOddSum(a));
        }
    }
}
