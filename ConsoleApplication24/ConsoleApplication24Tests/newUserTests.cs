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
    public class newUserTests
    {
        [TestMethod()]
        public void newUserTest()
        {

            var adminUser = new newUser("Smith, Jason", "myPassword");

          {
                try
                {
                    adminUser.UserName = "Smith,Jason";


                }
                catch
                {
                    throw new ArgumentException("Error!");

                }

                try
                {
                    adminUser.PassWord = "myPassword";


                }
                catch
                {
                    throw new ArgumentException("Error!");

                } 
        }
    }

        }
    }

