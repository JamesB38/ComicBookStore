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

            Int32 TestData = 0004;

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

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Int32 CustomerID = 2;

            Found = ACustomer.Find(CustomerID);

            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer aCustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 21;

            Found = aCustomer.Find(CustomerID);

            if (aCustomer.CustomerID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDOBFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 21;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.CustomerDOB != Convert.ToDateTime("17/05/1999"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPhoneNoFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 21;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.CustomerPhoneNumber != 07456643218)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerFullNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 21;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.CustomerFullName != "Diogo Rodrigues")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestEmailSubscriptionFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 21;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.EmailSubscription != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }




    }
} 

