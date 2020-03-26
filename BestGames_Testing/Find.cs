using System;
using BestGames_Libary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestGames_Testing
{
    
    [TestClass]
    public class Find
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }


        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.o_status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.o_status, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.o_date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.o_date, TestData);
        }


        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 4;
            //assign the data to the property
            AnOrder.o_id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.o_id, TestData);
        }


        [TestMethod]
        public void OrderInformationPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "fdghd";
            //assign the data to the property
            AnOrder.o_information = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.o_information, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 o_id = 4;
            //invoke the method
            Found = AnOrder.Find(o_id);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }



        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 o_id = 4;
            //invoke the method
            Found = AnOrder.Find(o_id);
            //check the address no
            if (AnOrder.o_id != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 o_id = 4;
            Found = AnOrder.Find(o_id);

            if (AnOrder.o_date != Convert.ToDateTime("12/16/2019"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStatusFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 o_id = 4;
            Found = AnOrder.Find(o_id);

            if (AnOrder.o_status != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestInformationFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 o_id = 4;
            Found = AnOrder.Find(o_id);
            if (AnOrder.o_information != "234234")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
