using System;
using System.Text;
using BestGames_Libary;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestGames_Testing
{
    
    [TestClass]
    public class Add
    {

        [TestMethod]
        public void AddMethodOK()
        {

            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.o_id = 1;
            TestItem.o_date = DateTime.Now.Date;
            TestItem.o_information = "Testing";
            TestItem.o_status = true;

            AllOrder.ThisOrder = TestItem;

            PrimaryKey = AllOrder.Add();

            TestItem.o_id = PrimaryKey;

            AllOrder.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrder.ThisOrder, TestItem);

        }
    }
}
