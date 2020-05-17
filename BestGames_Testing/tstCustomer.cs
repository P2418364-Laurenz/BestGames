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
        public void TestClass()
        {
            //create new class and assert not equal to null
            clsCustomer aCustomer = new clsCustomer();
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void TestCusId()
        {
            //test Id property can assign
            clsCustomer aCustomer = new clsCustomer();
            aCustomer.cusId = 50;
            Assert.IsNotNull(aCustomer.cusId);
        }

        [TestMethod]
        public void TestCusName()
        {
            //test customer name property can assign
            clsCustomer aCustomer = new clsCustomer();
            aCustomer.cusName = "Test User";
            Assert.IsNotNull(aCustomer.cusName);
        }

        [TestMethod]
        public void TestCusEmail()
        {
            //test email property can assign
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
            //test account status property can assign
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
            //create new instance of class
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            //clear class (because it is generated with the SQL db entries 
            //in constructor as shown in Lab 23
            allCustomers.clear();
            //make new test customer without properties (it doesn't need them to show count works)
            clsCustomer tstCustomer1 = new clsCustomer();
            //add tst customer
            allCustomers.add(tstCustomer1);
            //compare contents of collection list count to actual count (1)
            Assert.AreEqual(allCustomers.Count, 1);
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
        public void testClear()
        {
            //create new customer collection
            clsCustomerCollection collection = new clsCustomerCollection();
            //make new test customer without properties (it doesn't need them to show clear works)
            clsCustomer tstCustomer1 = new clsCustomer();
            //add tst customer
            collection.add(tstCustomer1);
            //clear collection
            collection.clear();
            //create new empty list to compare to
            List<clsCustomer> emptyList = new List<clsCustomer>();
            //compare
            Assert.AreEqual(collection.Count, emptyList.Count);
        }

        [TestMethod]
        public void testAddCustomer()
        {
            //create new customer collection
            clsCustomerCollection customerList = new clsCustomerCollection();
            //clear collection
            customerList.clear();
            //add 2 test customers
            clsCustomer tstCustomer1 = new clsCustomer();
            tstCustomer1.cusName = "Tester1";
            clsCustomer tstCustomer2 = new clsCustomer();
            tstCustomer2.cusName = "Tester2";
            //create new test list
            List<clsCustomer> tstList = new List<clsCustomer>();
            //add 2 test customers to test list and customerList
            tstList.Add(tstCustomer1);
            tstList.Add(tstCustomer2);
            customerList.add(tstCustomer1);
            customerList.add(tstCustomer2);
            //compare
            Assert.AreEqual(customerList.customerAtIndex(1), tstList[1]);
        }

    }
}