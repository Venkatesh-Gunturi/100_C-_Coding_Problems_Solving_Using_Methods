using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems100Solving
{
    internal class AlarmClock14
    {
        public static string RingAlarm(int Day, bool IsVacation)
        {
            if (Day<0 || Day > 6)
            {
                return "Invalid Inputs";
            }
            if(Day>0 && Day<6)
            {
                return IsVacation ? "10:00" : "7:00";
            }
            else
            {
                if (IsVacation)
                {
                    return "OFF";
                }
                else
                {
                    return "10:00";
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RingAlarm(1, false)); // 07:00
            Console.WriteLine(RingAlarm(2, true));  // 10:00
            Console.WriteLine(RingAlarm(0, true));  // OFF
            Console.WriteLine(RingAlarm(6, false)); // 10:00
            Console.WriteLine(RingAlarm(8, false)); // Invalid Inputs
        }
    }
}
