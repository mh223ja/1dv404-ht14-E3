using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    public class ScoreCard
  
    {
        int _firstJudge;
        int _secondJudge;
        int _thirdJudge;
        int _fourthJudge;

        public int FirstJudge
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

        public int SecondJudge
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

        public int ThirdJudge
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

        public int FourthJudge
        {
            get{
                return _fourthJudge;
            }
            set
            {
                _fourthJudge = FourthJudge;
            }
        }

            public ScoreCard (int firstJudge, int secondJudge, int thirdJudge, int fourthJudge){

            firstJudge = FirstJudge;
            secondJudge = SecondJudge;
            thirdJudge = ThirdJudge;
            fourthJudge = FourthJudge;

            int[] gymnastScoreCard = new int[] {FirstJudge, SecondJudge, ThirdJudge, FourthJudge};  


        }
        }
    }

    
