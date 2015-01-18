using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication24;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ConsoleApplication24.Tests
{
    [TestClass()]
    public class ScoreCardTests
    {
        [TestMethod()]
        public void ScoreCardTest()
        {
            var gymnastBarCard = new ScoreCard(7, 8, 6, 7);

          {
                try
                {
                    gymnastBarCard.FirstJudge = 7;


                }
                catch
                {
                    throw new ArgumentException("Error!");

                }

                try
                {
                    gymnastBarCard.SecondJudge = 8;


                }
                catch
                {
                    throw new ArgumentException("Error!");

                }
                try
                {
                    gymnastBarCard.ThirdJudge = 6;


                }
                catch
                {
                    throw new ArgumentException("Error!");

                }
                try
                {
                  gymnastBarCard.FourthJudge = 7;


                }
                catch
                {
                    throw new ArgumentException("Error!");

                }
        }
    }

    }
}
