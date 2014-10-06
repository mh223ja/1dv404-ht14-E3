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

           
            }
            public int AlarmHour ()
            {
                get {
                    return _alarmHour;
                }
                set
                {
                    _alarmHour = value;
                }
              

            

                if (alarmHour < 0 ||> 23)
                {
                    throw new ArgumentException();

                }
               
              
            }



        }
    }

