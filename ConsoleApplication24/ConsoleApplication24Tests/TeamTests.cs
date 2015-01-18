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
    public class TeamTests
    {
        [TestMethod()]
        public void TeamTestOne()
        {
            var createTeam = new Team("Haworth", "senior", "Female", "Current");

          {
                try
                {
                    createTeam.TeamName = "Haworth";


                }
                catch
                {
                    throw new ArgumentException("Error!");

                }

                try
                {
                    createTeam.AgeGroup = "senior";


                }
                catch
                {
                    throw new ArgumentException("Error!");

                }
                try
                {
                    createTeam.Sex = "Female";


                }
                catch
                {
                    throw new ArgumentException("Error!");

                }
                try
                {
                   createTeam.Current = "Current";


                }
                catch
                {
                    throw new ArgumentException("Error!");

                }
        }
    }

            [TestMethod()]
        public void TeamTestTwo()
        {
            var createTeam = new Team("Haworth", "7" , "Female", "Current");

          {
                try
                {
                    createTeam.TeamName = "Haworth";


                }
                catch
                {
                    throw new ArgumentException("Error!");

                }

                try
                {
                    createTeam.AgeGroup = "junior";


                }
                catch
                {
                    throw new ArgumentException("Error!");

                }
                try
                {
                    createTeam.Sex = "Female";


                }
                catch
                {
                    throw new ArgumentException("Error!");

                }
                try
                {
                   createTeam.Current = "Current";


                }
                catch
                {
                    throw new ArgumentException("Error!");

                }
        }
    }
}
}