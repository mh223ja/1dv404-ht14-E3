using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class AlarmClock
    {


        int _alarmHour;
        int _alarmMinute;
        int _hour;
        int _minute;
        private int p1;
        private int p2;


        // use get/set with public int to get values with argument exceptions
        public int AlarmHour
            {
                get {
                    return _alarmHour;
                }

                set
                {
                    if (value <0 ||value>23)
                    {
                        throw new ArgumentException();
                         }
                        _alarmHour = value;
                    }
                  
                }
             
            

               

        public int AlarmMinute
        {
            get
            {
                return _alarmMinute;

            }
            set
            {
                if (value < 0 || value > 59)
                {
    throw new ArgumentException(); 
}
                _alarmMinute = value;

            
        }
}
        public int hour
        {
            get
            { 
                return _hour;
            }
            set 
            { 
                if (value<0||value>23)
                { 
throw new ArgumentException();
                }
                _hour = value;
            }
        }
        public int minute
        {
            get {
return _minute; 
}
            set { 
if (value <0||value>59)
{
_minute = value; 
}
}
        }

//set up constructors: standard, with hour/min and with hour/min and alarm
        public AlarmClock() : this(0, 0) { }

        public AlarmClock(int hour, int minute) : 
        {
            // TODO: Complete member initialization
            this.p1 = hour;
            this.p2 = minute;
        }

    }
}










