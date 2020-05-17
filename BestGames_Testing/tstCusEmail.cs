using System;
using BestGames_Libary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestGames_Testing
{
    [TestClass]
    public class tstCusEmail
    {
        //good data
        string tstName = "Test Name";
        string tstEmail = "test@name.com";
        string tstPassword = "hidden";

        //min - 1
        [TestMethod]
        public void cusEmailMinLengthLessOne()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data
            string MinLessOneEmail = "@.aa"; //trigger error
            //invoke the method
            error = customer.Valid(tstName, MinLessOneEmail, tstPassword);
            //compare
            Assert.AreNotEqual(error, ""); //will have error
        }

        //min
        [TestMethod]
        public void cusEmailMinLength()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data
            string TestEmail = "L@i.c";//shortest possible email doesn't trigger error
            //invoke the method
            error = customer.Valid(tstName, TestEmail, tstPassword);
            //compare
            Assert.AreEqual(error, ""); //doesn't trigger error
        }

        //min plus one
        [TestMethod]
        public void cusEmailMinPlusOne()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data
            string EmptyName = "L@i.co"; //doesn't trigger error
            //invoke the method
            error = customer.Valid(tstName, EmptyName, tstPassword);
            //compare
            Assert.AreEqual(error, "");
        }

        //max less one
        [TestMethod]
        public void cusEmailMaxLessOne()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with @ + . + 'a' being repeated 509 times
            string email = "@." + new string('a', 509); //max 512 - 2 (satisfy other tests @ + . check)
            //invoke the method
            error = customer.Valid(tstName, email, tstPassword);
            //compare
            Assert.AreEqual(error, "");
        }

        //max
        [TestMethod]
        public void cusEmailMaxLength()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with @ + . + 'a' being repeated 510 times
            string email = "@." + new string('a', 510); //doesn't trigger error
            //invoke the method
            error = customer.Valid(tstName, email, tstPassword);
            //compare
            Assert.AreEqual(error, "");
        }

        //mid
        [TestMethod]
        public void cusEmailMidLength()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with @ + . + 'a' being repeated
            string email = "@." + new string('a', (512-2)/2); //doesn't trigger error
            //invoke the method
            error = customer.Valid(tstName, email, tstPassword);
            //compare
            Assert.AreEqual(error, "");
        }

        //max+1
        [TestMethod]
        public void cusEmailMaxPlusOne()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with 'a' being repeated max+1 times
            string email = "@." + new string('a', 511); //trigger error 511+2=513 over by 1
            //invoke the method
            error = customer.Valid(tstName, email, tstPassword);
            //compare
            Assert.AreNotEqual(error, "");
        }

        //extreme max
        [TestMethod]
        public void cusEmailExtremeMax()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with 'a' being repeated 1000 times
            string email = "@." + new string('a', 1000); //trigger error with 500 chars
            //invoke the method
            error = customer.Valid(tstName, email, tstPassword);
            //compare
            Assert.AreNotEqual(error, "");
        }

        //test without @
        [TestMethod]
        public void cusEmailNoAtEmailSymbol()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with 'a' being repeated 500 times
            String email = "WrongEmail.my365.com"; //trigger error no @
            //invoke the method
            error = customer.Valid(tstName, email, tstPassword);
            //compare
            Assert.AreNotEqual(error, "");
        }

        //test without @
        [TestMethod]
        public void cusEmailNoDots()
        {
            //create instance
            clsCustomer customer = new clsCustomer();
            //error string
            String error = "";
            //add test data with 'a' being repeated 500 times
            String email = "WrongEmail@com"; //trigger error no .com
            //invoke the method
            error = customer.Valid(tstName, email, tstPassword);
            //compare
            Assert.AreNotEqual(error, "");
        }
    }
}
