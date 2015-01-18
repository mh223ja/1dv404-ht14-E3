using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class GymnastList
    {
        public List <string> gymnastList(string[] gymnastArray)
        {
            List<string> participantList = new List<string>();
            participantList.Add(gymnastArray[3]);
            Console.Write(participantList);
            //string allParticipants = string.Join(",", participantList.ToArray());
            //Console.Write(allParticipants);
            return participantList;


        }
    }
}
