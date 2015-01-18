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
    public class JudgeTests
    {
        [TestMethod()]
        public void JudgeTest()
        {
            var judge = new Judge("Christine", "Smith", "bars");

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
    }
}

