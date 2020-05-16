using System;
using System.Text;
using BestGames_Libary;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace BestGames_Testing
{
    
    [TestClass]
    public class tstOrderCollection
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
            TestItem.o_date = DateTime.Now.Date;
            TestItem.o_status = true;
            TestItem.o_information = "dfwef";
            

            TestList.Add(TestItem);
            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.OrderList, TestList);

        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();

            TestOrder.o_id = 2;
            TestOrder.o_date = DateTime.Now.Date;
            TestOrder.o_status = true;
            TestOrder.o_information = "dfwef";

            //TestOrder.o_id = 4;
            //TestOrder.o_information = "dfwef";
            //TestOrder.o_date = DateTime.Now.Date;
            //TestOrder.o_status = true;

            AllOrder.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();

            TestItem.o_id = 2;
            TestItem.o_date = DateTime.Now.Date;
            TestItem.o_status = true;
            TestItem.o_information = "dfwef";

            TestList.Add(TestItem);
            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {

            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.o_id = 2;
            TestItem.o_date = DateTime.Now.Date;
            TestItem.o_status = true;
            TestItem.o_information = "Add";
            TestItem.cus_id = 1;
            TestItem.s_id = 1;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.o_id = PrimaryKey;

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {

            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.o_date = DateTime.Now.Date;
            TestItem.o_status = true;
            TestItem.o_information = "dfwef";
            TestItem.cus_id = 1;
            TestItem.s_id = 1;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.o_id = PrimaryKey;

            AllOrders.ThisOrder.Find(PrimaryKey);

            AllOrders.Delete();

            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;

            
            TestItem.o_date = DateTime.Now.Date;
            TestItem.o_status = true;
            TestItem.o_information = "Update";
            TestItem.cus_id = 1;
            TestItem.s_id = 1;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.o_id = PrimaryKey;

            
            TestItem.o_date = DateTime.Now.Date;
            TestItem.o_status = true;
            TestItem.o_information = "Update";
            TestItem.cus_id = 1;
            TestItem.s_id = 1;

            AllOrders.ThisOrder = TestItem;

            AllOrders.Update();

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);


        }


        [TestMethod]
        public void ReportByOrderInformationMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrderCollection FilteredOrders = new clsOrderCollection();

            FilteredOrders.ReportByOrderInformation("");

            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);


        }

        [TestMethod]
        public void ReportByOrderInformationNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByOrderInformation("xxxxxxxxxxxx");
            Assert.AreEqual(0, FilteredOrders.Count);
        }


        [TestMethod]
        public void ReportByOrderInformationTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;

            FilteredOrders.ReportByOrderInformation("Test Data");

            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].o_id != 168)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].o_id != 169)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }






        

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    clsOrderCollection AllOrder = new clsOrderCollection();

        //    Int32 SomeCount = 2;
        //    AllOrder.Count = SomeCount;
        //    Assert.AreEqual(AllOrder.Count, SomeCount);

        //}


        


     

    }
}
