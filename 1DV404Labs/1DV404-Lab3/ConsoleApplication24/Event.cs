using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    public class Event
    {
        string _event;

        string[] _eventArray;
        string _eventOne;
        string _eventTwo;
        string _eventThree;
        string _eventFour;

        public string EventOne
        {
            get
            {
                return _eventOne;
            }
            set{
                _eventOne = EventOne;

            }
        }

        public string EventTwo
        {
            get
            {
                return _eventTwo;
            }
            set
            {
                _eventTwo = EventTwo;
            }
        }

        public string EventThree
        {
            get
            {
                return _eventThree;
            }
            set
            {
                _eventThree = EventThree;
            }
        }

        public string EventFour
        {
            get
            {
                return _eventFour;
            }
            set
            {
                _eventFour = EventFour;
            }
        }


        public string[] EventArray
        {

            get
            {
                return _eventArray;
            }
            set
            {
                EventArray = _eventArray;

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

        public Event(string eventOne, string eventTwo, string eventThree, string eventFour)
        {

            eventOne = EventOne;
            eventTwo = EventTwo;
            eventThree = EventThree;
            eventFour = EventFour;

          

           string [] eventArray = new string[] { eventOne, eventTwo, eventThree, eventFour };

            Console.WriteLine(eventArray);


        }

    }
}



