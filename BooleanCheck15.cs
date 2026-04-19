using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class BooleanCheck15
    {
        public static bool CountBoolean(bool b1,bool b2,bool b3)
        {
            return b1 && b2 || b2 && b3 || b1 && b3;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CountBoolean(true,false,false));
            Console.WriteLine(CountBoolean(true, true, false));
            Console.WriteLine(CountBoolean(true, false, false));
            Console.WriteLine(CountBoolean(true, true, true));
        }
    }
}
