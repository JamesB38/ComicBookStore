using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCustomer ACustomer = new clsCustomer();

            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void EmailSubPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean TestData = true;

            ACustomer.EmailSubscription = TestData;

            Assert.AreEqual(ACustomer.EmailSubscription, TestData);
        }

        [TestMethod]
        public void CustomerFNPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            string TestData = "Diogo Rodrigues";

            ACustomer.CustomerFullName = TestData;

            Assert.AreEqual(ACustomer.CustomerFullName, TestData);
        }

        [TestMethod]
        public void CustomerPNoPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            long TestData = 07415564047;

            ACustomer.CustomerPhoneNumber = TestData;

            Assert.AreEqual(ACustomer.CustomerPhoneNumber, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            int TestData = 0004;

            ACustomer.CustomerID = TestData;

            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }


        [TestMethod]
        public void CustomerDOBPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            DateTime TestData = DateTime.Now.Date;

            ACustomer.CustomerDOB = TestData;

            Assert.AreEqual(ACustomer.CustomerDOB, TestData);
        }



    }
}
