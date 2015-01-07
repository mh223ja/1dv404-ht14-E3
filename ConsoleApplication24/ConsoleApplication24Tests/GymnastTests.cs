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
    public class GymnastTests
    {
        [TestMethod()]
        public void GymnastTest()
        {
            var gymnast = new Gymnast("Cooper", "Carrie", "EastHamton", "Female");

            {
                try
                {
                    gymnast.FirstName = "Christine";


                }
                catch
                {
                    throw new ArgumentException("Not a name");

                }

                try
                {
                    gymnast.LastName = "Cooper";


                }
                catch
                {
                    throw new ArgumentException("Not a name");

                }
                try
                {
                   gymnast.FirstName = "";


                }
                catch
                {
                    throw new ArgumentException("Not a name");

                }
                try
                {
                    gymnast.LastName = "";


                }
                catch
                {
                    throw new ArgumentException("Not a name");

                }

            }

        }
    }
}


