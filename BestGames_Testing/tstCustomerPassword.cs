using System;
using BestGames_Libary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestGames_Testing
{
    [TestClass]
    public class tstCustomerPassword
    {
        //good data
        string tstName = "Test Name";
        string tstEmail = "test@name.com";
        //tstPassword not used - use specific dynamic password for each test
        //string tstPassword = "hidden";

        //min - 1
        [TestMethod]
        public void cusPassMinLengthLessOne()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data
            string pass = new string('a', 5); //trigger error
            //invoke the method
            error = customer.Valid(tstName, tstEmail, pass);
            //compare
            Assert.AreNotEqual(error, ""); //will have error
        }

        //min
        [TestMethod]
        public void cusPassMinLength()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data
            string pass = new string('a', 6);//shortest possible email doesn't trigger error
            //invoke the method
            error = customer.Valid(tstName, tstEmail, pass);
            //compare
            Assert.AreEqual(error, ""); //doesn't trigger error
        }

        //min plus one
        [TestMethod]
        public void cusPassMinPlusOne()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data
            string pass = new string('a', 7); //doesn't trigger error
            //invoke the method
            error = customer.Valid(tstName, tstEmail, pass);
            //compare
            Assert.AreEqual(error, "");
        }

        //max less one
        [TestMethod]
        public void cusPassMaxLessOne()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with 'a' being repeated 63 times
            string pass = new string('a', 63); //max 64 - 1
            //invoke the method
            error = customer.Valid(tstName, tstEmail, pass);
            //compare
            Assert.AreEqual(error, "");
        }

        //max
        [TestMethod]
        public void cusPassMaxLength()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data repeated 64 times
            string pass = new string('a', 64); //doesn't trigger error
            //invoke the method
            error = customer.Valid(tstName, tstEmail, pass);
            //compare
            Assert.AreEqual(error, "");
        }

        //mid
        [TestMethod]
        public void cusPassMidLength()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with 'a' repreated mid times
            string pass = new string('a', 34); //doesn't trigger error
            //invoke the method
            error = customer.Valid(tstName, tstEmail, pass);
            //compare
            Assert.AreEqual(error, "");
        }

        //max+1
        [TestMethod]
        public void cuPassMaxPlusOne()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with 'a' being repeated max+1 times
            string pass = new string('a', 65); //trigger error
            //invoke the method
            error = customer.Valid(tstName, tstEmail, pass);
            //compare
            Assert.AreNotEqual(error, "");
        }

        //extreme max
        [TestMethod]
        public void cusPassExtremeMax()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with 'a' being repeated 100 times
            string pass = new string('a', 100); //trigger error with 500 chars
            //invoke the method
            error = customer.Valid(tstName, tstEmail, pass);
            //compare
            Assert.AreNotEqual(error, "");
        }
    }
}
