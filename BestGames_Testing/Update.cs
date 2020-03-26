using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BestGames_Libary;

namespace BestGames_Testing
{
    /// <summary>
    /// Summary description for Update
    /// </summary>
    [TestClass]
    public class Update
    {

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;

            TestItem.o_status = true;
            TestItem.o_date = DateTime.Now.Date;
            TestItem.o_information = "Update";

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.o_id = PrimaryKey;

            TestItem.o_date = DateTime.Now.Date;
            TestItem.o_status = false;
            TestItem.o_information = "changer";

            AllOrders.ThisOrder = TestItem;

            AllOrders.Update();

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);


        }
    }
}
