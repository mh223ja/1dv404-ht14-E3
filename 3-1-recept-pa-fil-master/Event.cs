using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class Event
    {
        string _event;
        public string[] eventArray = new string[] {"horse", "bars", "mat", "beam"};
        string horse;
        string bars;
        string mat;
        string beam;
     
        public string EventArray
        {
          
            get
        {
            return eventArray [3];
        }
            set
            {
            EventArray = eventArray [3];
            
        }
             }


            public string GymnasticsEvent
            {
                
            get
            {
                return _event;
            }

            set
            {
                GymnasticsEvent = _event;
            }
                 }

           /* public string checkEvent
            {
                if (Event = EventArray[3] {0}||{1}||{2}||{3})
            }*/

   
    }
    }

