using System;
using System.Text;
using BestGames_Libary;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestGames_Testing
{
    /// <summary>
    /// Summary description for Validate
    /// </summary>
    [TestClass]
    public class Validate
    {


        string o_information = "234234";
        string o_date = DateTime.Now.Date.ToString();



        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(o_information, o_date);
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void OrderInformationMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string o_information = "";
            Error = AnOrder.Valid(o_information, o_date);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void OrderInformationMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string o_information = "a";
            Error = AnOrder.Valid(o_information, o_date);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void OrderInformationMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string o_information = "aa";
            Error = AnOrder.Valid(o_information, o_date);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderInformationMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string o_information = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = AnOrder.Valid(o_information, o_date);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderInformationMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string o_information = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(o_information, o_date);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderInformationMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string o_information = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(o_information, o_date);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderInformationMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string o_information = "aaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(o_information, o_date);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderInformationExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string o_information = "";
            o_information = o_information.PadRight(500, 'a');
            Error = AnOrder.Valid(o_information, o_date);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string o_date = TestDate.ToString();
            Error = AnOrder.Valid(o_information, o_date);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string o_date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(o_information, o_date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string o_date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(o_information, o_date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string o_date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(o_information, o_date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string o_date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(o_information, o_date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateInvalidDate()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string o_date = "this is not a date!";
            Error = AnOrder.Valid(o_information, o_date);
            Assert.AreNotEqual(Error, "");

        }





    }
}
