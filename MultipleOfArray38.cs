using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class MultipleOfArray38
    {
        public static int[] GetMultiplesArray(int num)
        {
            if(num<=0)
            {
                return null;
            }
            else
            {
                int[] arr = new int[10];

                for(int i = 0;i<10;i++)
                {
                    arr[i] = num*(i+1); 
                }


                return arr;
            }

        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

           foreach(int i in GetMultiplesArray(num))
           {
                Console.Write(i+" ");
           }
        }
    }
}
