using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    public class Team
    {
       
    
        string _teamName;
        string _ageGroup;
        string _sex;
        string _current;
     
      


        public string TeamName{

        
        get {
        return _teamName;
        }
            set
            {
                _teamName = TeamName;
            }
    }

        public string AgeGroup
        {
            get
            {
                return _ageGroup;
            }
            set
            {
                _ageGroup = AgeGroup;
            }
        }

        public string Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = Sex;
            }
        }

        public string Current
        {
            get
            {
                return _current;
            }
            set
            {
                _current = Current;
            }
        }


      
        public Team (string teamName, string ageGroup, string sex, string current){


            teamName = TeamName;
            ageGroup = AgeGroup;
            sex= Sex;
            current = Current;

           string[] teamStatusArray = new string[]{TeamName, AgeGroup, Sex, Current}; 
       

          }
         
        }
    }

