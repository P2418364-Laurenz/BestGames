using System;
using BestGames_Libary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestGames_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestClass()
        {
            clsCustomer aCustomer = new clsCustomer();
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void TestCusId()
        {
            clsCustomer aCustomer = new clsCustomer();
            aCustomer.cusId = 50;
            Assert.IsNotNull(aCustomer.cusId);
        }

        [TestMethod]
        public void TestCusName()
        {
            clsCustomer aCustomer = new clsCustomer();
            aCustomer.cusName = "Test User";
            Assert.IsNotNull(aCustomer.cusName);
        }

        [TestMethod]
        public void TestCusEmail()
        {
            clsCustomer aCustomer = new clsCustomer();
            aCustomer.cusEmail = "testing@test.net";
            Assert.IsNotNull(aCustomer.cusEmail);
        }

        [TestMethod]
        public void TestCusPassword()
        {
            clsCustomer aCustomer = new clsCustomer();
            aCustomer.cusPassword = "5ecretTestP4ssw0rd";
            Assert.IsNotNull(aCustomer.cusPassword);
        }

        [TestMethod]
        public void TestCusDateRegister()
        {
            clsCustomer aCustomer = new clsCustomer();
            Assert.IsNotNull(aCustomer.cusDateRegister);
        }

        [TestMethod]
        public void TestCusAccountStatus()
        {
            clsCustomer aCustomer = new clsCustomer();
            aCustomer.cusAccountStatus = true;
            Assert.IsNotNull(aCustomer.cusAccountStatus);
        }

        [TestMethod]
        public void TestSetCustomer()
        {
            clsCustomer aCustomer = new clsCustomer();
            aCustomer.setCustomer("Lewis Harris", "p2419279@my365.dmu.ac.uk", "Toor2345");
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void TestGetCustomer()
        {
            clsCustomer aCustomer = new clsCustomer();
            aCustomer.getCustomer(5);
            Assert.IsNotNull(aCustomer);
        }
    }
}