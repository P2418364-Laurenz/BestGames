using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BestGames_Libary;

namespace BestGames_Testing
{

    [TestClass]
    public class Filter
    {
       
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

            FilteredOrders.ReportByOrderInformation("xxx");

            if(FilteredOrders.Count == 2)
            {
                if(FilteredOrders.OrderList[0].o_id != 12)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].o_id != 14)
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
    }
}
