﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    public class Event
    {
        string _event;

<<<<<<< HEAD
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
=======
        string[] eventArray;
        string eventOne;
        string eventTwo;
        string eventThree;
        string eventFour;
>>>>>>> c96f0bc85df84804ad8ca252d0841b154fc3a732


        public string[] EventArray
        {

            get
            {
<<<<<<< HEAD
                return _eventArray;
            }
            set
            {
                _eventArray = EventArray;
=======
                return eventArray;
            }
            set
            {
                EventArray = eventArray;
>>>>>>> c96f0bc85df84804ad8ca252d0841b154fc3a732

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
<<<<<<< HEAD
                _event = GymnasticsEvent;
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

            

=======
                GymnasticsEvent = _event;
            }
        }

        public Event(string[] eventArray, string eventOne, string eventTwo, string eventThree, string eventFour)
        {

            eventArray = EventArray;

            eventArray = new string[] { eventOne, eventTwo, eventThree, eventFour };

            Console.WriteLine(eventArray);

>>>>>>> c96f0bc85df84804ad8ca252d0841b154fc3a732

        }

    }
}



