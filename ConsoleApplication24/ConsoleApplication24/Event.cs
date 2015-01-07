using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    public class Event
    {
        string _event;

        string[] eventArray;
        string eventOne;
        string eventTwo;
        string eventThree;
        string eventFour;


        public string[] EventArray
        {

            get
            {
                return eventArray;
            }
            set
            {
                EventArray = eventArray;

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

        public Event(string[] eventArray, string eventOne, string eventTwo, string eventThree, string eventFour)
        {

            eventArray = EventArray;

            eventArray = new string[] { eventOne, eventTwo, eventThree, eventFour };

            Console.WriteLine(eventArray);


        }

    }
}



