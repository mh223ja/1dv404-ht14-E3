using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class AlarmClock
    {


        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;



        // use get/set with public int to get values with argument exceptions
        public int AlarmHour
        {
            get
            {
                return _alarmHour;
            }

            set
            {
                if (value < 0 || value > 23)
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
        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                }
                _hour = value;
            }
        }
        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }

                _minute = value;

            }
        }

        //set up constructors: standard, with hour/min and with hour/min and alarm use this
        public AlarmClock() : (0, 0) { } //standard

        public AlarmClock(int hour, int minute)
            : this(hour, minute, 0, 0) //must use a constructor with 4 parameters
        { }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute) //final constructor
        {
            //give value to fields
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;


        }

        public bool TickTock()
        {
            //shud increase minutes and hours so that it functions as a clock. If goes too high, should reset


            if (_minute < 59)
            {
                _minute++;
            }
            else
            {
                _minute = 0;
            }
            if (_minute == 0)
            {
                if (_hour < 23)
                {
                    _hour++;
                }
                else
                {
                    _hour = 0;
                }

            }
            if (_hour == _alarmHour && _minute == _alarmMinute)
            { return true; }
            else
            {
                return false;
            }
        }

        //Create actual 'clock'
        public override string ToString()
        {
            return String.Format("{0,10}:{1:00} <{2}:{3:00}>", _hour, _minute, _alarmHour, _alarmMinute);
        }

    }
}











