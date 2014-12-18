using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication24;

namespace gymnasticsapp
{
    class Program
    {
        static void Main(string[] args)
        {

            registerName();
            checkAge();
            findJudge();
            checkJudgeEvent();


        }



        private static void findJudge()
        {
            var judge = new Judge();

            {
                try
                {
                    judge.FirstName = "Christine";


                }
                catch
                {
                    throw new ArgumentException("Not a name");

                }

                try
                {
                    judge.LastName = "Jones";


                }
                catch
                {
                    throw new ArgumentException("Not a name");

                }
                try
                {
                    judge.FirstName = "";


                }
                catch
                {
                    throw new ArgumentException("Not a name");

                }
                try
                {
                    judge.LastName = "";


                }
                catch
                {
                    throw new ArgumentException("Not a name");

                }
            }
        }


        private static void checkAge()
        {
            var gymnast = new Gymnast();

            try
            {
                gymnast.Age = 7;


            }
            catch
            {
                throw new ArgumentException("Not a number");

            }

            /*try
            {
                gymnast.Age = "" ;

            }
            catch
            {
                throw new ArgumentException("Not a number");
            }*/
        }

        private static void registerName()
        {
            var Gymnast = new Gymnast();


            {
                try
                {
                    Gymnast.FirstName = "Stacy";


                }
                catch
                {
                    throw new ArgumentException("Not a name");

                }

                try
                {
                    Gymnast.LastName = "Smith";


                }
                catch
                {
                    throw new ArgumentException("Not a name");

                }
                try
                {
                    Gymnast.FirstName = "";


                }
                catch
                {
                    throw new ArgumentException("Not a name");

                }
                try
                {
                    Gymnast.LastName = "";


                }
                catch
                {
                    throw new ArgumentException("Not a name");

                }

            }
        }
        private static void checkJudgeEvent()
        {
            var judge = new Judge("Cool", "Judge", "bars");
            var newEvent = new Event();
            

            var judgeEvent = judge.EventSpeciality;

          
                  if (judgeEvent == "bars"){
                      Console.WriteLine("Judge can serve on juries for bars");
                  } 
                   if (judgeEvent == "mat"){
                      {
                        Console.WriteLine("Judge can serve on juries for mat");
                      }
                       if (judgeEvent == "horse"){
                           Console.WriteLine("Judge can serve on juries for mat");

                      }
                       else { 
                      Console.WriteLine("You must enter an approved event");
                  }
              }

        }
    }
}


