using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    delegate void TimeAlarmHandler(object sender, TimeAlarmArgs args);
    class AlarmClock
    {

        public event TimeAlarmHandler timeAlarm;

        public void SetTime(string dateTime)
        {
            TimeAlarmArgs args = new TimeAlarmArgs();
            args.dateTime = dateTime;
            timeAlarm(this, args);
        }
    }

}
