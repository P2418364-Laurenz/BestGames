using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BestGames_Libary;

namespace BestGames_Testing
{
    /// <summary>
    /// Summary description for Delete
    /// </summary>
    [TestClass]
    public class Delete
    {

        [TestMethod]
        public void DeleteMethodOK()
        {

            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.o_id = 1;
            TestItem.o_information = "1";
            TestItem.o_date = DateTime.Now.Date;
            TestItem.o_status = true;


            AllOrder.ThisOrder = TestItem;

            PrimaryKey = AllOrder.Add();

            TestItem.o_id = PrimaryKey;

            AllOrder.ThisOrder.Find(PrimaryKey);

            AllOrder.Delete();

            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);

            Assert.IsFalse(Found); 

        }
    }
}
