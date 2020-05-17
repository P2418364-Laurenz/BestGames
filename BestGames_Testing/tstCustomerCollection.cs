using System;
using System.Collections.Generic;
using BestGames_Libary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestGames_Testing
{

    [TestClass]
    public class tstCustomerCollection
    {

        [TestMethod]
        public void TestClass()
        {
            //test customer collection class can be instantiated
            clsCustomerCollection customerCollection = new clsCustomerCollection();
            //if not null which it shouldn't be
            Assert.IsNotNull(customerCollection);
        }
        [TestMethod]
        public void TestCustomerListOK()
        {
            //create customer list and see if it holds an item
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //LIST DOESN'T NEED TO BE CLEARED - IT IS SET (NOT ADDED TO) BEFORE ASSERT LINE
            //create comparison list
            List<clsCustomer> TestList = new List<clsCustomer>();
            //create customer to add to list
            clsCustomer TestItem = new clsCustomer();
            //add all user info
            TestItem.cusId = 1000;
            TestItem.cusName = "Rodney Dangerfield";
            TestItem.cusEmail = "rd@test.co.uk";
            TestItem.cusPassword = "password1234";
            TestItem.cusAccountStatus = true;
            TestItem.cusDateRegister = DateTime.Now.Date;
            //add testItem to a list I just created
            TestList.Add(TestItem);
            //add test item to allCustomers collection
            AllCustomers.CustomerList = TestList;
            //compare
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create list and check if you can access 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create test item
            clsCustomer TestItem = new clsCustomer();
            //create test properties
            TestItem.cusId = 1000;
            TestItem.cusName = "Rodney Dangerfield";
            TestItem.cusEmail = "rd@test.co.uk";
            TestItem.cusPassword = "password1234";
            TestItem.cusAccountStatus = true;
            TestItem.cusDateRegister = DateTime.Now.Date;
            //set allCustomers.thisCustomer as the customer I just created
            AllCustomers.ThisCustomer = TestItem;
            //compare
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void addMethodOK()
        {
            //create an instance of the class
            clsCustomerCollection collection = new clsCustomerCollection();
            //clear the collection (as collection will contain database records in construction as suggested)
            collection.clear();
            //create item of test data
            clsCustomer customer = new clsCustomer();
            //var to store the customer's ID (primary key from database)
            Int32 PrimaryKey = 0;
            //set its properties
            customer.cusId = 1000;
            customer.cusName = "Rodney Dangerfield";
            customer.cusEmail = "rd@test.co.uk";
            customer.cusPassword = "password1234";
            customer.cusAccountStatus = true;
            customer.cusDateRegister = DateTime.Now.Date;
            //set ThisCustomer to test data
            collection.ThisCustomer = customer;
            //add the data
            PrimaryKey = collection.Add();
            //set the primary key of the test data
            customer.cusId = PrimaryKey;
            //compare
            Assert.AreEqual(collection.ThisCustomer, customer);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection collection = new clsCustomerCollection();
            //create list item
            clsCustomer customer = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set properties
            customer.cusName = "Rodney Dangerfield";
            customer.cusEmail = "rd@test.co.uk";
            customer.cusPassword = "password1234";
            //set ThisCustomer to the test data
            collection.ThisCustomer = customer;
            //add record
            PrimaryKey = collection.Add();
            //find the record
            collection.ThisCustomer.Find(PrimaryKey);
            //delete the record via PrimaryKey
            collection.ThisCustomer.Delete(PrimaryKey);
            //find the record (should return false)
            Boolean Found = collection.ThisCustomer.Find(PrimaryKey);
            //compare
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance of class
            clsCustomerCollection collection = new clsCustomerCollection();
            //create item
            clsCustomer testCustomer = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set properties
            testCustomer.cusAccountStatus = true;
            testCustomer.cusDateRegister = DateTime.Now;
            testCustomer.cusEmail = "still-the-same@failed-the-test.net";
            testCustomer.cusName = "Name McNotChanged";
            testCustomer.cusPassword = "OldPass";
            //set thisCustomer to the test data
            collection.ThisCustomer = testCustomer;
            //add the record
            PrimaryKey = collection.Add();
            //set the primary key of the test data
            testCustomer.cusId = PrimaryKey;
            //modify the test data
            testCustomer.cusEmail = "changed@you-did-it.goodjob";
            testCustomer.cusName = "Name McChanged";
            testCustomer.cusPassword = "NewPass";
            testCustomer.cusAccountStatus = false;
            //set the record based on the new test data
            collection.ThisCustomer = testCustomer;
            //update the record
            collection.Update();
            //find the record
            collection.ThisCustomer.Find(PrimaryKey);
            //test compare
            Assert.AreEqual(collection.ThisCustomer, testCustomer);
        }
        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the class containing unfilitered results
            clsCustomerCollection data = new clsCustomerCollection();
            //create and instance of the filtered data
            clsCustomerCollection filteredData = new clsCustomerCollection();
            //apply a blank string (should return all records):
            filteredData.ReportByEmail("");
            //compare values
            Assert.AreEqual(data.Count, filteredData.Count);
        }

    }

}