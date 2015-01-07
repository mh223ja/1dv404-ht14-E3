using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    public class Gymnast
    {
        string _firstName;
        string _lastName;
        int _age;

        public string FirstName{

        
        get {
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

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = Age;
            }
        }

        public Gymnast(string firstName, string lastName, int age){

            FirstName = firstName;
            LastName = lastName;
            Age = age;


        }
        public Gymnast()
        {

        }
    }
}
