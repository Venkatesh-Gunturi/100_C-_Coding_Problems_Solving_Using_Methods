using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class SumOfUniqueElementsOfArray36
    {
        public static int SumOfArray(int[] array)
        {
            if(array==null || array.Length==0)
            {
                return -1;
            }

            for(int i=0; i<array.Length; i++)
            {
                if( array[i] < 0 )
                {
                    return -2;
                }
            }

            Array.Sort(array);
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;

                // Check previous
                if (i > 0 && array[i] == array[i - 1])
                    isUnique = false;

                // Check next
                if (i < array.Length - 1 && array[i] == array[i + 1])
                    isUnique = false;

                if (isUnique)
                    sum += array[i];
            }

            return sum;

        }

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            for(int i=0; i<size; i++)
            {
                array[i]=int.Parse(Console.ReadLine());
            }

            Console.WriteLine(SumOfArray(array));
        //}
    }
}
