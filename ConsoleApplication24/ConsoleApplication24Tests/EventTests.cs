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
    public class IntegratedEventTests
    {
        [TestMethod()]
        public void EventTest()
        {
            var createEvent = new Event("bars", "beam", "mat", "vault");


            {
                try
                {
                    createEvent.EventOne = "bars";


                }
                catch
                {
                    throw new ArgumentException("Please enter another event");

                }

                try
                {
                    createEvent.EventTwo = "beam";


                }
                catch
                {
                    throw new ArgumentException("Please enter another event");

                }
                try
                {
                    createEvent.EventThree = "mat";


                }
                catch
                {
                    throw new ArgumentException("Please enter another event");

                }
                try
                {
                   createEvent.EventFour= "vault";


                }
                catch
                {
                    throw new ArgumentException("Please enter another event");

                }

        }
    }
}
}
