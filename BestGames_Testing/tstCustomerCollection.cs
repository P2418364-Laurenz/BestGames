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
            clsCustomerCollection customerCollection = new clsCustomerCollection();
            Assert.IsNotNull(customerCollection);
        }
        [TestMethod]
        public void TestCustomerListOK()
        {
            //create customer list and see if it holds an item
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.cusId = 1000;
            TestItem.cusName = "Rodney Dangerfield";
            TestItem.cusEmail = "rd@test.co.uk";
            TestItem.cusPassword = "password1234";
            TestItem.cusAccountStatus = true;
            TestItem.cusDateRegister = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create list and check if you can access 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            TestItem.cusId = 1000;
            TestItem.cusName = "Rodney Dangerfield";
            TestItem.cusEmail = "rd@test.co.uk";
            TestItem.cusPassword = "password1234";
            TestItem.cusAccountStatus = true;
            TestItem.cusDateRegister = DateTime.Now.Date;
            AllCustomers.ThisCustomer = TestItem;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
    }

}