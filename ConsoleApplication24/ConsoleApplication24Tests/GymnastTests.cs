﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication24;
using Microsoft.VisualStudio.TestTools.UnitTesting;
<<<<<<< HEAD
using ConsoleApplication24.Tests;

=======
>>>>>>> c96f0bc85df84804ad8ca252d0841b154fc3a732
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
<<<<<<< HEAD
                    gymnast.FirstName = "";
=======
                   gymnast.FirstName = "";
>>>>>>> c96f0bc85df84804ad8ca252d0841b154fc3a732


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
<<<<<<< HEAD

        public void IntegratedGymnastTest()
        {


            var newGymnast = new Gymnast("Smith", "Sarah", "Closter", "female");
            string[] gymnastArray = new string[] { "Smith", "Sarah", "Closter", "female" };
            var newGymnastList = new GymnastList();
            List<string> participantList = new List<string>();
            participantList.Add(gymnastArray[3]);
            participantList.ToString();
            Console.WriteLine(participantList);
            {
                try
                {
                    participantList.Contains("Smith");

                }
                catch
                {

                    throw new ArgumentException();

                }
                try
                {
                    participantList.Contains("Sarah");
                }
                catch
                {
                    throw new ArgumentException();
                }
                try
                {
                    participantList.Contains("Closter");
                }
                catch
                {
                    throw new ArgumentException();
                }
                try
                {
                    participantList.Contains("female");
                }
                catch
                {
                    throw new ArgumentException();
                }
            }
        }
=======
>>>>>>> c96f0bc85df84804ad8ca252d0841b154fc3a732
    }
}


<<<<<<< HEAD











=======
>>>>>>> c96f0bc85df84804ad8ca252d0841b154fc3a732
