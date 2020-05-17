using System;
using BestGames_Libary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestGames_Testing
{
    [TestClass]
    public class tstCusName
    {
        //good data
        string tstName = "Test Name";
        string tstEmail = "test@name.com";
        string tstPassword = "hidden";

        //min - 1
        [TestMethod]
        public void cusNameMinLengthLessOne()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data
            string EmptyName = ""; //trigger error
            //invoke the method
            error = customer.Valid(EmptyName, tstEmail, tstPassword);
            //compare
            Assert.AreNotEqual(error, ""); //will have error
        }
        
        //min
        [TestMethod]
        public void cusNameMinLength()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data
            string EmptyName = "L";
            //invoke the method
            error = customer.Valid(EmptyName, tstEmail, tstPassword);
            //compare
            Assert.AreEqual(error, ""); //doesn't trigger error
        }

        //min plus one
        [TestMethod]
        public void cusNameMinPlusOne()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data
            string EmptyName = "aa"; //doesn't trigger error
            //invoke the method
            error = customer.Valid(EmptyName, tstEmail, tstPassword);
            //compare
            Assert.AreEqual(error, "");
        }

        //max less one
        [TestMethod]
        public void cusNameMaxLessOne()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with 'a' being repeated 255 times
            string chars255 = new string('a', 255); //doesn't trigger error
            //invoke the method
            error = customer.Valid(chars255, tstEmail, tstPassword);
            //compare
            Assert.AreEqual(error, "");
        }

        //max
        [TestMethod]
        public void cusNameMaxLength()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with 'a' being repeated 256 times
            string chars256 = new string('a', 256); //doesn't trigger error
            //invoke the method
            error = customer.Valid(chars256, tstEmail, tstPassword);
            //compare
            Assert.AreEqual(error, "");
        }

        //max
        [TestMethod]
        public void cusNameMidLength()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with 'a' being repeated 128 times
            string chars128 = new string('a', 128); //doesn't trigger error
            //invoke the method
            error = customer.Valid(chars128, tstEmail, tstPassword);
            //compare
            Assert.AreEqual(error, "");
        }

        //max
        [TestMethod]
        public void cusNameMaxPlusOne()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with 'a' being repeated 257 times
            string chars257 = new string('a', 257); //trigger error
            //invoke the method
            error = customer.Valid(chars257, tstEmail, tstPassword);
            //compare
            Assert.AreNotEqual(error, "");
        }

        //extreme max
        [TestMethod]
        public void cusNameExtremeMax()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with 'a' being repeated 500 times
            string chars500 = new string('a', 500); //trigger error
            //invoke the method
            error = customer.Valid(chars500, tstEmail, tstPassword);
            //compare
            Assert.AreNotEqual(error, "");
        }
    }
}
