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
        string _gender;
        string _team;
        string gymnastInfo;
     
      


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

        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = Gender;
            }
        }

        public string Team
        {
            get
            {
                return _team;
            }
            set
            {
                _team = Team;
            }

        }
        public Gymnast(string lastName, string firstName, string team, string gender){

        
            lastName = LastName;
            firstName = FirstName;
            team = Team;
           gender = Gender;

            string[] gymnastArray = new string[]{lastName, firstName, team, gender     
        };
            Console.Write(gymnastArray);

          

            
           
            

        }

   
        public string GymnastList()
        {
            List<string>participantList = new List<string>();
            participantList.Add(gymnastInfo);
            Console.Write(participantList);
            string allParticipants = string.Join(",", participantList.ToArray());
            Console.Write(allParticipants);
            return allParticipants;

           
        }
    }
}
