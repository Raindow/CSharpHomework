using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please set your time(like 18:45):");
            string time = Console.ReadLine();

            Regex regex = new Regex("[0-24]:[0-24]");
            if (Regex.IsMatch(time, @"[0-9][0-9]:[0-9][0-9]")) {
                AlarmClock alarmClock = new AlarmClock();

                alarmClock.timeAlarm += new TimeAlarmHandler(Alarm);

                alarmClock.SetTime(time);
            } else {
                Console.WriteLine("Invalid input");
            }
            
        }

        static void Alarm(object sender, TimeAlarmArgs args)
        {
            while (args.dateTime != DateTime.Now.ToShortTimeString().ToString()) {}
            Console.WriteLine($"it's already {args.dateTime}.");
        }
    }
}
