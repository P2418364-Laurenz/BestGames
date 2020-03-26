using System;
using BestGames_Libary;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestGames_Testing
{
    /// <summary>
    /// Summary description for Collection
    /// </summary>
    [TestClass]
    public class Collection
    {



        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Assert.IsNotNull(AllOrder);
        }


        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();

            TestItem.o_id = 4;
            TestItem.o_information = "dfwef";
            TestItem.o_date = DateTime.Now.Date;
            TestItem.o_status = true;

            TestList.Add(TestItem);
            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.OrderList, TestList);

        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    clsOrderCollection AllOrder = new clsOrderCollection();

        //    Int32 SomeCount = 2;
        //    AllOrder.Count = SomeCount;
        //    Assert.AreEqual(AllOrder.Count, SomeCount);

        //}


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();

            TestOrder.o_id = 4;
            TestOrder.o_information = "dfwef";
            TestOrder.o_date = DateTime.Now.Date;
            TestOrder.o_status = true;

            AllOrder.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);

        }


        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();

            TestItem.o_id = 4;
            TestItem.o_information = "dfwef";
            TestItem.o_date = DateTime.Now.Date;
            TestItem.o_status = true;

            TestList.Add(TestItem);
            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.Count, TestList.Count);

        }



        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    clsOrderCollection AllOrder = new clsOrderCollection();

        //    Assert.AreEqual(AllOrder.Count, 2);

        //}


    }
}
