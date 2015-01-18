using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    public class ScoreCard
  
    {
        string _firstJudge;
        string _secondJudge;
        string _thirdJudge;
        string _fourthJudge;

        public string FirstJudge
        {

            get
            {
                return _firstJudge;
            }
            set
            {
                _firstJudge = FirstJudge;
            }
        }

        public string SecondJudge
        {
            get
            {
                return _secondJudge;
            }
            set
            {
                _secondJudge = SecondJudge;
            }
        }

        public string ThirdJudge
        {
            get
            {
                return _thirdJudge;
            }
            set
            {
                _thirdJudge = ThirdJudge;
            }
               
             }

        public string FourthJudge
        {
            get{
                return _fourthJudge;
            }
            set
            {
                _fourthJudge = FourthJudge;
            }
        }

            public ScoreCard (string firstJudge, string secondJudge, string thirdJudge, string fourthJudge){

            firstJudge = FirstJudge;
            secondJudge = SecondJudge;
            thirdJudge = ThirdJudge;
            fourthJudge = FourthJudge;

            string[] gymnastScoreCard = new string[] {FirstJudge, SecondJudge, ThirdJudge, FourthJudge};  


        }
        }
    }

    
