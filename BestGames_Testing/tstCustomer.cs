using System;
using BestGames_Libary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestGames_Testing
{
    
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }


        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.o_status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.o_status, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.o_date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.o_date, TestData);
        }


        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 4;
            //assign the data to the property
            AnOrder.o_id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.o_id, TestData);
        }


        [TestMethod]
        public void OrderInformationPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "fdghd";
            //assign the data to the property
            AnOrder.o_information = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.o_information, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 o_id = 68;
            //invoke the method
            Found = AnOrder.Find(o_id);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }



        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 o_id = 68;
            //invoke the method
            Found = AnOrder.Find(o_id);
            //check the address no
            if (AnOrder.o_id != 68)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 o_id = 68;
            Found = AnOrder.Find(o_id);

            if (AnOrder.o_date != Convert.ToDateTime("03/28/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStatusFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 o_id = 68;
            Found = AnOrder.Find(o_id);

            if (AnOrder.o_status != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestInformationFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 o_id = 68;
            Found = AnOrder.Find(o_id);
            if (AnOrder.o_information != "changer")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



        string o_information = "Dont Change this (Dummy)";
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
