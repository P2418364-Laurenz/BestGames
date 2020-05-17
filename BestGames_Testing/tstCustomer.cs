using System;
using System.Collections.Generic;
using BestGames_Libary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestGames_Testing
{
    [TestClass]
    public class tstCustomer
    {

        string tstName = "Test Names";
        string tstEmail = "test@name.com";
        string tstPassword = "hidden";

        [TestMethod]
        public void ValidMethodOK()
        {
            //create  an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string var for errors and invoke method
            String error = "";
            error = aCustomer.Valid(tstName, tstEmail, tstPassword);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestCusNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //create soem test data to pass to the method
            string cusName = "";
            //invoke method
            error = aCustomer.Valid(cusName, tstEmail, tstPassword);
        }

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
        }

        [TestMethod]
        public void TestReturnAllFromDatabase()
        {
            clsCustomer aCustomer = new clsCustomer();
            Assert.IsTrue(aCustomer.getAllRecords().Length > 0);
        }

        [TestMethod]
        public void testOnlyContains()
        {
            clsCustomer aCustomer = new clsCustomer();
            Assert.AreEqual(aCustomer.onlyContains("abacadaba", "abcd"), true);
            Assert.AreEqual(aCustomer.onlyContains(";DROP *;execute;", "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"), false);
        }

        [TestMethod]
        public void customerCollectionOk()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer tstCustomer = new clsCustomer();
            tstCustomer.cusId = 1;
            tstCustomer.cusName = "Test Names";
            tstCustomer.cusEmail = "test@name.com";
            tstCustomer.cusPassword = "hidden";
            tstCustomer.cusDateRegister = new DateTime();
            tstCustomer.cusAccountStatus = true;
            Assert.IsNotNull(allCustomers);
            TestList.Add(tstCustomer);
            allCustomers.CustomerList = TestList;
            Assert.AreEqual(allCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void customerCollectionCount()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            clsCustomer tstCustomer1 = new clsCustomer();
            allCustomers.CustomerList.Add(tstCustomer1);
            Int32 count = 2;
            Assert.AreEqual(allCustomers.Count, count);
        }

        [TestMethod]
        public void thisCustomerCollection()
        {
            clsCustomerCollection customerList = new clsCustomerCollection();
            clsCustomer tstCustomer = new clsCustomer();
            tstCustomer.cusId = 1;
            tstCustomer.cusName = "Test Names";
            tstCustomer.cusEmail = "test@name.com";
            tstCustomer.cusPassword = "hidden";
            tstCustomer.cusDateRegister = new DateTime();
            tstCustomer.cusAccountStatus = true;
            customerList.ThisCustomer = tstCustomer;
            Assert.AreEqual(customerList.ThisCustomer, tstCustomer);
        }

        [TestMethod]
        public void testAddCustomer()
        {
            clsCustomerCollection customerList = new clsCustomerCollection();
            clsCustomer tstCustomer1 = new clsCustomer();
            tstCustomer1.cusName = "Tester1";
            clsCustomer tstCustomer2 = new clsCustomer();
            tstCustomer2.cusName = "Tester2";
            List<clsCustomer> tstList = new List<clsCustomer>();
            tstList.Add(tstCustomer1);
            tstList.Add(tstCustomer2);
            customerList.add(tstCustomer1);
            customerList.add(tstCustomer2);
            Assert.AreEqual(customerList.customerAtIndex(1), tstList[1]);
        }

    }
}