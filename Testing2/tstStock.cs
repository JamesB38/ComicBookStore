using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {

        string StockAvailability = "10";
        string StockDescription = "King Kong";
        string StockPrice = "9.99";


        [TestMethod]
        public void InstanceOk()
        {
            clsStock AnStock = new clsStock();

            Assert.IsNotNull(AnStock);

        }

        [TestMethod]
        public void StockIDOk()
        {
            clsStock AnStock = new clsStock();

            Int32 testData = 1234;

            AnStock.StockID = testData;

            Assert.AreEqual(AnStock.StockID, testData);
        }

        [TestMethod]
        public void StockAvailabilityOk()
        {
            clsStock AnStock = new clsStock();

            Int32 testData = 4321;

            AnStock.StockAvailability = testData;

            Assert.AreEqual(AnStock.StockAvailability, testData);
        }

        [TestMethod]
        public void StockDescriptionOk()
        {
            clsStock AnStock = new clsStock();

            String testData = "This is a really good comic book";

            AnStock.StockDescription = testData;

            Assert.AreEqual(AnStock.StockDescription, testData);
        }

        [TestMethod]
        public void StockPriceOk()
        {
            clsStock AnStock = new clsStock();

            double testData = 9.99;

            AnStock.StockPrice = testData;

            Assert.AreEqual(AnStock.StockPrice, testData);
        }

        [TestMethod]
        public void IsBeingRestockedOk()
        {
            clsStock AnStock = new clsStock();

            Boolean testData = true;

            AnStock.IsBeingRestocked = testData;

            Assert.AreEqual(AnStock.IsBeingRestocked, testData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = true;

            Int32 StockID = 2;

            Found = AnStock.Find(StockID);

            Assert.IsTrue(Found);



        }

        [TestMethod]

        public void TestStockIDFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 1;

            Found = AnStock.Find(StockID);

            if(AnStock.StockID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestStockAvailabilityFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 1;

            Found = AnStock.Find(StockID);

            if (AnStock.StockAvailability != 10)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestStockDescriptionFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 1;

            Found = AnStock.Find(StockID);

            if (AnStock.StockDescription != "Demon Days: X-Men #1")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestStockPriceFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 1;

            Found = AnStock.Find(StockID);

            if (AnStock.StockPrice != 8.99)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestIsBeingRestockedFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 1;

            Found = AnStock.Find(StockID);

            if (AnStock.IsBeingRestocked != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOk()
        {
            clsStock AnStock = new clsStock();

            string Error = "";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreEqual(Error, "");

        }



    }
}
