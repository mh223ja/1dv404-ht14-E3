﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    public class Judge
    {
        string _firstName;
        string _lastName;
        string _eventSpeciality;

        public string FirstName
        {

            get
            {
                return _firstName;
            }
            set
            {
                _firstName = FirstName;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = LastName;
            }
        }

        public string EventSpeciality
        {
            get
            {
                return _eventSpeciality;
            }
            set
            {
                _eventSpeciality = EventSpeciality;
            }
               
             }

            public Judge (string firstName, string lastName, string eventSpeciality){

            firstName = FirstName;
            lastName = LastName;
            eventSpeciality = EventSpeciality;

            string[] judgeArray = new string[] { lastName, firstName, EventSpeciality };  


        }
        }
    }

