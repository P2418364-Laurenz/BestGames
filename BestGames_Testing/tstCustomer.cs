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
        public void TestGetCustomer()
        {
            clsCustomer aCustomer = new clsCustomer();
            aCustomer.getCustomer(5);
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void TestFilterCustomer()
        {
            clsCustomer aCustomer = new clsCustomer();
            aCustomer.cusId = 10007;
            clsCustomer testCustomer = new clsCustomer().filterCustomer(aCustomer);
            Assert.AreEqual(testCustomer.cusId, 10007);
            Assert.AreEqual(testCustomer.cusName, "Lewis");
        }

        [TestMethod]
        public void testOnlyContains()
        {
            clsCustomer aCustomer = new clsCustomer();
            Assert.AreEqual(aCustomer.onlyContains("abacadaba", "abcd"), true);
            Assert.AreEqual(aCustomer.onlyContains(";DROP *;execute;", "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"), false);
        }
    }
}