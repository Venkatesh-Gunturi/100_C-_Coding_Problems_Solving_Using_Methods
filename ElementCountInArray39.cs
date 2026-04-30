using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class ElementCountInArray39
    {
        public static int GetCount(int[] array, int item)
        {
            if(array.LongLength == 0)
            {
                return -1;
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == item)
                {
                    count++;
                }
            }
            return count;
        }

        public static void Main(string[] args)
        {
            int item=int.Parse(Console.ReadLine());
            int num=int.Parse(Console.ReadLine());
            int[] array = new int[num];

            for (int i = 0;i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(GetCount(array, item));
        }
    }
}
